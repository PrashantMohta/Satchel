using UnityEngine;
using UnityEngine.UI;

using System;
using System.Collections;
using System.Collections.Generic;
using Modding;
using TMPro;

using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

using static DandyCore.SceneUtils;
using static Modding.Logger;

namespace DandyCore{
    public class customMap{
        public string sceneName;
        public string sceneTitle;
        public Func<bool> hasMap;
        public GameObject areaCustomMap;
        public Vector2 position;
        public Vector2 titleOffset;
        public Func<Sprite> GetSprite;
    }
    public class CustomMapManager : MonoBehaviour
    {
        private Dictionary<string,customMap> Maps = new Dictionary<string,customMap>();
        private List<string> MapAreas = new List<string>{"mapCrossroads", "mapGreenpath", "mapFogCanyon", "mapRoyalGardens", "mapFungalWastes", "mapCity", "mapWaterways", "mapMines", "mapDeepnest", "mapCliffs", "mapOutskirts", "mapRestingGrounds", "mapAbyss"};

        private GameMap gameMapComponent;

        private GameObject AreaNameTxt;

        public void Start(){
                On.GameManager.SetGameMap += OnGameManagerSetGameMap;
                On.GameMap.WorldMap += NewWorldMap;
                On.GameMap.CloseQuickMap += NewCloseQuickMap;
                On.GameMap.PositionCompass += NewPositionCompass;
                On.HutongGames.PlayMaker.Actions.PlayerDataBoolTest.OnEnter += HandlePlayerDataBoolTest;
                ModHooks.Instance.LanguageGetHook += LanguageGet;
        }
        
        public void Add(customMap map){
            Maps.Add(map.sceneName,map);
            GameManager.instance.StartCoroutine(generateCustomMap(map));
        }

        public void Remove(string sceneName){
            Maps.TryGetValue(sceneName,out var oldCustomMap);
            GameObject.Destroy(oldCustomMap.areaCustomMap);
            Maps.Remove(sceneName);
        }

        public GameObject GetAreaNameTxt(){
            if(AreaNameTxt== null){
                var quickMapGameObject = GameObject.Find("Quick Map");
                var quickMapFsm = quickMapGameObject.LocateMyFSM("Quick Map");
                var quickMapFsmVars = quickMapFsm.FsmVariables;
                AreaNameTxt = quickMapFsm.GetAction<SetTextMeshProText>("Cliffs", 2).gameObject.GameObject.Value;
            }
            return AreaNameTxt;
        }

        public IEnumerator generateCustomMap(customMap map){
            yield return new WaitWhile(()=> gameMapComponent == null);
            var areaNamePrefab = GameObject.Instantiate(gameMapComponent.areaCliffs.transform.GetChild(0).gameObject);
            areaNamePrefab.SetActive(false);
            var roomMat = UnityEngine.Object.Instantiate(gameMapComponent.areaCliffs.transform.GetChild(1).GetComponent<SpriteRenderer>().material);
            var tmpChildZ = gameMapComponent.areaCliffs.transform.GetChild(6).localPosition.z;

            if(map.areaCustomMap == null){
                map.areaCustomMap = GameObject.Instantiate(gameMapComponent.areaCliffs, gameMapComponent.transform);
            }
            map.areaCustomMap.SetActive(true);

            for (int i = 0; i < map.areaCustomMap.transform.childCount; i++)
            {
                GameObject.Destroy(map.areaCustomMap.transform.GetChild(i).gameObject);
            }

            map.areaCustomMap.name = "dc_custom_map_" + map.sceneName;
            map.areaCustomMap.layer = 5;
            map.areaCustomMap.transform.localScale = Vector3.one;
            var pls = map.areaCustomMap.transform.parent.localScale;
            map.areaCustomMap.transform.localPosition = new Vector3(map.position.x, map.position.y , gameMapComponent.areaCliffs.transform.localPosition.z);

            if (map.areaCustomMap != null){
                var mapSceneObj = new GameObject(map.sceneName);
                mapSceneObj.transform.SetParent(map.areaCustomMap.transform);
                mapSceneObj.name = map.sceneName;

                mapSceneObj.transform.localPosition = new Vector3(0,0,tmpChildZ);
                mapSceneObj.layer = 5;
                mapSceneObj.transform.localScale = Vector3.one;
                var sr = mapSceneObj.AddComponent<SpriteRenderer>();
                sr.material = roomMat;
                sr.sprite = map.GetSprite();
                sr.sortingLayerID = 629535577;
                sr.sortingOrder = 0;

                var areaCustomName = GameObject.Instantiate(areaNamePrefab, map.areaCustomMap.transform);
                areaCustomName.transform.position = new Vector3(0,0,0);
                areaCustomName.transform.localPosition = new Vector3(5f + map.titleOffset.x, -0.5f + map.titleOffset.y, areaCustomName.transform.localPosition.z - 0.002f);
                areaCustomName.GetComponent<SetTextMeshProGameText>().convName = "dc_custom_map_" + map.sceneName;
                areaCustomName.SetActive(true);
            }
            map.areaCustomMap.SetActive(false);
            GameObject.DontDestroyOnLoad(map.areaCustomMap);
        }
        
        protected void EditQuickMapFsm(GameObject gameMapGameObject)
        {
            
            var quickMapGameObject = GameObject.Find("Quick Map");
            var quickMapFsm = quickMapGameObject.LocateMyFSM("Quick Map");

            var quickMapFsmVars = quickMapFsm.FsmVariables;

            var fsmAAAction = new ActionAction<ActionArg>();
            fsmAAAction.arg = new ActionArg()
            {
                go = gameMapGameObject,
                fsmString = quickMapFsmVars.FindFsmString("Map Zone")
            };
            fsmAAAction.action = CheckOpenCustomQuickMap;

            quickMapFsm.InsertAction("Crossroads", fsmAAAction, 7);
            quickMapFsm.InsertAction("Dirtmouth", fsmAAAction, 5);
            quickMapFsm.InsertAction("Greenpath", fsmAAAction, 6);
            quickMapFsm.InsertAction("Cliffs", fsmAAAction, 6);
            quickMapFsm.InsertAction("Fungal Wastes", fsmAAAction, 6);
            quickMapFsm.InsertAction("City", fsmAAAction, 6);
            quickMapFsm.InsertAction("Mines", fsmAAAction, 6);
            quickMapFsm.InsertAction("Resting Grounds", fsmAAAction, 6);
            quickMapFsm.InsertAction("Fog Canyon", fsmAAAction, 6);
            quickMapFsm.InsertAction("Royal Gardens", fsmAAAction, 6);
            quickMapFsm.InsertAction("Deepnest", fsmAAAction, 6);
            quickMapFsm.InsertAction("Waterways", fsmAAAction, 6);
            quickMapFsm.InsertAction("Abyss", fsmAAAction, 6);
            quickMapFsm.InsertAction("Outskirts", fsmAAAction, 7);


        }       
        public void OpenCustomMap(GameMap gm){
            var currentSceneName = SceneUtils.getCurrentScene().name;
            if(Maps.TryGetValue(currentSceneName,out var currentScene)){
                gm.areaGreenpath.SetActive(false);
                gm.areaAncientBasin.SetActive(false);
                gm.areaCity.SetActive(false);
                gm.areaCliffs.SetActive(false);
                gm.areaCrossroads.SetActive(false);
                gm.areaCrystalPeak.SetActive(false);
                gm.areaDeepnest.SetActive(false);
                gm.areaFogCanyon.SetActive(false);
                gm.areaFungalWastes.SetActive(false);
                gm.areaGreenpath.SetActive(false);
                gm.areaKingdomsEdge.SetActive(false);
                gm.areaQueensGardens.SetActive(false);
                gm.areaRestingGrounds.SetActive(false);
                gm.areaDirtmouth.SetActive(false);
                gm.areaWaterways.SetActive(false);

                foreach(var kvp in Maps){
                    kvp.Value.areaCustomMap.SetActive(kvp.Key == currentSceneName);
                }
                var areaTxt = GetAreaNameTxt();
                areaTxt.GetComponent<TextMeshPro>().text = currentScene.sceneTitle;
                MoveMapTo(gm,new Vector2(currentScene.position.x*(-1.5365f), currentScene.position.y*(-1.5365f)));//*4
            }
        }
        public void MoveMapTo(GameMap gm, Vector2 point){
            gm.gameObject.transform.localPosition = new Vector3(point.x,point.y,18);
        }
        public void CheckOpenCustomQuickMap(ActionArg arg)
        {
            OpenCustomMap(arg.go.GetComponent<GameMap>());   
        }

        public string LanguageGet( string key, string sheet){
            string orig = Language.Language.GetInternal(key, sheet);
            if(key.StartsWith("dc_custom_map_")){
                var sceneName = key.Replace("dc_custom_map_","");
                if(Maps.TryGetValue(sceneName, out var map)){
                    return map.sceneTitle != "" ? map.sceneTitle : map.sceneName;
                }
            }
            return orig;
        }
        public void HandlePlayerDataBoolTest(On.HutongGames.PlayMaker.Actions.PlayerDataBoolTest.orig_OnEnter orig, HutongGames.PlayMaker.Actions.PlayerDataBoolTest self){
            if(MapAreas.Contains(self.boolName.Value) && Maps.TryGetValue(SceneUtils.getCurrentScene().name,out var currentMap)){
                if(currentMap.hasMap())
                {
                    ((FsmStateAction)self).Fsm.Event(self.isTrue);
                } else {
                    ((FsmStateAction)self).Fsm.Event(self.isFalse);
                }
            } else {
                orig(self);
            }
        }
        public void OnGameManagerSetGameMap(On.GameManager.orig_SetGameMap orig, GameManager self, GameObject gameMapGo)
        {   
            //update FSM here
            GameObject.DontDestroyOnLoad(gameMapGo);
            gameMapComponent = gameMapGo.GetComponent<GameMap>();
            EditQuickMapFsm(gameMapGo); 
            orig(self, gameMapGo);
        }

        protected void NewWorldMap(On.GameMap.orig_WorldMap orig, GameMap self)
    {
        orig(self);

        self.panMinX = float.MinValue;
        self.panMaxX = float.MaxValue;
        self.panMinY = float.MinValue;
        self.panMaxY = float.MaxValue;

        var pd = PlayerData.instance;
        if (pd.GetBool("equippedCharm_2")){
            foreach(var kvp in Maps){
                kvp.Value.areaCustomMap.SetActive(kvp.Value.hasMap());
            }
        }
              
    }
    
        protected void NewCloseQuickMap(On.GameMap.orig_CloseQuickMap orig, GameMap self)
        {
            orig(self);
            foreach(var kvp in Maps){
                kvp.Value.areaCustomMap.SetActive(false);
            }
        }

         protected void NewPositionCompass(On.GameMap.orig_PositionCompass orig, GameMap self, bool posShade)
        {
            GameObject gameObject = null;
            var currentMapZone = ReflectionHelper.GetAttr<GameMap, GameManager>(self, "gm").GetCurrentMapZone();

            string sceneName;
            if (!self.inRoom)
            {
                sceneName = ReflectionHelper.GetAttr<GameMap, GameManager>(self, "gm").sceneName;
            }
            else
            {
                currentMapZone = self.doorMapZone;
                sceneName = self.doorScene;
            }

            if (currentMapZone == "ABYSS")
            {
                gameObject = self.areaAncientBasin;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "CITY" || currentMapZone == "KINGS_STATION" || currentMapZone == "SOUL_SOCIETY" || currentMapZone == "LURIENS_TOWER")
            {
                gameObject = self.areaCity;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "CLIFFS")
            {
                gameObject = self.areaCliffs;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "CROSSROADS" || currentMapZone == "SHAMAN_TEMPLE")
            {
                gameObject = self.areaCrossroads;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "MINES")
            {
                gameObject = self.areaCrystalPeak;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "DEEPNEST" || currentMapZone == "BEASTS_DEN")
            {
                gameObject = self.areaDeepnest;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "FOG_CANYON" || currentMapZone == "MONOMON_ARCHIVE")
            {
                gameObject = self.areaFogCanyon;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "WASTES" || currentMapZone == "QUEENS_STATION")
            {
                gameObject = self.areaFungalWastes;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "GREEN_PATH")
            {
                gameObject = self.areaGreenpath;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "OUTSKIRTS" || currentMapZone == "HIVE" || currentMapZone == "COLOSSEUM")
            {
                gameObject = self.areaKingdomsEdge;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "ROYAL_GARDENS")
            {
                gameObject = self.areaQueensGardens;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "RESTING_GROUNDS")
            {
                gameObject = self.areaRestingGrounds;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "TOWN" || currentMapZone == "KINGS_PASS")
            {
                gameObject = self.areaDirtmouth;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }
            else if (currentMapZone == "WATERWAYS" || currentMapZone == "GODSEEKER_WASTE")
            {
                gameObject = self.areaWaterways;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
            }

            self.gameObject.transform.localPosition = new Vector3(0, 0, 0); // test

            if (Maps.TryGetValue(sceneName, out var map))
            {
                //this is custom scene
                gameObject = map.areaCustomMap;
                self.currentScene = gameObject.FindGameObjectInChildren(sceneName);
                self.currentScene.SetActive(true);
            }

            if (self.currentScene != null)
            {
                self.currentScenePos =
                    new Vector3(self.currentScene.transform.localPosition.x + gameObject.transform.localPosition.x,
                        self.currentScene.transform.localPosition.y + gameObject.transform.localPosition.y, 0f);

                if (!posShade && !ReflectionHelper.GetAttr<GameMap, bool>(self, "posGate"))
                {
                    if (ReflectionHelper.GetAttr<GameMap, PlayerData>(self, "pd").GetBool("equippedCharm_2"))
                    {
                        ReflectionHelper.SetAttr(self, "displayingCompass", true);
                        self.compassIcon.SetActive(true);
                    }
                    else
                    {
                        ReflectionHelper.SetAttr(self, "displayingCompass", false);
                        self.compassIcon.SetActive(false);
                    }
                }

                if (posShade)
                {
                    if (!self.inRoom)
                    {
                        self.shadeMarker.transform.localPosition =
                            new Vector3(self.currentScenePos.x, self.currentScenePos.y, 0f);
                    }
                    else
                    {
                        var x = self.currentScenePos.x -
                                self.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.x / 100f / 2f +
                                (self.doorX + self.doorOriginOffsetX) / self.doorSceneWidth *
                                (self.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.x / 100f *
                                 self.transform.localScale.x) / self.transform.localScale.x;
                        var y = self.currentScenePos.y -
                                self.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.y / 100f / 2f +
                                (self.doorY + self.doorOriginOffsetY) / self.doorSceneHeight *
                                (self.currentScene.GetComponent<SpriteRenderer>().sprite.rect.size.y / 100f *
                                 self.transform.localScale.y) / self.transform.localScale.y;
                        self.shadeMarker.transform.localPosition = new Vector3(x, y, 0f);
                    }

                    ReflectionHelper.GetAttr<GameMap, PlayerData>(self, "pd").SetVector3("shadeMapPos",
                        new Vector3(self.currentScenePos.x, self.currentScenePos.y, 0f));
                }

                if (ReflectionHelper.GetAttr<GameMap, bool>(self, "posGate"))
                {
                    self.dreamGateMarker.transform.localPosition =
                        new Vector3(self.currentScenePos.x, self.currentScenePos.y, 0f);
                    ReflectionHelper.GetAttr<GameMap, PlayerData>(self, "pd").SetVector3("dreamgateMapPos",
                        new Vector3(self.currentScenePos.x, self.currentScenePos.y, 0f));
                }
            }
            else
            {
                Debug.Log("Couldn't find current scene object!");
                if (posShade)
                {
                    ReflectionHelper.GetAttr<GameMap, PlayerData>(self, "pd")
                        .SetVector3("shadeMapPos", new Vector3(-10000f, -10000f, 0f));
                    self.shadeMarker.transform.localPosition = ReflectionHelper.GetAttr<GameMap, PlayerData>(self, "pd")
                        .GetVector3("shadeMapPos");
                }
            }
        }
    
    }
}