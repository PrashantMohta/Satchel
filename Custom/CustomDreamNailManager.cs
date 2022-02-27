namespace Satchel
{
    public class CustomDreamNailManager {

        public Dictionary<string,string> DNdialog = new Dictionary<string,string>();
    
        public CustomDreamNailManager(){
            ModHooks.LanguageGetHook += LanguageGet;
        }

        // will add or update dn text for id
        public Convo SetText(Convo conv, string text){
            conv.Amount++;
            DNdialog[$"{conv.Id}_{conv.Amount}"] = text; // based on convo amount
            return conv;
        }

        public string LanguageGet( string key, string sheet, string orig){
            //string orig = Language.Language.GetInternal(key, sheet);
            if(key.StartsWith(Convo.prefix)){
                var dnkey = key.Replace(Convo.prefix,"");
                if(DNdialog.TryGetValue(dnkey, out var dntext)){
                    if(dntext != "" && dntext != null) {
                        return dntext;
                    }
                }
            }
            return orig;
        }
        private void OnDestroy()
        {
            ModHooks.LanguageGetHook -= LanguageGet;
        }

    }
}