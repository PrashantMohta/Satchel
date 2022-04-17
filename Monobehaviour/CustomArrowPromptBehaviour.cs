using TMPro;

namespace Satchel
{
    public class CustomArrowPromptBehaviour : MonoBehaviour {
            public GameObject prompt,customLabel;
            public PromptMarker promptMarker;
            public Action OnPromptTrigger;

            public SetTextMeshProGameText setTextMeshProGameText;
            public string oldConvName , oldSheetName;
            public string PromptText = "Custom Prompt";
            public string languageKey = "customLabel_";

            public bool showing = false;
            void Start(){
                ModHooks.LanguageGetHook += LanguageGet;
            }

            public void OnTriggerEnter2D(Collider2D col){
                if(col.gameObject == HeroController.instance.gameObject){
                    Show();
                }
            }
            public void OnTriggerExit2D(Collider2D col)
            {
                if(col.gameObject == HeroController.instance.gameObject){
                    Hide();
                }
            }   
            public void Show(){
                if(!showing){
                    if(prompt == null)
                    {
                        prompt = CustomArrowPrompt.GetNewPrompt();
                        prompt.transform.position = gameObject.transform.position + new Vector3(0f, 2f, 0f);
                        prompt.transform.SetParent(gameObject.transform, true);
                        promptMarker = prompt.GetComponent<PromptMarker>();
                        customLabel = prompt.Find("Sit");
                        setTextMeshProGameText = customLabel.GetComponent<SetTextMeshProGameText>();
                        languageKey = $"customLabel_{PromptText}";
                        oldConvName = setTextMeshProGameText.convName;
                        oldSheetName = setTextMeshProGameText.sheetName;
                        setTextMeshProGameText.convName = languageKey;
                        setTextMeshProGameText.sheetName = languageKey;
                        setTextMeshProGameText.UpdateText();
                        var textMeshPro = customLabel.GetComponent<TextMeshPro>();
                        textMeshPro.text = PromptText;
                    }
                    promptMarker.SetLabel("Sit");
                    promptMarker.SetOwner(gameObject);
                    promptMarker.Show();
                }
                showing = true;
            }
            public IEnumerator resetBeforeRecycle(SetTextMeshProGameText setTextMeshProGameTextOriginal){
                yield return new WaitForSeconds(2f);
                if(setTextMeshProGameTextOriginal != null ){
                    setTextMeshProGameTextOriginal.convName = oldConvName;
                    setTextMeshProGameTextOriginal.sheetName = oldSheetName;
                    setTextMeshProGameTextOriginal.UpdateText();
                }
            }
            public void Hide(){
                if(showing){
                    StartCoroutine(resetBeforeRecycle(setTextMeshProGameText)); // added this just in case
                    promptMarker.Hide();
                }
                showing = false;
            }

            public void Update(){
                if(showing && !GameManager.instance.isPaused){
                    if(GameManager.instance.inputHandler.inputActions.up.WasPressed || GameManager.instance.inputHandler.inputActions.down.WasPressed){
                        if(OnPromptTrigger != null){
                            OnPromptTrigger();
                            Hide();
                        }
                    }
                }
            }

            public string LanguageGet( string key, string sheet, string orig){
                languageKey = $"customLabel_{PromptText}";
                if(key == languageKey && sheet == languageKey){
                    return PromptText;
                }
                return orig;
            }
    }

}