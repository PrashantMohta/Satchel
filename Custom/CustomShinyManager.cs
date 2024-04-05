namespace Satchel
{
    /// <summary>
    /// Handles custom shinies
    /// </summary>
    public class CustomShinyManager
    {
        public GameObject standPrefab, prefab;
        public static readonly string languageKey = $"SATCHEL_SHINY_";
        private List<CustomShiny> shinies = new();
        private Dictionary<string, string> lang = new();

        /// <summary>
        /// Add a Shiny to the game
        /// </summary>
        /// <param name="ItemName">Name of the item</param>
        /// <param name="sceneName">Scene in which the item is loaded</param>
        /// <param name="position">Position of the item</param>
        /// <param name="isStand">if it is meant to be picked standing</param>
        /// <param name="isTrinket">if it is going to show trinket UI</param>
        /// <param name="Callback">Action for when it is picked up</param>
        /// <param name="ShouldSpawn">if the item should be spawned</param>
        /// <param name="sprite">sprite of the item for triket UI</param>
        /// <returns></returns>
        public CustomShiny AddShiny(
            string ItemName,
            string sceneName,
            Vector3 position,
            bool isStand,
            bool isTrinket,
            Action Callback,
            Func<bool> ShouldSpawn,
            Sprite sprite = null)
        {
            CustomShiny shiny = new CustomShiny(ItemName, sceneName, position, isStand, isTrinket, Callback, ShouldSpawn, sprite);
            shinies.Add(shiny);
            lang.Add($"{languageKey}_{shiny.ItemName}", shiny.ItemName);
            return shiny;
        }
        public CustomShinyManager()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += SpawnOnSceneLoad;
            ModHooks.LanguageGetHook += LanguageGet;
        }

        private IEnumerator SpawnCoro(Scene scene)
        {
            yield return null;
            foreach (var shiny in shinies)
            {
                if (scene.name == shiny.sceneName && shiny.ShouldSpawn())
                {
                    shiny.Spawn(shiny.isStand ? standPrefab : prefab);
                }
            }
        }

        private void SpawnOnSceneLoad(Scene oldScene, Scene newScene)
        {
            CoroutineHelper.GetRunner().StartCoroutine(SpawnCoro(newScene));
        }
        private string LanguageGet(string key, string sheet, string orig)
        {
            if (sheet == $"{languageKey}UI" && key.StartsWith(languageKey))
            {
                return lang[key];
            }
            return orig;
        }
    }
}