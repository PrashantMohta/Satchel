using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Modding;
using Modding.Menu;
using UnityEngine;

namespace Satchel.BetterMenus{
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
        public bool isVisible { get; private set; } = true;
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

        public void UpdateInternal(){
            Update();
            OnUpdate?.Invoke(this,new UpdateEventArgs{
                Target = this
            });
        }

        public void updateAfter(Action<BaseElement> callback){
            callback(this);
            UpdateInternal();
        }
    }
    public abstract class Element : BaseElement{
        public Element(string Id) : base(Id){}
        public Element(string Id,string Name) : base(Id,Name){}
        public abstract GameObjectPair Create(ContentArea c, MenuScreen modlistMenu, Menu Instance, bool AddToList = true);
        
    }

    public abstract class MenuElement : BaseElement{
    }
}