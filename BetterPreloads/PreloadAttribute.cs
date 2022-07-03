namespace Satchel.BetterPreloads{
    public class Preload : Attribute{
        internal string scene;
        internal string objPath;
        public Preload(string scene, string objPath){
            this.scene = scene;
            this.objPath = objPath;
        }
    }
}