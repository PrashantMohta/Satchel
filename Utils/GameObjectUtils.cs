using System;
using UnityEngine;
using static Modding.Logger;
namespace DandyCore {
    public static class GameObjectUtils{
        public static void SetScale(this GameObject gameObject,float scaleX, float scaleY){
            Vector3 localScale = gameObject.transform.localScale;
            localScale.x = scaleX;
            localScale.y = scaleY;
            gameObject.transform.localScale = localScale;
        }

        public static GameObject FindGameObjectInChildren( this GameObject gameObject, string name )
        {
            if( gameObject == null ){ return null; }

            foreach( var t in gameObject.GetComponentsInChildren<Transform>( true ) )
            {
                if( t.name == name ) { return t.gameObject; }
            }
            return null;
        }
        public static void Log(this GameObject gameObject)
        {
            if( gameObject == null ){ return; }
            Modding.Logger.Log(gameObject.name);
            Modding.Logger.Log("Position : " + gameObject.transform.position.ToString());
            Modding.Logger.Log("Rotation : " + gameObject.transform.rotation.ToString());
            Modding.Logger.Log("Scale : " + gameObject.transform.localScale.ToString());
            
            foreach(Component comp in gameObject.GetComponents<Component>()){
                Modding.Logger.Log("Component : "+ comp.GetType());
            }
        }
        public static void LogWithChildren(this GameObject gameObject)
        {
            if( gameObject == null ){ return; }
            gameObject.Log();
            foreach( var t in gameObject.GetComponentsInChildren<Transform>(true) )
            {
                t.gameObject.Log();
            }
        }
        
        public static void PrintAllActiveGameObjectsInScene(){
            foreach(GameObject gameObject in GameObject.FindObjectsOfType<GameObject>())
            {    
                gameObject.Log();
            }
        }
    }
}