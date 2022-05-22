using InControl;

namespace Satchel
{
    /// <summary>
    /// Handles the CustomBigItemGet Popup
    /// </summary>
    public class CustomBigItemGetManager {
        public GameObject MsgUiPrefab;
        /// <summary>
        /// Prepare a Prefab of the Message UI by loading a shiny Prefab
        /// </summary>
        /// <param name="ShinyPrefab">A preload of a shiny</param>
        public void Prepare(GameObject ShinyPrefab){
           var fsm = ShinyPrefab.LocateMyFSM("Shiny Control");
           MsgUiPrefab = fsm.GetAction<CreateUIMsgGetItem>("Walljump",3).gameObject.Value;
        }
        /// <summary>
        /// Show a CustomBigItemGet Popup
        /// </summary>
        /// <param name="ItemName"></param>
        /// <param name="Intro1"></param>
        /// <param name="ButtonPress"></param>
        /// <param name="Prompt1"></param>
        /// <param name="Prompt2"></param>
        /// <param name="sprite"></param>
        /// <param name="actionGet"></param>
        /// <param name="Callback"></param>
        public void ShowDialog(
            string ItemName,
            string Intro1,
            string ButtonPress,
            string Prompt1,
            string Prompt2,
            Sprite sprite,
            Func<PlayerAction> actionGet,
            Action Callback){
            var go = UnityEngine.Object.Instantiate(MsgUiPrefab, Vector3.zero, Quaternion.identity);
            GameObject.DontDestroyOnLoad(go);
            var bigItemGet = go.AddComponent<CustomBigItemGetBehaviour>();
            bigItemGet.SetItem(ItemName,Intro1,ButtonPress,Prompt1,Prompt2,sprite,actionGet,Callback);
            bigItemGet.Show();
        }

    }
}