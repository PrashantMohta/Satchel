using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using UnityEngine;
using static Modding.Logger;

namespace Satchel{
    public class Core{

        public static AssetBundle shaderBundle;
        public static Shader spriteFlash;

        public void LoadShaders(){
            switch (SystemInfo.operatingSystemFamily)
            {
                case OperatingSystemFamily.MacOSX:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("mac.shaders");
                    break;
                case OperatingSystemFamily.Linux:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("lin.shaders");
                    break;
                case OperatingSystemFamily.Windows:
                default:
                    shaderBundle = AssemblyUtils.GetAssetBundleFromResources("win.shaders");
                    break;
            }
            if(spriteFlash == null){
                spriteFlash = shaderBundle.GetShader("spriteflash.shader");
            }

        }
        public Core(){
            Log(AssemblyUtils.Version());
            LoadShaders();
        }

        
        public CustomSaveSlotsManager customSaveSlotsManager;
        public CustomSaveSlotsManager GetCustomSaveSlotsManager(){
            if(customSaveSlotsManager == null){
                customSaveSlotsManager = new CustomSaveSlotsManager();
            }
            return customSaveSlotsManager;
        }

        public CustomDialogueManager customDialogueManager;
        public CustomDialogueManager GetCustomDialogueManager(GameObject CardPrefab){
            if(customDialogueManager == null){
                customDialogueManager = new CustomDialogueManager(CardPrefab);
            }
            return customDialogueManager;
        }

        public CustomMapManager customMapManager;
        public CustomMapManager GetCustomMapManager(){
            if(customMapManager == null){
                customMapManager = new CustomMapManager();
            }
            return customMapManager;
        }

        public CustomEnemyManager customEnemyManager;
        public CustomEnemyManager GetCustomEnemyManager(){
            if(customEnemyManager == null){
                customEnemyManager = new CustomEnemyManager();
            }
            return customEnemyManager;
        }
        public CustomDreamNailManager customDreamNailManager;
        public CustomDreamNailManager GetCustomDreamNailManager(){
            if(customDreamNailManager == null){
                customDreamNailManager = new CustomDreamNailManager();
            }
            return customDreamNailManager;
        }

        
        public CustomShinyManager customShinyManager;
        public CustomShinyManager GetCustomShinyManager(){
            if(customShinyManager == null){
                customShinyManager = new CustomShinyManager();
            }
            return customShinyManager;
        }

        public CustomBigItemGetManager customBigItemGetManager;
        public CustomBigItemGetManager GetCustomBigItemGetManager(){
            if(customBigItemGetManager == null){
                customBigItemGetManager = new CustomBigItemGetManager();
            }
            return customBigItemGetManager;
        }


        public Dictionary<string,CustomScene> customScenes = new Dictionary<string,CustomScene>();
        public CustomScene GetCustomScene(string sceneName){
            if(customScenes.TryGetValue(sceneName, out var customScene)){
                return customScene;
            }
            return null;
        }
        public CustomScene GetCustomScene(string sceneName,GameObject TileMap,GameObject SceneManager){
            if(!customScenes.TryGetValue(sceneName, out var customScene)){
                customScene = new CustomScene();
            }

            if(customScene != null){
                customScene.sceneName = sceneName;
                customScene.TileMap = TileMap;
                customScene.SceneManager = SceneManager;
            } else {
                Log("Error Creating scene : " + sceneName + " probably a scene with the same name already exists");
            }
            return customScene;
        }
    }
}