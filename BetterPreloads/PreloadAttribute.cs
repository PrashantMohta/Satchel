namespace Satchel.BetterPreloads{
    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]   
    public class Preload : Attribute{
        internal string scene;
        internal string objPath;
        public Preload(string scene, string objPath){
            this.scene = scene;
            this.objPath = objPath;
        }
    }
}