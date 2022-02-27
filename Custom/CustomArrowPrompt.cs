namespace Satchel
{
    public static class CustomArrowPrompt {
        public static GameObject ArrowPromptPrefab;
        public static void Prepare(GameObject CardPrefab){
            PlayMakerFSM pfsm = CardPrefab.LocateMyFSM("npc_control");
            if(pfsm != null){
                ArrowPromptPrefab = pfsm.GetAction<ShowPromptMarker>("In Range",0).prefab.Value;
            }
            
        }
        public static GameObject GetNewPrompt(){
            var go = GameObject.Instantiate(ArrowPromptPrefab);
            return go;
        }


        public static void GetAddCustomArrowPrompt(this GameObject go,Action OnPromptTrigger){
            go.GetAddCustomArrowPrompt("Listen",OnPromptTrigger);
        }
        public static void GetAddCustomArrowPrompt(this GameObject go,string PromptText,Action OnPromptTrigger){
            var ap = go.GetAddComponent<CustomArrowPromptBehaviour>();
            ap.PromptText = PromptText;
            ap.OnPromptTrigger = OnPromptTrigger;
        }

    }
}