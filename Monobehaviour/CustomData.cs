namespace Satchel
{   
    public class CustomData : MonoBehaviour {
        
        private Dictionary<string,object> dataStore = new();

        public void setData(string key,object data){
            dataStore[key] = data;
        }

        public object getData(string key){
            dataStore.TryGetValue(key,out var val);
            return val;
        }
    }
}