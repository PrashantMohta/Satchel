using System;

namespace Satchel.BetterMenus{
    public interface IContainer{
        public Element Find(string Id);
        public void Reflow(bool silent = false);
        public event EventHandler<ReflowEventArgs> OnReflow;
    }
}