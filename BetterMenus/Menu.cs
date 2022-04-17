using Modding.Menu;
using Modding.Menu.Config;
using System.Linq;
using UnityEngine.UI;
namespace Satchel.BetterMenus
{
    public class Menu : MenuElement, IContainer{
        private readonly List<Element> Elements = new();
        private readonly Dictionary<String,Element> ElementDict = new();
        
        #region Fields
        //some private atributes we need because we intent to reorder the menu
        private int Columns = 1;
        private int Index = 0;
        private Menu Instance;
        private RelVector2 ItemAdvance = new RelVector2(new Vector2(0.0f, -105f));
        private AnchoredPosition Start = new AnchoredPosition
        {
            ChildAnchor = new Vector2(0.5f, 1f),
            ParentAnchor = new Vector2(0.5f, 1f),
            Offset = default
        };

        //list that stores the order. max items per column is 2 thats why we use tuple
        internal List<GameObjectRow> MenuOrder = new List<GameObjectRow>();
        #endregion

        public void AddElement(Element elem){
            Elements.Add(elem);
            ElementDict[elem.Id] = elem;
        }
        //not really sure if we need this or not
        /// <summary>
        /// Creates a new Menu instance. Generally, this is not needed.
        /// <para/>Use Menu.Create for creating custom menus instead.
        /// </summary>
        public Menu(string name,Element[] elements)
        {
            Parent = null; // menu has no Parent
            gameObject = null; // no go
            Name = name;
            foreach(var elem in elements){
               AddElement(elem);
            }
            Instance = this;
            MenuOrder.Clear();
            ResetPositioners();
            On.UIManager.ShowMenu += ShowMenu;
        }
        public MenuScreen menuScreen;
        public IEnumerator ShowMenu(On.UIManager.orig_ShowMenu orig, UIManager self, MenuScreen menu){
            if(menu == this.menuScreen){
                menu.screenCanvasGroup.alpha = 0f;
                menu.screenCanvasGroup.gameObject.SetActive(value: true);
                UpdateInternal();
                menu.screenCanvasGroup.gameObject.SetActive(value: false);
            }
            yield return orig(self,menu);
        }
        public Element Find(string Id){
            
            /*foreach(KeyValuePair<string,Element> kvp in ElementDict){
                Modding.Logger.Log(kvp.Key);
            }*/
            
            if(ElementDict.TryGetValue(Id,out var elem)){
                return elem;
            }
            Modding.Logger.LogError($"No such Element with id {Id}");
            return null;
        }

        /// <summary>
        /// Creates a new MenuScreen with the provided variables.
        /// </summary>
        /// <param name="modListMenu">The MenuScreen to add.</param>
        /// <returns>The created MenuScreen.</returns>
        public MenuScreen GetMenuScreen(MenuScreen modListMenu)
        {
            MenuBuilder Menu = Utils.CreateMenuBuilder(Name); //create main screen
            UnityEngine.UI.MenuButton backButton = null; //just so we can use it in scroll bar
            //mapi code from IMenuMod
            if (Elements.Count() > 5)
            {
                Menu.AddContent(new NullContentLayout(), c => c.AddScrollPaneContent(
                    new ScrollbarConfig
                    {
                        CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modListMenu),
                        Navigation = new Navigation
                        {
                            mode = Navigation.Mode.Explicit,
                            selectOnUp = backButton,
                            selectOnDown = backButton
                        },
                        Position = new AnchoredPosition
                        {
                            ChildAnchor = new Vector2(0f, 1f),
                            ParentAnchor = new Vector2(1f, 1f),
                            Offset = new Vector2(-310f, 0f)
                        }
                    },
                    new RelLength(Elements.Count() * 105f),
                    RegularGridLayout.CreateVerticalLayout(105f),
                    d => AddModMenuContent(Elements, d, modListMenu)
                ));
            }
            else
            {
                Menu.AddContent(
                    RegularGridLayout.CreateVerticalLayout(105f),
                    c => AddModMenuContent(Elements, c, modListMenu)
                );
            }

            Menu.AddBackButton(modListMenu, out backButton); // add a back button
            menuScreen = Menu.Build();
            TriggerBuiltEvent();
            return menuScreen;
        }

        public void ApplyElementVisibility(Element elem){
            if(elem.gameObject == null){
                if(elem is IShadowElement){
                    var elems = ((IShadowElement)elem).GetElements();
                    foreach(var e in elems){
                        ApplyElementVisibility(e);
                    }
                } else {
                    Modding.Logger.LogError($"No GameObject for {elem.GetType()} {elem.Name}");
                }
            } else {
                elem.gameObject.SetActive(elem.isVisible);
            }
        }
        private void AddModMenuContent(List<Element> AllMenuOptions, ContentArea c, MenuScreen modListMenu)
        {
            //go through the list given to us by user
            foreach (var menuOption in AllMenuOptions)
            {
                menuOption.Parent = this;
                menuOption.Create(c, modListMenu, Instance);
                ApplyElementVisibility(menuOption);
            }
        }

        private void ResetPositioners()
        {
            ItemAdvance = new RelVector2(new Vector2(0.0f, -105f));
            Start = new AnchoredPosition
            {
                ChildAnchor = new Vector2(0.5f, 1f),
                ParentAnchor = new Vector2(0.5f, 1f),
                Offset = default
            };

            Index = 0;
        }

        //from mapi
        private void ModifyNext(GameObject go)
        {
            if (go.gameObject.activeInHierarchy)
            {
                (Start + ItemAdvance * (Vector2)IndexPos).Reposition(go.gameObject.GetComponent<RectTransform>());
                Index++;
            }
        }

        public event EventHandler<ContainerBuiltEventArgs> OnBuilt;
        public void TriggerBuiltEvent(){
            OnBuilt?.Invoke(this,new ContainerBuiltEventArgs{
                Target = this
            });
        }

        public event EventHandler<ReflowEventArgs> OnReflow;
        public void Reflow(bool silent = false){
            foreach (var menuOption in Elements)
            {
                ApplyElementVisibility(menuOption);
            }
            Reorder();
            if(!silent){
                OnReflow?.Invoke(this,new ReflowEventArgs{
                    Target = this
                });
            }
        }
        /// <summary>
        /// Reorders the GameObjectRows in this instance.
        /// </summary>
        public void Reorder()
        {
            foreach (GameObjectRow GoRow in Instance.MenuOrder)
            {
                var columnCount = GoRow.ActiveCount();

                var l = ItemAdvance;
                if(columnCount > 1){
                    var XDelta = GoRow.Parent != null ? ((MenuRow)GoRow.Parent).XDelta : 750f; 
                    l.x = new RelLength(XDelta); // this breaks shit if not done on Element
                    ChangeColumns(columnCount, 0.5f, l, 0.5f);
                }
                foreach( var go in GoRow.Row){
                    if(go != null){
                        ModifyNext(go);
                    }
                }
                if(columnCount > 1){
                    var k = ItemAdvance;
                    k.x = new RelLength(0f);
                    ChangeColumns(1, 0.5f - (1f/(2f*columnCount)), k, 0.5f);
                    // we assume next row is a single column and same width as our current columns
                    // and set the position of the start of next grid when center aligned in terms of current grid
                    // so we substract half of it's width (in terms of the whole width of our current grid)
                    // from the center 
                }
            }
            ResetPositioners();
        }

        //from  mapi
        private Vector2Int IndexPos => new Vector2Int(Index % Columns, Index / Columns);

        //from mapi
        // originalAnchor needs the % of the previous width where the new grid needs to start
        // newSize is the size of the new grid
        // newAnchor is % of current width where the anchor should be
        private void ChangeColumns(int columns, float originalAnchor = 0.5f, RelVector2? newSize = null, float newAnchor = 0.5f)
        {
            RelVector2 relVector2 = newSize ?? ItemAdvance;
            RelVector2 itemAdvance = ItemAdvance;
            RelLength y = itemAdvance.y * (float)IndexPos.y;
            itemAdvance = ItemAdvance;
            RelLength relLength = itemAdvance.x * (float)Columns * originalAnchor - relVector2.x * (float)columns * newAnchor;
            RelLength x = Start.ChildAnchor.x * relVector2.x + relLength;
            Index = 0;
            Columns = columns;
            Start += new RelVector2(x, y);
            ItemAdvance = relVector2;
        }

        /// <summary>
        /// Generates a new MenuScreen.
        /// </summary>
        /// <param name="Title">The title to be displayed.</param>
        /// <param name="modListMenu">The MenuScreen to add.</param>
        /// <param name="MenuOptions">The Elements to add.</param>
        /// <param name="betterMenuMod">The created Menu. (Can in most cases be assigned to discard.)</param>
        /// <returns>The generated MenuScreen.</returns>
        public static MenuScreen Create(string Title, MenuScreen modListMenu, Element[] MenuOptions, out Menu betterMenuMod)
        {
            betterMenuMod = new Menu(Title,MenuOptions);
            return betterMenuMod.GetMenuScreen(modListMenu); 
        }
        /// <summary>
        /// Generates a new MenuScreen.
        /// </summary>
        /// <param name="Title">The title to be displayed.</param>
        /// <param name="modListMenu">The MenuScreen to add.</param>
        /// <param name="MenuOptions">The Elements to add.</param>
        /// <returns>The generated MenuScreen.</returns>
        public static MenuScreen Create(string Title, MenuScreen modListMenu, Element[] MenuOptions) {
            return new Menu(Title,MenuOptions).GetMenuScreen( modListMenu);
        }

        public override void Update()
        {
            //todo update title text etc
            foreach(var elem in Elements){
                elem.Update();
            }
            Reflow();
        }
    }
}