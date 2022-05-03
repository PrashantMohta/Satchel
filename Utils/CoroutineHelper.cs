namespace Satchel
{
    public class CoroutineRunner : MonoBehaviour{}
    public static class CoroutineHelper{
        private static GameObject gameObject;
        private static CoroutineRunner runner;
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