using UnityEngine.Audio;
namespace Satchel
{
    /// <summary>
    /// Utilities to work with scenes
    /// </summary>
    public static class SceneUtils{

        internal static GameObject DontDestroyOnLoadObj;
        /// <summary>
        /// Get access to DontDestroyOnLoad scene
        /// </summary>
        /// <returns>DontDestroyOnLoad scene</returns>
        public static Scene GetDontDestroyOnLoadScene(){
            if(DontDestroyOnLoadObj == null){
                DontDestroyOnLoadObj = new GameObject();
                GameObject.DontDestroyOnLoad(DontDestroyOnLoadObj);
            }
            return DontDestroyOnLoadObj.scene;
        }
        /// <summary>
        /// Parameters for creating a CustomSaveSlot
        /// </summary>
        public struct CustomSaveSlotParams {
            public string sceneName;
            public string sceneTitle;
            public Sprite background;
        }
        /// <summary>
        /// Settings for SceneManager used by CustomScene
        /// </summary>
        public class CustomSceneManagerSettings{
            public SceneType sceneType;
            public MapZone mapZone;
            public int darknessLevel;
            public float saturation;
            public bool ignorePlatformSaturationModifiers;
            public bool isWindy;
            public bool isTremorZone;
            public int environmentType;
            public bool noParticles;
            public MapZone overrideParticlesWith;
            public Color defaultColor;
            public float defaultIntensity;
            public Color heroLightColor;
            public UnityEngine.AudioClip backgroundMusic;
            public Func<UnityEngine.AudioClip> backgroundMusicGet;

            public CustomSceneManagerSettings(SceneManager prefab){
                sceneType = prefab.sceneType;
                mapZone = prefab.mapZone;
                darknessLevel = prefab.darknessLevel;
                saturation = prefab.saturation;
                ignorePlatformSaturationModifiers = prefab.ignorePlatformSaturationModifiers;
                isWindy = prefab.isWindy;
                isTremorZone = prefab.isTremorZone;
                environmentType = prefab.environmentType;
                noParticles = prefab.noParticles;
                overrideParticlesWith = prefab.overrideParticlesWith;
                defaultColor = prefab.defaultColor;
                defaultIntensity = prefab.defaultIntensity;
                heroLightColor = prefab.heroLightColor;
            }
        }
        
        /// <summary>
        /// Parameters for creating a CustomBench in a CustomScene
        /// </summary>
        public struct BenchParams{

            public GameObject prefab;
            public string benchName;
            public Vector3 pos;
            public string sceneName;
        }
        /// <summary>
        /// Parameters for creatng custom gateways between scenes
        /// </summary>
        public struct GatewayParams{
            public string gateName;
            public Vector2 pos;
            public Vector2 size;
            public string fromScene;
            public string toScene;
            public string entryGate;
            public Vector2 respawnPoint;
            public bool onlyOut;
            public GameManager.SceneLoadVisualizations vis;
        }
        /// <summary>
        /// Gets the current scene
        /// </summary>
        /// <returns>current scene</returns>
        public static UnityEngine.SceneManagement.Scene getCurrentScene(){
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        }
        /// <summary>
        /// Gets all the loaded scenes
        /// </summary>
        /// <param name="includeDontDestroyScene">boolean indicating if DontDestroyOnLoadScene should be included</param>
        /// <returns>The loaded scenes</returns>
        public static List<UnityEngine.SceneManagement.Scene> GetAllLoadedScenes(bool includeDontDestroyScene = false){
            List<UnityEngine.SceneManagement.Scene> scenes = new();
        
            for (int n = 0; n < UnityEngine.SceneManagement.SceneManager.sceneCount; ++n)
            {
                Scene scene = UnityEngine.SceneManagement.SceneManager.GetSceneAt(n);
                scenes.Add(scene);
            }
            if(includeDontDestroyScene){
                scenes.Add(GetDontDestroyOnLoadScene());
            }
            return scenes;
        }

        /// <summary>
        /// Creat a Gateway using GatewayParams
        /// </summary>
        /// <param name="gateway">parameters for this gate</param>
        public static void CreateGateway(GatewayParams gateway){
            CreateGateway(
                gateway.gateName,
                gateway.pos,
                gateway.size,
                gateway.toScene,
                gateway.entryGate,
                gateway.respawnPoint,
                gateway.onlyOut,
                gateway.vis
            );
        }
        /// <summary>
        /// Creat a Gateway
        /// </summary>
        /// <param name="gateName">Name of the gate (if name contains left or right, alwaysEnterLeft or alwaysEnterRight is automatically set)</param>
        /// <param name="pos">Position of the gate</param>
        /// <param name="size">Size of the gate</param>
        /// <param name="toScene">Scene to transition to</param>
        /// <param name="entryGate">Name of the gate that can transition to this one</param>
        /// <param name="respawnPoint">Relative position of the respawn point</param>
        /// <param name="onlyOut">Boolean indicating if this gate can only be used as an entrance to current scene</param>
        /// <param name="vis">The type of loading visualisation to use</param>
        public static void CreateGateway(
            string gateName, 
            Vector2 pos, 
            Vector2 size, 
            string toScene,
            string entryGate,
            Vector2 respawnPoint,
            bool onlyOut, 
            GameManager.SceneLoadVisualizations vis)
        {
            if(GameObject.Find(gateName) != null) { return; }
            GameObject gate = new GameObject(gateName);
            gate.transform.SetPosition2D(pos);
            var tp = gate.AddComponent<TransitionPoint>();
            if (!onlyOut)
            {
                var bc = gate.AddComponent<BoxCollider2D>();
                bc.size = size;
                bc.isTrigger = true;
                tp.SetTargetScene(toScene);
                tp.entryPoint = entryGate;
            }
            tp.alwaysEnterLeft = gateName.Contains("left");
            tp.alwaysEnterRight = gateName.Contains("right");

            GameObject rm = new GameObject("Hazard Respawn Marker");
            rm.transform.parent = gate.transform;
            rm.transform.SetPosition2D(pos.x + respawnPoint.x, pos.y + respawnPoint.y);
            var tmp = rm.AddComponent<HazardRespawnMarker>();
            tmp.respawnFacingRight = tp.alwaysEnterRight;
            tp.respawnMarker = rm.GetComponent<HazardRespawnMarker>();
            tp.sceneLoadVisualization = vis;
            
        }
        
        /// <summary>
        /// Create a bench using BenchParams
        /// </summary>
        /// <param name="bench">Parameters for this bench</param>
        /// <returns>The Bench GameObject</returns>
        public static GameObject CreateBenchFromPrefab(BenchParams bench){
            return CreateBenchFromPrefab(bench.prefab,bench.benchName,bench.pos,bench.sceneName);
        }

        //iTween retrieve args break
        /// <summary>
        /// Create a bench from the supplied bench prefab
        /// </summary>
        /// <param name="benchPrefab">A Preload of a bench from the game</param>
        /// <param name="benchName">Name of the new bench</param>
        /// <param name="pos">Position of the new bench</param>
        /// <param name="sceneName">Scene in which the bench is placed (used for saves)</param>
        /// <returns>The Bench GameObject</returns>
        public static GameObject CreateBenchFromPrefab(GameObject benchPrefab,string benchName, Vector3 pos, string sceneName)
        {
            if(GameObject.Find(benchName) != null) { 
                return null; 
            }
            /*GameObject marker = new GameObject();
            marker.transform.position = new Vector3(pos.x, pos.y, 7.4f);
            marker.tag = "RespawnPoint";
            marker.name = benchName;
            marker.SetActive(true);
            GameObject.DontDestroyOnLoad(marker);*/

            GameObject bench = GameObject.Instantiate(benchPrefab);
            bench.transform.position = pos;
            bench.name = benchName;
            var benchFsm = bench.LocateMyFSM("Bench Control");
            benchFsm.FsmVariables.FindFsmString("Scene Name").Value = sceneName;
            benchFsm.FsmVariables.FindFsmString("Spawn Name").Value = bench.name;
            bench.SetActive(true);
            GameObject.DontDestroyOnLoad(bench);
            return bench;
        }

        /// <summary>
        /// Create a Fake TileMap from prefab
        /// </summary>
        /// <param name="TileMapPrefab">A Preload of the tilemap of any existing scene</param>
        /// <returns>A tk2dTileMap with dummy data</returns>
        public static tk2dTileMap FakeTileMapFromPrefab(GameObject TileMapPrefab){
            GameObject go = GameObject.Instantiate(TileMapPrefab);
            go.SetActive(false);
            tk2dTileMap tm = go.GetComponent<tk2dTileMap>();
            tm.renderData = new GameObject("dummydata");
            go.SetActive(true);
            return tm;
        }
        /// <summary>
        /// get a SceneManager component from SceneManager GameObject Prefab
        /// </summary>
        /// <param name="SceneManagerPrefab">A preload of a SceneManager GameObject</param>
        /// <returns>A shallow copy of SceneManager component</returns>
        public static SceneManager getSceneManagerFromPrefab(GameObject SceneManagerPrefab){
            GameObject _sm = GameObject.Instantiate(SceneManagerPrefab);
            _sm.SetActive(false);
            SceneManager sm = _sm.GetComponent<SceneManager>();
            return sm;
        }

        /// <summary>
        /// Play an AudioClip as the background music
        /// </summary>
        /// <param name="clip">The AudioClip to play</param>
        public static void PlayBackgroundMusicForScene(AudioClip clip)
        {   
            MusicCue musicCue = ScriptableObject.CreateInstance<MusicCue>();
            List<MusicCue.MusicChannelInfo> channelInfos = new List<MusicCue.MusicChannelInfo>();
            MusicCue.MusicChannelInfo channelInfo = new MusicCue.MusicChannelInfo();

            ReflectionHelper.SetField(channelInfo,"clip", clip);
            channelInfos.Add(channelInfo);
            channelInfos.Add(null);
            channelInfos.Add(null);
            channelInfos.Add(null);
            channelInfos.Add(null);
            channelInfos.Add(null);
            ReflectionHelper.SetField(musicCue,"channelInfos", channelInfos.ToArray());
            var objs = Resources.FindObjectsOfTypeAll<AudioMixer>();
            foreach(var x in objs){
                if(x.name == "Music"){
                    var yoursnapshot = x.FindSnapshot("Main Only");
                    yoursnapshot.TransitionTo(1f);
                    GameManager.instance.AudioManager.ApplyMusicCue(musicCue, 0, 0, false);
                    return;
                }
            }
        }
    }
}