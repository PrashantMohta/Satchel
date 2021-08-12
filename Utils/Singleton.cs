
using UnityEngine;
using UnityEngine.SceneManagement;
using GlobalEnums;

using Modding;
namespace DandyCore{

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

    } 
}