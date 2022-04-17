using static Modding.Logger;

namespace Satchel
{
    public class CustomDialogueManager {
        
        public string prefix = "SatchelCustomDialogue";
        public Dictionary<string,string> Conversations = new Dictionary<string,string>();
        public bool isDialogueBoxOpen = false,takenControl = false;
        public string currentDialog;
        public GameObject DialogManager,DialogTextBox,DialogBox;
        public DialogueBox dboxComponent; 

        public PlayMakerFSM conversationControl;

        public FsmEventTarget boxEventTarget;
        private List<Action<string,int>> PageCompletionCallback = new List<Action<string,int>>();
        private List<Action<string>> ConversationCompletionCallback = new List<Action<string>>();

        private DialogueBox GetDialogueBox(){
            if(dboxComponent == null){
                conversationControl = DialogManager.LocateMyFSM("Conversation Control");
                boxEventTarget = conversationControl.GetAction<SendEventByName>("Box Up",0).eventTarget;
                DialogTextBox = conversationControl.GetAction<CallMethodProper>("Greet",1).gameObject.GameObject.Value;
                dboxComponent = DialogTextBox.GetComponent<DialogueBox>();
                addEventsInFSM();
            }
            return dboxComponent;
        }

        public CustomDialogueManager(GameObject cardPrefab){
            DialogManager = cardPrefab.createCustomDialogFromPrefab();
            DialogManager.SetActive(true);
            ModHooks.LanguageGetHook += LanguageGet;
        }

        private void addEventsInFSM(){
            PlayMakerFSM pfsm = DialogTextBox.LocateMyFSM("Dialogue Page Control");
            if(pfsm != null){
                pfsm.InsertCustomAction("Page End",() => EndPage(),0);
                pfsm.InsertCustomAction("End Conversation",() => EndConversation(),5);
            }
        }

        public void OnEndPage(Action<string,int> callback){
            PageCompletionCallback.Add(callback);
        }
        private void EndPage(){
            foreach(var callback in PageCompletionCallback){
                callback(currentDialog,dboxComponent.currentPage);
            }
        }

        public void OnEndConversation(Action<string> callback){
            ConversationCompletionCallback.Add(callback);
        }
        private void EndConversation(){
            foreach(var callback in ConversationCompletionCallback){
                callback(currentDialog);
            }
            conversationControl.Fsm.Event(boxEventTarget,"BOX DOWN");
            isDialogueBoxOpen = false;
            if(takenControl){
                HeroController.instance.RegainControl();
                takenControl = false;
            }
        }

        public void AddConversation(string name,string conversation){
            Conversations[prefix+name] = conversation;
        }
        public void ShowDialogue(string name,bool takeControl = true){
            if(isDialogueBoxOpen){ return; }
            currentDialog = name;
            if(dboxComponent == null){
                dboxComponent = GetDialogueBox();
            }
            if(dboxComponent != null){
                dboxComponent.StartConversation(prefix+name,prefix);
                conversationControl.Fsm.Event(boxEventTarget,"BOX UP");
                isDialogueBoxOpen = true;
                if(takeControl){
                    takenControl = true;
                    HeroController.instance.RelinquishControl();
                }
            } else {
                Log("Component is null");
            }
        }

        public string LanguageGet( string key, string sheet, string orig){
            if(key.StartsWith(prefix) && sheet.StartsWith(prefix)){
                if(Conversations.TryGetValue(key,out var dialogue)){
                    return dialogue;
                }
            }
            return orig;
        }
    }
}