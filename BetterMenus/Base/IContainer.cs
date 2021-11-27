using System;

namespace Satchel.BetterMenus{
    public interface IContainer{
        public void Reflow(bool silent = false);
        public event EventHandler<ReflowEventArgs> OnReflow;
    }
}