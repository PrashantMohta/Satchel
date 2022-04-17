using static Modding.Logger;
using BenchParams = Satchel.SceneUtils.BenchParams;
using CustomSceneManagerSettings = Satchel.SceneUtils.CustomSceneManagerSettings;
using GatewayParams = Satchel.SceneUtils.GatewayParams;
//playerData.respawnScene
namespace Satchel
{

    public class CustomScene 
    {

        //todo create a nice setter for default vaues here
        public string sceneName = "unknown";
        public float width = 32;
        public float height = 32;

        public GameObject TileMap;
        public GameObject SceneManager;

        public SceneManager sceneManagerComponent;        

        public CustomSceneManagerSettings settings;

        public List<BenchParams> Benches = new List<BenchParams>();
        public List<GatewayParams> gatesToScene = new List<GatewayParams>();
        public List<GatewayParams> gatesFromScene = new List<GatewayParams>();
        public CustomScene()
        {
            On.GameManager.RefreshTilemapInfo += OnGameManagerRefreshTilemapInfo;
            On.GameManager.EnterHero += OnGameManagerEnterHero;
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnSceneChanged;

        }
        
        public void Config(float width, float height, CustomSceneManagerSettings settings){
            this.width = width;
            this.height = height;
            this.settings = settings;
        }

        public void AddGateway(GatewayParams gateway){
            if(gateway.fromScene == sceneName){
                gatesFromScene.Add(gateway);
            } else if(gateway.toScene == sceneName){
                gatesToScene.Add(gateway);
            } else {
                Log("Tried to add a Gateway that does not connect to this scene");
            }
        }
        public void AddBenchFromPrefab(GameObject prefab,string benchName, Vector3 pos){
            Benches.Add(new BenchParams{
                prefab = prefab,
                benchName = benchName,
                pos = pos,
                sceneName = sceneName
            });
        }

        private void OnGameManagerRefreshTilemapInfo(On.GameManager.orig_RefreshTilemapInfo orig, GameManager self, string targetScene)
        {
            orig(self, targetScene);
            if (targetScene == sceneName)
            {
                self.tilemap.width = (int)width;
                self.tilemap.height = (int)height;
                self.sceneWidth = width;
                self.sceneHeight = height;
                var map = UnityEngine.Object.FindObjectOfType<GameMap>();
                if(map != null){
                    map.SetManualTilemap(0, 0, width, height);
                }
            }
        }

        private void OnGameManagerEnterHero(On.GameManager.orig_EnterHero orig, GameManager self, bool additivegatesearch)
        {
            var currentScene = self.sceneName;
            foreach(GatewayParams gate in gatesToScene){
                if(currentScene == gate.fromScene){
                    SceneUtils.CreateGateway(gate);
                }
            }
            if(currentScene == sceneName){
                //set background music

                if(settings.backgroundMusic == null && settings.backgroundMusicGet != null){
                    settings.backgroundMusic = settings.backgroundMusicGet();
                }
                if(settings.backgroundMusic != null){
                    SceneUtils.PlayBackgroundMusicForScene(settings.backgroundMusic);
                }

            }
            orig(self, additivegatesearch);
        }

        private void OnSceneChanged(Scene from, Scene to)
        {
            var currentScene = to.name;
            if(currentScene == sceneName){
                foreach(GatewayParams gate in gatesFromScene){   
                    SceneUtils.CreateGateway(gate);
                }
                foreach(BenchParams bench in Benches){   
                    SceneUtils.CreateBenchFromPrefab(bench);
                }
            } else {
                var benchesInScene = GameObject.FindGameObjectsWithTag("RespawnPoint");
                foreach(var bench in benchesInScene){
                    var benchFsm = bench.LocateMyFSM("Bench Control");
                    if(benchFsm != null && benchFsm.FsmVariables.FindFsmString("Scene Name").Value == sceneName){
                        GameObject.Destroy(bench);
                    }
                }
            }
            if (currentScene == sceneName)
            {       
                var tm = SceneUtils.FakeTileMapFromPrefab(TileMap);
                var sm = SceneUtils.getSceneManagerFromPrefab(SceneManager);
                sm.gameObject.name = "_SceneManager";
                sm.sceneType = settings.sceneType;
                sm.mapZone = settings.mapZone;
                sm.darknessLevel = settings.darknessLevel;
                sm.saturation = settings.saturation;
                sm.ignorePlatformSaturationModifiers = settings.ignorePlatformSaturationModifiers;
                sm.isWindy = settings.isWindy;
                sm.isTremorZone = settings.isTremorZone;
                sm.environmentType = settings.environmentType;
                sm.noParticles = settings.noParticles;
                sm.overrideParticlesWith = settings.overrideParticlesWith;
                sm.defaultColor = settings.defaultColor;
                sm.defaultIntensity = settings.defaultIntensity;;
                sm.heroLightColor = settings.heroLightColor;
                sm.gameObject.SetActive(true);
            
                
            }
        }
    }
}