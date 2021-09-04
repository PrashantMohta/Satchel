using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using GlobalEnums;

using HutongGames.PlayMaker.Actions;
using Modding;
using static Modding.Logger;
namespace DandyCore{
    public class SceneUtils{

        public struct CustomSaveSlotParams {
            public string sceneName;
            public string sceneTitle;
            public Sprite background;
        }

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
        public struct BenchParams{

            public GameObject prefab;
            public string benchName;
            public Vector3 pos;
            public string sceneName;
        }

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
        public static UnityEngine.SceneManagement.Scene getCurrentScene(){
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        }

        public static void FixMaterials(){
            foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if(gameObj.name.StartsWith("tex.")){
                    gameObj.AddComponent<SpriteRendererMaterial>();
                }
                if(gameObj.name.StartsWith("mesh.")){
                    gameObj.AddComponent<ChangeMeshColor>();
                }
            }
        }

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
        //gate name determines some things
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
        
        public static GameObject CreateBenchFromPrefab(BenchParams bench){
            return CreateBenchFromPrefab(bench.prefab,bench.benchName,bench.pos,bench.sceneName);
        }

        //iTween retrieve args break
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

        public static tk2dTileMap FakeTileMapFromPrefab(GameObject TileMapPrefab){
            GameObject go = GameObject.Instantiate(TileMapPrefab);
            go.SetActive(false);
            tk2dTileMap tm = go.GetComponent<tk2dTileMap>();
            tm.renderData = new GameObject("dummydata");
            go.SetActive(true);
            return tm;
        }

        public static SceneManager getSceneManagerFromPrefab(GameObject SceneManagerPrefab){
            GameObject _sm = GameObject.Instantiate(SceneManagerPrefab);
            _sm.SetActive(false);
            SceneManager sm = _sm.GetComponent<SceneManager>();
            return sm;
        }

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