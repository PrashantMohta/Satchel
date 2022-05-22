namespace Satchel
{
    /// <summary>
    /// Creates a CustomArrowPrompt
    /// </summary>
    public static class CustomArrowPrompt {
        public static GameObject ArrowPromptPrefab;

        /// <summary>
        /// Collect the arrow prompt prefab by loading a Cornifer's card prefab
        /// </summary>
        /// <param name="CardPrefab">A preload of Cornifer's card</param>
        public static void Prepare(GameObject CardPrefab){
            PlayMakerFSM pfsm = CardPrefab.LocateMyFSM("npc_control");
            if(pfsm != null){
                ArrowPromptPrefab = pfsm.GetAction<ShowPromptMarker>("In Range",0).prefab.Value;
            }
            
        }
        /// <summary>
        /// Get a new CustomArrowPrompt
        /// </summary>
        /// <returns></returns>
        public static GameObject GetNewPrompt(){
            var go = GameObject.Instantiate(ArrowPromptPrefab);
            return go;
        }

        /// <summary>
        /// Get or Add a CustomArrowPrompt on a GameObject with a collder with text "Listen"
        /// </summary>
        /// <param name="go"></param>
        /// <param name="OnPromptTrigger">Action to trigger when the prompt is interacted with</param>
        public static void GetAddCustomArrowPrompt(this GameObject go,Action OnPromptTrigger){
            go.GetAddCustomArrowPrompt("Listen",OnPromptTrigger);
        }
        /// <summary>
        /// Get or Add a CustomArrowPrompt on a GameObject with a collder with text
        /// </summary>
        /// <param name="go"></param>
        /// <param name="PromptText"></param>
        /// <param name="OnPromptTrigger">Action to trigger when the prompt is interacted with</param>
        public static void GetAddCustomArrowPrompt(this GameObject go,string PromptText,Action OnPromptTrigger){
            var ap = go.GetAddComponent<CustomArrowPromptBehaviour>();
            ap.PromptText = PromptText;
            ap.OnPromptTrigger = OnPromptTrigger;
        }

    }
}