namespace Satchel
{
    /// <summary>
    /// The class that gives access to custom In-game UI and game elements
    /// </summary>
    public class Core{

        public static AssetBundle shaderBundle;
        public static Shader spriteFlash;
        public static AssetBundle spriteExtractBundle;
        public static Shader spriteExtract;
        public static Shader spriteMask;

        /// <summary>
        /// Method to load the shaders required for Certain satchel features, runs automatically when constructing a Core instance
        /// </summary>
        public static void LoadShaders(){
            switch (SystemInfo.operatingSystemFamily)
            {
                case OperatingSystemFamily.MacOSX:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("mac.shaders");
                    spriteExtractBundle = AssemblyUtils.GetAssetBundleFromResources("mac.spriteextract");
                    break;
                case OperatingSystemFamily.Linux:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("lin.shaders");
                    spriteExtractBundle = AssemblyUtils.GetAssetBundleFromResources("lin.spriteextract");
                    break;
                case OperatingSystemFamily.Windows:
                default:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("win.shaders");
                    spriteExtractBundle = AssemblyUtils.GetAssetBundleFromResources("win.spriteextract");
                    break;
            }
            if(spriteFlash == null){
                spriteFlash = shaderBundle.GetShader("spriteflash.shader");
            }
            if(spriteExtractBundle != null)
            {
                spriteExtract = spriteExtractBundle.GetShader("SpriteExtract");
                spriteMask = spriteExtractBundle.GetShader("SpriteMaskMaker");
            }
        }
        static Core(){
            LoadShaders();
        }

        public CustomSaveSlotsManager customSaveSlotsManager;

        /// <summary>
        /// Gets the instance of CustomSaveSlotManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomSaveSlotManager</returns>
        public CustomSaveSlotsManager GetCustomSaveSlotsManager(){
            if(customSaveSlotsManager == null){
                customSaveSlotsManager = new CustomSaveSlotsManager();
            }
            return customSaveSlotsManager;
        }
        public CustomDialogueManager customDialogueManager;

        /// <summary>
        /// Gets the instance of CustomDialogueManager or creates if null
        /// </summary>
        /// <param name="CardPrefab">A preload of Cornifer's Card</param>
        /// <returns>Instance of CustomDialogueManager</returns>
        public CustomDialogueManager GetCustomDialogueManager(GameObject CardPrefab){
            if(customDialogueManager == null){
                customDialogueManager = new CustomDialogueManager(CardPrefab);
            }
            return customDialogueManager;
        }

        public CustomMapManager customMapManager;
        /// <summary>
        /// Gets the instance of CustomMapManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomMapManager</returns>
        public CustomMapManager GetCustomMapManager(){
            if(customMapManager == null){
                customMapManager = new CustomMapManager();
            }
            return customMapManager;
        }

        public CustomEnemyManager customEnemyManager;
        /// <summary>
        /// Gets the instance of CustomEnemyManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomEnemyManager</returns>
        public CustomEnemyManager GetCustomEnemyManager(){
            if(customEnemyManager == null){
                customEnemyManager = new CustomEnemyManager();
            }
            return customEnemyManager;
        }
        public CustomDreamNailManager customDreamNailManager;
        /// <summary>
        /// Gets the instance of CustomDreamNailManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomDreamNailManager</returns>
        public CustomDreamNailManager GetCustomDreamNailManager(){
            if(customDreamNailManager == null){
                customDreamNailManager = new CustomDreamNailManager();
            }
            return customDreamNailManager;
        }

        
        public CustomShinyManager customShinyManager;

        /// <summary>
        /// Gets the instance of CustomShinyManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomShinyManager</returns>
        public CustomShinyManager GetCustomShinyManager(){
            if(customShinyManager == null){
                customShinyManager = new CustomShinyManager();
            }
            return customShinyManager;
        }

        public CustomBigItemGetManager customBigItemGetManager;
        /// <summary>
        /// Gets the instance of CustomBigItemGetManager or creates if null
        /// </summary>
        /// <returns>Instance of CustomBigItemGetManager</returns>
        public CustomBigItemGetManager GetCustomBigItemGetManager(){
            if(customBigItemGetManager == null){
                customBigItemGetManager = new CustomBigItemGetManager();
            }
            return customBigItemGetManager;
        }

        /// <summary>
        /// All custom scenes being managed by Satchel for this mod
        /// </summary>
        public Dictionary<string,CustomScene> customScenes = new Dictionary<string,CustomScene>();

        /// <summary>
        /// Get custom Scene by sceneName
        /// </summary>
        /// <param name="sceneName">Name of the scene</param>
        /// <returns>The customScene or null</returns>
        public CustomScene GetCustomScene(string sceneName){
            if(customScenes.TryGetValue(sceneName, out var customScene)){
                return customScene;
            }
            return null;
        }
        /// <summary>
        /// Gets or Creates a new CustomScene
        /// </summary>
        /// <param name="sceneName">Name of the scene</param>
        /// <param name="TileMap">A preload of a TileMap from an existing scene</param>
        /// <param name="SceneManager">A preload of a SceneManager from an existin scene</param>
        /// <returns>The customScene or null</returns>
        public CustomScene GetCustomScene(string sceneName,GameObject TileMap,GameObject SceneManager){
            if(!customScenes.TryGetValue(sceneName, out var customScene)){
                customScene = new CustomScene();
            }

            if(customScene != null){
                customScene.sceneName = sceneName;
                customScene.TileMap = TileMap;
                customScene.SceneManager = SceneManager;
            } else {
                Satchel.Instance.Log("Error Creating scene : " + sceneName + " probably a scene with the same name already exists");
            }
            return customScene;
        }
    }
}
