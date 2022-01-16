using System;
namespace Satchel.BetterMenus{
    /// <summary>
    /// Base class for EventArgs for Menu Events
    /// </summary>
    public class BaseEventArgs : EventArgs {
        /// <summary>
        /// The target menu element for the event
        /// </summary>
        public BaseElement Target { get; set; }
    }
    /// <summary>
    /// EventArgs for update event
    /// </summary>
    public class UpdateEventArgs : BaseEventArgs{}
    /// <summary>
    /// EventArgs for value change event
    /// </summary>
    public class ValueChangeEventArgs : BaseEventArgs{}
    /// <summary>
    /// EventArgs for visibility change event
    /// </summary>
    public class VisibilityChangeEventArgs : BaseEventArgs{}
    /// <summary>
    /// EventArgs for reflow event
    /// </summary>
    public class ReflowEventArgs : BaseEventArgs{}
    /// <summary>
    /// EventArgs for container build event
    /// </summary>
    public class ContainerBuiltEventArgs : BaseEventArgs{}

}