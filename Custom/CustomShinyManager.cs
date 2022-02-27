namespace Satchel
{
    public class CustomShinyManager{
        public GameObject standPrefab,prefab; 
        public static readonly string languageKey = $"SATCHEL_SHINY_";
        private List<CustomShiny> shinies = new();
        private Dictionary<string,string> lang = new();
        public CustomShiny AddShiny(
            string ItemName,
            string sceneName,
            Vector3 position,
            bool isStand,
            bool isTrinket,
            Action Callback,
            Func<bool> ShouldSpawn,
            Sprite sprite = null){
                CustomShiny shiny = new CustomShiny(ItemName,sceneName,position,isStand,isTrinket,Callback,ShouldSpawn,sprite);
                shinies.Add(shiny);
                lang.Add($"{languageKey}_{shiny.ItemName}",shiny.ItemName);
                return shiny;
        }
        public CustomShinyManager(){
            UnityEngine.SceneManagement.SceneManager.sceneLoaded += SpawnOnSceneLoad;
            ModHooks.LanguageGetHook += LanguageGet;
        }

        public IEnumerator SpawnCoro(Scene scene){
            yield return null;
            foreach(var shiny in shinies){
                if(scene.name == shiny.sceneName && shiny.ShouldSpawn()){
                    shiny.Spawn(shiny.isStand ? standPrefab : prefab);
                }
            }
        }
        public void SpawnOnSceneLoad(Scene scene,LoadSceneMode mode)
        {
            GameManager.instance.StartCoroutine(SpawnCoro(scene));
        }
        public string LanguageGet( string key, string sheet, string orig){ 
            if(sheet == $"{languageKey}UI" && key.StartsWith(languageKey)){
                return lang[key];
            }
            return orig;
        }
    }
}