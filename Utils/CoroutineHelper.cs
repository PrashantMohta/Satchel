namespace Satchel
{
    /// <summary>
    /// dummy MonoBehaviour
    /// </summary>
    public class CoroutineRunner : MonoBehaviour{}

    /// <summary>
    /// Coroutine Helper to make sure coroutines have a GameObject to run on
    /// </summary>
    public static class CoroutineHelper{
        private static GameObject gameObject;
        private static CoroutineRunner runner;
        /// <summary>
        /// Get the current runner singleton
        /// </summary>
        /// <returns></returns>
        public static CoroutineRunner GetRunner(){
            if(runner == null){
                if(gameObject == null){
                    gameObject = new GameObject();
                    GameObject.DontDestroyOnLoad(gameObject);
                }
                runner = gameObject.GetAddComponent<CoroutineRunner>();
            }
            return runner;
        }
    }
}