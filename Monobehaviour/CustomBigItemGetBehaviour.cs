using InControl;

namespace Satchel
{
    public class CustomBigItemGetBehaviour : MonoBehaviour {
           
            public string ItemName = "ITEM";
            public string Intro1, ButtonPress, Prompt1, Prompt2;
            public string languageKey = "SATCHEL_";

            public Func<PlayerAction> actionGet;

            public PlayMakerFSM dialogFsm;
            void Start(){
            }

            public void SetItem(
                string ItemName,
                string Intro1,
                string ButtonPress,
                string Prompt1,
                string Prompt2,
                Sprite sprite,
                Func<PlayerAction> actionGet,
                Action Callback){
                this.ItemName = ItemName;
                this.Intro1 = Intro1;
                this.ButtonPress = ButtonPress;
                this.Prompt1 = Prompt1;
                this.Prompt2 = Prompt2;
                this.actionGet = actionGet;
                dialogFsm = gameObject.LocateMyFSM("Msg Control");
                dialogFsm.GetVariable<FsmString>("Item").Value = "Dash";

                languageKey = $"SATCHEL_{ItemName}_";
                // update other states before removing because that will change index and make it confusing
                dialogFsm.GetAction<GetLanguageString>("Set Dash",2).sheetName.Value = $"{languageKey}UI";
                dialogFsm.GetAction<GetLanguageString>("Set Dash",2).convName.Value = $"{languageKey}INV_NAME";

                dialogFsm.GetAction<GetLanguageString>("Set Dash",4).sheetName.Value = $"{languageKey}Prompts";
                dialogFsm.GetAction<GetLanguageString>("Set Dash",4).convName.Value = $"{languageKey}GET_ITEM_INTRO1";

                dialogFsm.GetAction<GetLanguageString>("Set Dash",6).sheetName.Value = $"{languageKey}Prompts";
                dialogFsm.GetAction<GetLanguageString>("Set Dash",6).convName.Value = $"{languageKey}BUTTON_DESC_PRESS";

                dialogFsm.GetAction<GetLanguageString>("Set Dash",8).sheetName.Value = $"{languageKey}Prompts";
                dialogFsm.GetAction<GetLanguageString>("Set Dash",8).convName.Value = $"{languageKey}GET_1";

                dialogFsm.GetAction<GetLanguageString>("Set Dash",10).sheetName.Value = $"{languageKey}Prompts";
                dialogFsm.GetAction<GetLanguageString>("Set Dash",10).convName.Value = $"{languageKey}GET_2";
                
                // yeet the first 2 actions, need to do in reverse order 
                dialogFsm.RemoveAction("Set Dash",1);
                dialogFsm.RemoveAction("Set Dash",0);

                // set sprite
                if (sprite != null)
                {
                    var transform = gameObject.transform.Find("Icon");
                    if ((bool)transform)
                    {
                        SpriteRenderer component = transform.GetComponent<SpriteRenderer>();
                        if ((bool)component)
                        {
                            component.sprite = sprite;
                        }
                    }
                }

                //add callback
                if(Callback != null){
                    dialogFsm.InsertCustomAction("Done",()=>{
                        Callback();
                        Destroy(gameObject);
                    },1);
                }
            }

            private float blnkWidth = 1.685f;
            private float blnkHeight = 0.6f;
            private float blnkFontMax = 9.5f;
            private float blnkFontMin = 4f;
            private float sqrWidth = 0.7f;
            private float sqrHeight = 0.8f;
            private float sqrFontMax = 5.5f;
            private float sqrFontMin = 3.35f;
            private float wideWidth = 2f;
            private float wideHeight = 0.7f;
            private float wideFontMax = 3f;
            private float wideFontMin = 2f;
            public IEnumerator updateButtonIcon(PlayerAction action){
                    yield return new WaitForSeconds(1f);
                    var uibs = UIManager.instance.uiButtonSkins;
                    ButtonSkin buttonSkinFor = uibs.GetButtonSkinFor(action);
                    var abicon = gameObject.GetComponentInChildren<ActionButtonIcon>();
                    if(abicon == null){
                        Modding.Logger.Log("[Satchel] Couldn't get ActionButtonIcon skin for " + action);
                    }
                    if (buttonSkinFor == null)
                    {
                        Modding.Logger.Log("[Satchel] Couldn't get button skin for " + action);
                    }
                    var label = abicon.label;
                    var textContainer = abicon.textContainer;
                    var button = abicon.gameObject;
                    var sr  =  button.GetComponent<SpriteRenderer>();
                    Destroy(abicon);
                    sr.sprite = buttonSkinFor.sprite;
                    if (textContainer != null)
                    {
                        if (buttonSkinFor.skinType == ButtonSkinType.BLANK)
                        {
                            textContainer.width = blnkWidth;
                            textContainer.height = blnkHeight;
                        }
                        else if (buttonSkinFor.skinType == ButtonSkinType.SQUARE)
                        {
                            textContainer.width = sqrWidth;
                            textContainer.height = sqrHeight;
                        }
                        else if (buttonSkinFor.skinType == ButtonSkinType.WIDE)
                        {
                            textContainer.width = wideWidth;
                            textContainer.height = wideHeight;
                        }
                    }
                    if (label != null)
                    {
                        if (buttonSkinFor.skinType == ButtonSkinType.BLANK)
                        {
                            label.fontSizeMin = blnkFontMin;
                            label.fontSizeMax = blnkFontMax;
                        }
                        else if (buttonSkinFor.skinType == ButtonSkinType.SQUARE)
                        {
                            label.fontSizeMin = sqrFontMin;
                            label.fontSizeMax = sqrFontMax;
                        }
                        else if (buttonSkinFor.skinType == ButtonSkinType.WIDE)
                        {
                            label.fontSizeMin = wideFontMin;
                            label.fontSizeMax = wideFontMax;
                            button.transform.position += new Vector3(0.5f,0f,0f); 
                        }
                        label.text = buttonSkinFor.symbol;
                    }
            }

            public void Show(){
                ModHooks.LanguageGetHook += LanguageGet;
                gameObject.SetActive(true);
                
                // set button icon
                if(this.actionGet() != null){
                    StartCoroutine(updateButtonIcon(this.actionGet()));
                } else {
                    var abicon = gameObject.GetComponentInChildren<ActionButtonIcon>();
                    var button = abicon.gameObject;
                    button.SetActive(false);
                }
            }
            public void OnDestroy()
            {
                ModHooks.LanguageGetHook -= LanguageGet;
            }
            public string LanguageGet( string key, string sheet, string orig){
                languageKey = $"SATCHEL_{ItemName}_";
                if(sheet == $"{languageKey}UI" && key == $"{languageKey}INV_NAME"){
                    return ItemName;
                }
                if(sheet == $"{languageKey}Prompts"){
                    if(key == $"{languageKey}GET_ITEM_INTRO1"){
                        return Intro1;
                    } else if(key == $"{languageKey}BUTTON_DESC_PRESS"){
                        return ButtonPress;
                    } else if(key == $"{languageKey}GET_1"){
                        return Prompt1;
                    } else if(key == $"{languageKey}GET_2"){
                        return Prompt2;
                    }  
                }
                return orig;
            }
    }

}