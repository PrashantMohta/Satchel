using Modding.Menu;
using Modding.Menu.Config;
using System.Linq;
using UnityEngine.UI;
namespace Satchel.BetterMenus
{
    /// <summary>
    /// The class that needs to be instantiated to create a better menu
    /// </summary>
    public class Menu : MenuElement, IContainer{
        private readonly List<Element> Elements = new();
        private readonly Dictionary<String,Element> ElementDict = new();
        
        #region Internal Fields
        //some private atributes we need because we intend to reorder the menu
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

        //list that stores the order.
        public List<GameObjectRow> MenuOrder = new List<GameObjectRow>();
        #endregion
        
        
        /// <summary>
        /// the MenuScreen of the Menu
        /// </summary>
        public MenuScreen menuScreen;

        /// <summary>
        /// the "previous" menu screen. It is the screen the game will return to to on back button press or esc
        /// </summary>
        public MenuScreen returnScreen;

        /// <summary>
        /// Adds an element to the menu
        /// </summary>
        /// <param name="elem">the new element to be added</param>
        public void AddElement(Element elem){
            Elements.Add(elem);
            ElementDict[elem.Id] = elem;
        }
        
        /// <summary>
        /// Creates a new instance of Menu. This is used to create a better menu
        /// <para/>Use Menu.Create for creating custom menus instead.
        /// </summary>
        public Menu(string name, Element[] elements)
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
        private IEnumerator ShowMenu(On.UIManager.orig_ShowMenu orig, UIManager self, MenuScreen menu){
            if(menu == this.menuScreen){
                menu.screenCanvasGroup.alpha = 0f;
                menu.screenCanvasGroup.gameObject.SetActive(true);
                UpdateInternal();
                menu.screenCanvasGroup.gameObject.SetActive(false);
            }
            yield return orig(self,menu);
        }
        /// <summary>
        /// Returns the element with the id given in the Menu. The element found can then be used to edit its properties
        /// </summary>
        /// <param name="ElementId">The id of the element to find. If not specified, id is the name of the element</param>
        /// <returns></returns>
        public Element Find(string ElementId){
            if(ElementDict.TryGetValue(ElementId, out var elem)){
                return elem;
            }
            Satchel.Instance.LogError($"No such Element with id {ElementId}");
            return null;
        }

        /// <summary>
        /// Creates a new MenuScreen from the Menu to be used by Modding API to create mod menu.
        /// </summary>
        /// <param name="_returnScreen">the "previous" menu screen. It is the screen the game will return to to on back button press or esc</param>
        /// <returns>The MenuScreen returned is what needs to be given to the Modding API to have a modmenu</returns>
        public MenuScreen GetMenuScreen(MenuScreen _returnScreen)
        {
            returnScreen = _returnScreen;
            CancelAction = () => { 
                Utils.GoToMenuScreen(returnScreen); 
            };
            MenuBuilder Menu = Utils.CreateMenuBuilder(Name); //create main screen
            UnityEngine.UI.MenuButton backButton = null; //just so we can use it in scroll bar
            Menu.AddContent(new NullContentLayout(), c => c.AddScrollPaneContent(
                new ScrollbarConfig
                {
                    CancelAction = _ => CancelAction(),
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
                d => AddModMenuContent(Elements, d)
            ));
            
            Menu.AddBackButton(Instance, out backButton); // add a back button
            menuScreen = Menu.Build();
            TriggerBuiltEvent();
            return menuScreen;
        }

        private void ApplyElementVisibility(Element elem){
            if(elem.gameObject == null){
                if(elem is IShadowElement){
                    var elems = ((IShadowElement)elem).GetElements();
                    foreach(var e in elems){
                        ApplyElementVisibility(e);
                    }
                } else {
                    Satchel.Instance.LogError($"No GameObject for {elem.GetType()} {elem.Name}");
                }
            } else {
                elem.gameObject.SetActive(elem.isVisible);
            }
        }
        private void AddModMenuContent(List<Element> AllMenuOptions, ContentArea c)
        {
            //go through the list given to us by user
            foreach (var menuOption in AllMenuOptions)
            {
                menuOption.Parent = this;
                menuOption.Create(c, Instance);
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
        /// <summary>
        /// Event for when the Menu is built
        /// </summary>
        public event EventHandler<ContainerBuiltEventArgs> OnBuilt;
        public void TriggerBuiltEvent(){
            OnBuilt?.Invoke(this,new ContainerBuiltEventArgs{
                Target = this
            });
        }
        /// <summary>
        /// Event for when reflow of the container happens
        /// </summary>
        public event EventHandler<ReflowEventArgs> OnReflow;
        
        /// <summary>
        /// Updates visibility of all elements, and updates menu 
        /// </summary>
        /// <param name="silent">Whether or not to call subscribers to OnReflow.</param>
        /// <returns></returns>
        public void Reflow(bool silent = false){
            
            Elements.ForEach(ApplyElementVisibility);
            
            Reorder();
            if(!silent){
                OnReflow?.Invoke(this,new ReflowEventArgs{
                    Target = this
                });
            }
        }
        /// <summary>
        /// Reorders the all the Elements in the menu
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
        /// <param name="modListMenu">The MenuScreen of the returning screen (when back is pressed)</param>
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
        /// <param name="modListMenu">The MenuScreen of the returning screen (when back is pressed)</param>
        /// <param name="MenuOptions">The Elements to add.</param>
        /// <returns>The generated MenuScreen.</returns>
        public static MenuScreen Create(string Title, MenuScreen modListMenu, Element[] MenuOptions) {
            return new Menu(Title, MenuOptions).GetMenuScreen(modListMenu);
        }
        /// <summary>
        /// A funtion to update the title and all elements and reflow the menu
        /// </summary>
        public override void Update()
        {
            this.menuScreen.gameObject.Find("Title").GetComponent<Text>().text = Name;
            Elements.ForEach(elem => elem.Update());
            
            Reflow();
        }

        //allows CancelAction to be set by outsider
        public Action CancelAction;
    }
}
