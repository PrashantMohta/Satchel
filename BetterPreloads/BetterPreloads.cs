using System.Linq;
using System.Reflection;

namespace Satchel.BetterPreloads{
    public abstract class BetterPreloadsMod<T> : Mod where T : new(){
        public static T Preloads = new T();
        public override List<(string, string)> GetPreloadNames(){

            List<(string, string)> preloadNames = new List<(string, string)> ();

            foreach (FieldInfo prop in typeof(T).GetFields())
            {
                var PreloadInfo = prop.GetCustomAttributes().FirstOrDefault(x => x.GetType() == typeof(Preload)) as Preload;
                if(PreloadInfo != null){
                    preloadNames.Add((PreloadInfo.scene, PreloadInfo.objPath));
                }

            }
            
            return preloadNames;
        }

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects){
            foreach (FieldInfo prop in typeof(T).GetFields())
            {
                
                var PreloadInfo = prop.GetCustomAttributes().FirstOrDefault(x => x.GetType() == typeof(Preload))  as Preload;
                ReflectionHelper.SetField(Preloads,prop.Name,preloadedObjects[PreloadInfo.scene][PreloadInfo.objPath]);
            }
        }
    }
}