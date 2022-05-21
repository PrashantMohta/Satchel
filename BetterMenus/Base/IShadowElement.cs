namespace Satchel.BetterMenus
{
    /// <summary>
    /// An interface for elements that can contain other elements
    /// </summary>
    public interface IShadowElement {
        /// <summary>
        /// Gets an array of all elements in the ShadowElement.
        /// </summary>
        /// <returns>The array of elements under the IShadowElement.</returns>
        public Element[] GetElements();

        /// <summary>
        /// Find an Element that is under the IShadowElement.
        /// </summary>
        /// <param name="Id">The Id of the element that is to be found.</param>
        /// <returns>The Element if found. else logs errors and returns null.</returns>
        public Element Find(string Id);
    }
}