namespace Satchel.BetterMenus
{
    public class BaseEventArgs : EventArgs {
        public BaseElement Target { get; set; }
    }
    public class UpdateEventArgs : BaseEventArgs{}
    public class ValueChangeEventArgs : BaseEventArgs{}
    public class VisibilityChangeEventArgs : BaseEventArgs{}
    public class ReflowEventArgs : BaseEventArgs{}
    public class ContainerBuiltEventArgs : BaseEventArgs{}

}