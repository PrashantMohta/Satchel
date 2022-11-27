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
        
        /// <summary>
        /// Run some code after some frames
        /// </summary>
        /// <param name="numFrames">The number of frames to wait</param>
        /// <param name="codeToRun">the code to run</param>
        public static Coroutine WaitForFramesBeforeInvoke(int numFrames, Action codeToRun)
        {
            return GetRunner().StartCoroutine(WaitBeforeInvokeRoutine(numFrames, codeToRun));
        }

        /// <summary>
        /// Run some code after some seconds
        /// </summary>
        /// <param name="seconds">The number of seconds to wait</param>
        /// <param name="codeToRun">the code to run</param>
        public static Coroutine WaitForSecondsBeforeInvoke(float seconds, Action codeToRun)
        {
            return GetRunner().StartCoroutine(WaitBeforeInvokeRoutine(seconds, codeToRun));
        }
    
        private static IEnumerator WaitBeforeInvokeRoutine(int numFrames, Action codeToRun)
        {
            for (int i = 0; i < numFrames; i++)
            {
                yield return null;
            }

            codeToRun();
        }

        private static IEnumerator WaitBeforeInvokeRoutine(float seconds, Action codeToRun)
        {
            yield return new WaitForSeconds(seconds);

            codeToRun();
        }
    }
}