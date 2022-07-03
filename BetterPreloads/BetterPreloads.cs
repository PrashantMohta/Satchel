using System.Linq;
using System.Reflection;

namespace Satchel.BetterPreloads{
    public abstract class BetterPreloadsMod<T> : Mod where T : new(){
        public static T Preloads = new T();
        public override List<(string, string)> GetPreloadNames(){

            List<(string, string)> preloadNames = new();

            foreach (var prop in typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    preloadNames.Add((PreloadInfo.scene, PreloadInfo.objPath));
                }
            }
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
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
            foreach (var prop in typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    ReflectionHelper.SetField(Preloads,prop.Name,preloadedObjects[PreloadInfo.scene][PreloadInfo.objPath]);
                }
            }
            foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var PreloadInfo = prop.GetCustomAttribute<PreloadAttribute>();
                if(PreloadInfo != null){
                    ReflectionHelper.SetProperty(Preloads,prop.Name,preloadedObjects[PreloadInfo.scene][PreloadInfo.objPath]);
                }
            }
            Initialize();
        }
    }
}