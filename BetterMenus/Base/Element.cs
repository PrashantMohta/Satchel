using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Modding;
using Modding.Menu;
using UnityEngine;

namespace Satchel.BetterMenus{
    /// <summary>
    /// The abstract class that Element is based on 
    /// </summary>
    public abstract class BaseElement{

        /// <summary>
        /// The Identifier used to refer to this element.
        /// </summary>
        public string Id { get; protected set;}

        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name;

        /// <summary>
        /// the GameObject of the element
        /// </summary>
        public GameObject gameObject
        {
            get;
            protected set;
        }
        /// <summary>
        /// reference to the parent (menu may also be an Element)
        /// </summary>
        public BaseElement Parent; 
        /// <summary>
        /// Event that happens on update of the element
        /// </summary>
        public event EventHandler<UpdateEventArgs> OnUpdate;
        /// <summary>
        /// Event that happens on visibility change of the element
        /// </summary>
        public event EventHandler<VisibilityChangeEventArgs> OnVisibilityChange;
        
        /// <summary>
        /// default constructor
        /// </summary>
        public BaseElement(){}
        
        /// <summary>
        /// constructor that takes in id
        /// </summary>
        ///<param name="Id">the id of the element that can be used to search for it</param>
        public BaseElement(string Id){
            this.Id = Id;
        }
        /// <summary>
        /// constructor that takes in id and name
        /// </summary>
        ///<param name="Id">the id of the element that can be used to search for it</param>
        /// <param name="Name">the name of the element</param>
        public BaseElement(string Id, string Name){
            this.Id = Id == "__UseName" ? Name : Id;
        }
        /// <summary>
        /// The function to call to update the element
        /// </summary>
        public abstract void Update();
        /// <summary>
        /// a bool that stores whether the element is hidden or visible
        /// </summary>
        public bool isVisible { get; set; } = true;
        
        /// <summary>
        /// Makes isVisible true and updates and reflows the menu to reflect that
        /// </summary>
        public void Show(){
            if(isVisible == true){ return; }
            isVisible = true;
            UpdateInternal();
            OnVisibilityChange?.Invoke(this,new VisibilityChangeEventArgs{
                Target = this
            });
        }
        /// <summary>
        /// Makes isVisible false and updates and reflows the menu to reflect that
        /// </summary>
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

        /// <summary>
        /// a function that gives you access to the element and can be used to update it
        /// </summary>
        /// <param name="callback">an function that takes in BaseElement as a parameter which can be used to update it</param>
        public void updateAfter(Action<BaseElement> callback){
            callback(this);
            UpdateInternal();
        }
    }
    /// <summary>
    /// The abstract class that is the base for all Elements in the Menu
    /// </summary>
    public abstract class Element : BaseElement{
        /// <summary>
        /// constructor that takes in id
        /// </summary>
        ///<param name="Id">the id of the element that can be used to search for it</param>
        public Element(string Id) : base(Id){}
        
        /// <summary>
        /// constructor that takes in id and name
        /// </summary>
        ///<param name="Id">the id of the element that can be used to search for it</param>
        /// <param name="Name">the name of the element</param>
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

    /// <summary>
    /// abstract class for a MenuElement
    /// </summary>
    public abstract class MenuElement : BaseElement{
    }

}