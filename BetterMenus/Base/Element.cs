using Modding.Menu;

namespace Satchel.BetterMenus
{
    public abstract class BaseElement{


        /// <summary>
        /// The Identifier used to refer to this element.
        /// </summary>
        public string Id { get; protected set;}

        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name;

        public GameObject gameObject
        {
            get;
            protected set;
        }
        public BaseElement Parent; // reference to the parent (menu may also be an Element)
        public event EventHandler<UpdateEventArgs> OnUpdate;
        public event EventHandler<VisibilityChangeEventArgs> OnVisibilityChange;
        
        public BaseElement(){}
        public BaseElement(string Id){
            this.Id = Id;
        }
        public BaseElement(string Id, string Name){
            this.Id = Id == "__UseName" ? Name : Id;
        }
        public abstract void Update();
        public bool isVisible { get; set; } = true;
        public void Show(){
            if(isVisible == true){ return; }
            isVisible = true;
            UpdateInternal();
            OnVisibilityChange?.Invoke(this,new VisibilityChangeEventArgs{
                Target = this
            });
        }

        public void Hide(){
            if(isVisible == false){ return; }
            isVisible = false;
            UpdateInternal();
            OnVisibilityChange?.Invoke(this,new VisibilityChangeEventArgs{
                Target = this
            });
        }

        internal void UpdateInternal(){
            Update();
            OnUpdate?.Invoke(this,new UpdateEventArgs{
                Target = this
            });
            if(Parent!=null){
                ((IContainer)Parent)?.Reflow();
            }
        }

        public void updateAfter(Action<BaseElement> callback){
            callback(this);
            UpdateInternal();
        }
    }
    public abstract class Element : BaseElement{
        public Element(string Id) : base(Id){}
        public Element(string Id,string Name) : base(Id,Name){}

         /// <summary>
        /// Creates a GameObjectRow based on the current variables.
        /// </summary>
        /// <param name="c">The ContentArea on which the ButtonBind is created.</param>
        /// <param name="modlistMenu">The previous MenuScreen.</param>
        /// <param name="Instance">The current Menu instance.</param>
        /// <param name="AddToList">Should this element be added to the MenuOrder (All non IShadowElements).</param>
        /// <returns>The created GameObjectRow which can be used to add to the corresponding Lists.</returns>
        public abstract GameObjectRow Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true);
        
        //todo implement AddImagePanel
    }

    public abstract class MenuElement : BaseElement{
    }

}