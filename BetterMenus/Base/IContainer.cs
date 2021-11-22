using System;

namespace Satchel.BetterMenus{
    public interface IContainer{
        public void Reflow();
        public event EventHandler<ReflowEventArgs> OnReflow;
        // for future
        //public bool hasScroll {get; private set;}
        //public Rect GetBounds(); 
    }
}