using System.Reflection;
using System.Text.RegularExpressions;
using UScene = UnityEngine.SceneManagement.Scene;

namespace Satchel
{
    /// <summary>
    /// Utilities to work with GameObjects
    /// </summary>
    public static class GameObjectUtils{

        /// <summary>
        /// Get a component of type T if it exists on the GameObject or add a new one
        /// </summary>
        /// <typeparam name="T">Component Type</typeparam>
        /// <param name="go">GameObject</param>
        /// <returns>A component of type T</returns>
        public static T  GetAddComponent<T>(this GameObject go) where T : Component {
            T comp = go.GetComponent<T>();
            if(comp == null){
                comp = go.AddComponent<T>();
            }
            return comp;
        }

        /// <summary>
        /// Remove a Component from the GameObject
        /// </summary>
        /// <typeparam name="T">Component Type</typeparam>
        /// <param name="go">GameObject</param>
        /// <returns>boolean indicating if the component was removed</returns>
        public static bool RemoveComponent<T>(this GameObject go) where T : Component{
            T comp = go.GetComponent<T>();
            if(comp != null){
                GameObject.DestroyImmediate(comp);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Copy a component from one GameObject to another
        /// </summary>
        /// <typeparam name="T">Component Type</typeparam>
        /// <param name="to">GameObject to copy to</param>
        /// <param name="from">GameObject to copy from</param>
        /// <returns>the copied component</returns>
        public static T copyComponent<T>(this GameObject to,GameObject from) where T : Component {
            if(from == null) {return null;}
            var fromComponent = from.GetComponent<T>();
            var toComponent = to.GetAddComponent<T>();
            if(fromComponent == null) {return null;}
            foreach (FieldInfo fi in typeof(T).GetFields(BindingFlags.Default | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.CreateInstance | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.IgnoreCase | BindingFlags.IgnoreReturn | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.OptionalParamBinding | BindingFlags.PutDispProperty | BindingFlags.SuppressChangeType | BindingFlags.PutRefDispProperty))
            {   
                fi.SetValue(toComponent, fi.GetValue(fromComponent));
            }
            return toComponent;
        }
        /// <summary>
        /// Set the scale of a GameObject
        /// </summary>
        /// <param name="gameObject">GameObject</param>
        /// <param name="scaleX">X scale</param>
        /// <param name="scaleY">Y scale</param>
        public static void SetScale(this GameObject gameObject,float scaleX, float scaleY){
            Vector3 localScale = gameObject.transform.localScale;
            localScale.x = scaleX;
            localScale.y = scaleY;
            gameObject.transform.localScale = localScale;
        }

        /// <summary>
        /// Find a gameobject in children of another by name
        /// </summary>
        /// <param name="gameObject">GameObject parent</param>
        /// <param name="name">Name of GameObject to find</param>
        /// <param name="useBaseName">boolean indicaing if baseName should be used</param>
        /// <returns>The GameObject if found or null</returns>
        public static GameObject FindGameObjectInChildren( this GameObject gameObject, string name ,bool useBaseName = false)
        {
            if( gameObject == null ){ return null; }

            foreach( var t in gameObject.GetComponentsInChildren<Transform>( true ) )
            {
                if( t.GetName(useBaseName) == name ) { return t.gameObject; }
            }
            return null;
        }

        /// <summary>
        /// Find all gameobjects in children of another by name
        /// </summary>
        /// <param name="gameObject">GameObject parent</param>
        /// <param name="name">Name of GameObjects to find</param>
        /// <param name="useBaseName">boolean indicaing if baseName should be used</param>
        /// <returns>The List of GameObjects</returns>
        public static List<GameObject> FindGameObjectsInChildren( this GameObject gameObject, string name ,bool useBaseName = false)
        {
            if( gameObject == null ){ return null; }
            List<GameObject> children = new List<GameObject>(); 
            foreach( var t in gameObject.GetComponentsInChildren<Transform>( true ) )
            {
                if( t.GetName(useBaseName) == name ) { 
                    children.Add(t.gameObject);
                }
            }
            return children;
        }
        /// <summary>
        /// Log a game object for debugging
        /// </summary>
        /// <param name="gameObject">GameObject</param>
        public static void Log(this GameObject gameObject)
        {
            if( gameObject == null ){ return; }
            Satchel.Instance.Log(gameObject.GetName());
            Satchel.Instance.Log(gameObject.GetPath());
            Satchel.Instance.Log("Layer : " + gameObject.layer);
            Satchel.Instance.Log("Position : " + gameObject.transform.position.ToString());
            Satchel.Instance.Log("Rotation : " + gameObject.transform.rotation.ToString());
            Satchel.Instance.Log("Scale : " + gameObject.transform.localScale.ToString());
            
            foreach(Component comp in gameObject.GetComponents<Component>()){
                Satchel.Instance.Log("Component : "+ comp.GetType());
                if(comp is PlayMakerFSM){
                    Satchel.Instance.Log("---- Fsm name :" + ( comp as PlayMakerFSM ).FsmName);
                }
                /*
                if(comp.GetType().GetProperty("name") != null){
                    Satchel.Instance.Log("---- name :" + comp.name);
                } else 
                */
            }
        }
        
        /// <summary>
        /// Log a game object and all it's children for debugging
        /// </summary>
        /// <param name="gameObject"></param>
        public static void LogWithChildren(this GameObject gameObject)
        {
            if( gameObject == null ){ return; }
            gameObject.Log();
            foreach( var t in gameObject.GetComponentsInChildren<Transform>(true) )
            {
                t.gameObject.Log();
            }
        }
        
        /// <summary>
        /// Logs all active gameObjects 
        /// </summary>
        public static void PrintAllActiveGameObjectsInScene(){
            foreach(GameObject gameObject in GameObject.FindObjectsOfType<GameObject>())
            {    
                gameObject.Log();
            }
        }

        /// <summary>
        /// Find a GameObject that is a descendent of the current GameObject by name
        /// </summary>
        /// <param name="go">Ancestor GameObject</param>
        /// <param name="name">Name of GameObject to find</param>
        /// <returns>GameObject or null</returns>
        public static GameObject Find(this GameObject go,string name){
            for (int i = 0; i < go.transform.childCount; i++)
            {
                var child = go.transform.GetChild(i).gameObject;
                if(child.name == name){
                    return child;
                }
            }
            for (int i = 0; i < go.transform.childCount; i++)
            {
                var retVal = go.transform.GetChild(i).gameObject.Find(name);
                if(retVal != null){
                    return retVal;
                }
            }
            return null;
        }



        /// <summary>
        /// Find all GameObjects that are a descendent of the current GameObject by name
        /// </summary>
        /// <param name="go">Ancestor GameObject</param>
        /// <param name="allGoList">List to add the results to</param>
        public static void FindAllChildren(this GameObject go, List<GameObject> allGoList){
            for (int i = 0; i < go.transform.childCount; i++)
            {
                allGoList.Add(go.transform.GetChild(i).gameObject);
            }
            for (int i = 0; i < go.transform.childCount; i++)
            {
                go.transform.GetChild(i).gameObject.FindAllChildren(allGoList);
            }
        }

        /// <summary>
        /// Disable all children of a GameObject
        /// </summary>
        /// <param name="go">GameObject</param>
        public static void DisableChildren(this GameObject go){
            for (int i = 0; i < go.transform.childCount; i++)
            {
                var child = go.transform.GetChild(i).gameObject;
                child.SetActive(false);
            }
        }
        
        /// <summary>
        /// Get All gameobjects in scene (even inactive ones)
        /// </summary>
        /// <param name="scene">The scene</param>
        /// <returns>A List of All GameObjects in the scene</returns>
        public static List<GameObject> GetAllGameObjects(this UScene scene)
        {
            List<GameObject> allGoList = new List<GameObject>();
            foreach (var go in scene.GetRootGameObjects()){
                allGoList.Add(go);
                go.FindAllChildren(allGoList);
            }
            return allGoList;
        }

        /// <summary>
        /// Get a gameobject by name in a scene (even inactive ones)
        /// </summary>
        /// <param name="scene">The scene</param>
        /// <param name="name">Name of the GameObject</param>
        /// <param name="useBaseName">boolean indicating if BaseName should be used</param>
        /// <returns>GameObject or null</returns>
        public static GameObject GetGameObjectByName(this UScene scene, string name,bool useBaseName = false)
        {
            GameObject foundGo;
            foreach (var go in scene.GetRootGameObjects()){
                if(go.GetName(useBaseName) == name){
                    return go;
                }
                foundGo = go.FindGameObjectInChildren(name,useBaseName);
                if(foundGo != null){
                    return foundGo;
                }
            }
            return null;
        }

        /// <summary>
        /// Get Root GameObjects in currently Active scene
        /// </summary>
        /// <returns></returns>
        public static GameObject[] GetRootGameObjects(){
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        }
        /// <summary>
        /// Find  a gameobject by name in the active scene(even inactive ones)
        /// </summary>
        /// <param name="name">Name of GameObject</param>
        /// <param name="useBaseName">boolean indicating if BaseName should be used</param>
        /// <returns>GameObject or null</returns>
        public static GameObject GetGameObjectInScene(string name,bool useBaseName = false){
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetGameObjectByName(name,useBaseName);
        }

        /// <summary>
        ///  Get All GameObjects in the active scene (even inactive ones)
        /// </summary>
        /// <returns></returns>
        public static List<GameObject> GetAllGameObjectsInScene(){
            return UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetAllGameObjects();
        }
        /// <summary>
        /// Get the Name of a GameObject by Transform
        /// </summary>
        /// <param name="transform"> the Transform</param>
        /// <param name="useBaseName">boolean indicating if BaseName should be used</param>
        /// <returns></returns>
        public static string GetName(this Transform transform, bool useBaseName = false){
           return transform.gameObject.GetName(useBaseName);
        }
        /// <summary>
        /// Get the Name of a GameObject
        /// </summary>
        /// <param name="go">GameObject</param>
        /// <param name="useBaseName">boolean indicating if BaseName should be used</param>
        /// <returns></returns>
        public static string GetName(this GameObject go,bool useBaseName = false){
            string ret = go.name;
            if(useBaseName){
                ret = ret.ToLower();
                ret.Replace("(clone)", "");
                ret = ret.Trim();
                ret.Replace("cln", "");
                ret = ret.Trim();
                ret = Regex.Replace(ret, @"\([0-9+]+\)", "");
                ret = ret.Trim();
                ret = Regex.Replace(ret, @"[0-9+]+$", "");
                ret = ret.Trim();
                ret.Replace("(clone)", "");
                ret = ret.Trim();
            }
            return ret;
        }
        /// <summary>
        /// Get the Scene path of a GameObject
        /// </summary>
        /// <param name="go">GameObject</param>
        /// <param name="useBaseName">boolean indicating if BaseName should be used</param>
        /// <returns></returns>
        public static string GetPath(this GameObject go,bool useBaseName = false){
            string path = go.GetName(useBaseName);
            GameObject currObj = go;
            while(currObj.transform.parent != null && currObj.transform.parent.gameObject != null){
                currObj = currObj.transform.parent.gameObject;
                path = currObj.GetName(useBaseName) + "/" + path; 
            }
            return path;
        }
        /// <summary>
        /// Get or Add a custom data component to a GameObject
        /// </summary>
        /// <param name="go">GameObject</param>
        /// <returns>CustomData component on the GameObject</returns>
        public static CustomData GetAddCustomData(this GameObject go){
           return go.GetAddComponent<CustomData>();
        }

    }
}