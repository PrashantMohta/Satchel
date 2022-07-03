using System.Linq;
using System.Reflection;

namespace Satchel.BetterPreloads{
    public abstract class BetterPreloadsMod<T> : Mod where T : new(){
        public static T Preloads = new T();
        private List<FieldInfo> fi;
        private List<PropertyInfo> pi;
        public override List<(string, string)> GetPreloadNames(){

            List<(string, string)> preloadNames = new();

            fi = new List<FieldInfo>(typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance));
            pi = new List<PropertyInfo>(typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance));

            foreach (var prop in fi)
            {
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    preloadNames.Add((PreloadInfo.scene, PreloadInfo.objPath));
                }
            }
            foreach (var prop in pi) {
                if(!prop.CanWrite) continue;
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    preloadNames.Add((PreloadInfo.scene, PreloadInfo.objPath));
                }
            }
            return preloadNames;
        }

        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects){
            if(preloadedObjects == null){
                return;
            }
            foreach (var prop in fi)
            {
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    ReflectionHelper.SetField(Preloads,prop.Name,preloadedObjects[PreloadInfo.scene][PreloadInfo.objPath]);
                }
            }
            foreach (var prop in pi) {
                if(!prop.CanWrite) continue;
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    ReflectionHelper.SetProperty(Preloads,prop.Name,preloadedObjects[PreloadInfo.scene][PreloadInfo.objPath]);
                }
            }
            fi.Clear();
            pi.Clear();
            Initialize();
        }
    }
}