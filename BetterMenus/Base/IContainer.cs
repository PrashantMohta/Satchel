namespace Satchel.BetterMenus
{
    /// <summary>
    /// An interface for classes that contain elements. 
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Find an Element that is in the Container.
        /// </summary>
        /// <param name="Id">The Id of the element that is to be found.</param>
        /// <returns>The Element if found. else logs errors and returns null.</returns>
        public Element Find(string Id);
        /// <summary>
        /// Updates visibility of all elements, and updates container
        /// </summary>
        /// <param name="silent">Whether or not to call subscribers to OnReflow.</param>
        /// <returns></returns>
        public void Reflow(bool silent = false);
        /// <summary>
        /// Event for when reflow of the container happens
        /// </summary>
        public event EventHandler<ReflowEventArgs> OnReflow;
        /// <summary>
        /// Event for when the container is built
        /// </summary>
        public event EventHandler<ContainerBuiltEventArgs> OnBuilt;
        /// <summary>
        /// Calls all subscribers to OnBuilt
        /// </summary>
        /// <returns></returns>
        public void TriggerBuiltEvent();
    }
}