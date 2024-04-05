namespace Satchel.BetterPreloads
{

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class PreloadAttribute : Attribute
    {
        public string scene { get; protected set; }
        public string objPath { get; protected set; }
        public PreloadAttribute(string scene, string objPath)
        {
            this.scene = scene;
            this.objPath = objPath;
        }
    }
}