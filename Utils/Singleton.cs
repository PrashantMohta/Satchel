
using UnityEngine;
using UnityEngine.SceneManagement;
using GlobalEnums;

using Modding;
namespace DandyCore{

    // todo refactor this to not be a static class and manage Gos Internally
    public static class Singles {
        public static string version =  AssemblyUtils.Version();
        public static CustomSaveSlotsManager GetCustomSaveSlotsManager(){
            GameObject go = GameObject.Find($"CustomSaveSlotsManager - {version}");
            if(go == null){
                go = new GameObject($"CustomSaveSlotsManager - {version}");
                GameObject.DontDestroyOnLoad(go);
            }
            CustomSaveSlotsManager component = go.GetComponent<CustomSaveSlotsManager>();
            if(component == null){
                component = go.AddComponent<CustomSaveSlotsManager>();
            }
            return component;
        }

        public static CustomMapManager GetCustomMapManager(){
            GameObject go = GameObject.Find($"CustomMapManager  - {version}");
            if(go == null){
                go = new GameObject($"CustomMapManager  - {version}");
                GameObject.DontDestroyOnLoad(go);
            }
            CustomMapManager component = go.GetComponent<CustomMapManager>();
            if(component == null){
                component = go.AddComponent<CustomMapManager>();
            }
            return component;
        }

        public static CustomEnemyManager GetCustomEnemyManager(){
            GameObject go = GameObject.Find($"CustomEnemyManager  - {version}");
            if(go == null){
                go = new GameObject($"CustomEnemyManager  - {version}");
                GameObject.DontDestroyOnLoad(go);
            }
            CustomEnemyManager component = go.GetComponent<CustomEnemyManager>();
            if(component == null){
                component = go.AddComponent<CustomEnemyManager>();
            }
            return component;
        }

        public static CustomDreamNailManager GetCustomDreamNailManager(){
            GameObject go = GameObject.Find($"CustomDreamNailManager  - {version}");
            if(go == null){
                go = new GameObject($"CustomDreamNailManager  - {version}");
                GameObject.DontDestroyOnLoad(go);
            }
            CustomDreamNailManager component = go.GetComponent<CustomDreamNailManager>();
            if(component == null){
                component = go.AddComponent<CustomDreamNailManager>();
            }
            return component;
        }

    } 
}