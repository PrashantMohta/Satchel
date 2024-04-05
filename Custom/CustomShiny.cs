namespace Satchel
{
    /// <summary>
    /// Handles a single Custom Shiny
    /// </summary>
    public class CustomShiny
    {
        /// <summary>
        /// Prepare shinies using a prefab of a shiny
        /// </summary>
        /// <param name="prefab">A preload of a Shiny</param>
        /// <returns></returns>
        public GameObject preparePrefab(GameObject prefab)
        {
            var go = GameObject.Instantiate(prefab);
            var fsm = go.LocateMyFSM("Shiny Control");
            fsm.GetVariable<FsmBool>("Activated").Value = false;
            fsm.GetVariable<FsmBool>("Charm").Value = false;
            fsm.GetVariable<FsmBool>("Dash Cloak").Value = false;
            fsm.GetVariable<FsmBool>("Exit Dream").Value = false;
            fsm.GetVariable<FsmBool>("Journal").Value = false;
            fsm.GetVariable<FsmBool>("King's Brand").Value = false;
            fsm.GetVariable<FsmBool>("Pure Seed").Value = false;
            fsm.GetVariable<FsmBool>("Quake").Value = false;
            fsm.GetVariable<FsmBool>("Show Charm Tute").Value = false;
            fsm.GetVariable<FsmBool>("Slug Fling").Value = false;
            fsm.GetVariable<FsmBool>("Super Dash").Value = false;
            fsm.GetVariable<FsmBool>("Mantis Claw").Value = false;

            fsm.ChangeTransition("Init", "FINISHED", "Idle");
            fsm.RemoveAction("Init", 2);
            fsm.RemoveAction("Finish", 1);

            if (isTrinket)
            {
                fsm.ChangeTransition("Hero Down", "FINISHED", "Trink Flash");
                fsm.ChangeTransition("Trink Flash", "FINISHED", "Trink 1");
                // update values for this shiny
                fsm.GetAction<SetSpriteRendererSprite>("Trink 1", 2).sprite.Value = sprite;
                fsm.GetAction<GetLanguageString>("Trink 1", 3).sheetName.Value = $"{CustomShinyManager.languageKey}UI";
                fsm.GetAction<GetLanguageString>("Trink 1", 3).convName.Value = $"{CustomShinyManager.languageKey}_{ItemName}";
                // remove pd updates
                fsm.RemoveAction("Trink 1", 5);
                fsm.RemoveAction("Trink 1", 1);
                fsm.RemoveAction("Trink 1", 0);
                // add custom action
                fsm.AddCustomAction("Trink 1", () =>
                {
                    if (Callback != null)
                    {
                        Callback();
                    }
                });
            }
            else
            {
                fsm.ChangeTransition("Hero Down", "FINISHED", "Big Get Flash");
                fsm.ChangeTransition("Big Get Flash", "FINISHED", "Dash");
                fsm.AddTransition("Dash", "FINISHED", "Hero Up");

                fsm.RemoveAction("Big Get Flash", 6);

                fsm.RemoveAction("Dash", 4);
                fsm.RemoveAction("Dash", 3);
                fsm.RemoveAction("Dash", 2);
                fsm.RemoveAction("Dash", 1);
                fsm.RemoveAction("Dash", 0);
                // add custom action
                fsm.AddCustomAction("Dash", () =>
                {
                    if (Callback != null)
                    {
                        Callback();
                    }
                });
            }
            return go;
        }

        public string sceneName = "Town";
        public Vector3 position = new Vector3(0f, 0f, 0f);
        public Action Callback;
        public Func<bool> ShouldSpawn = () => true;
        public bool isTrinket = false, isStand = false;
        public Sprite sprite;
        public string ItemName;
        /// <summary>
        /// Create a custom shiny
        /// </summary>
        /// <param name="ItemName"></param>
        /// <param name="sceneName"></param>
        /// <param name="position"></param>
        /// <param name="isStand"></param>
        /// <param name="isTrinket"></param>
        /// <param name="Callback"></param>
        /// <param name="ShouldSpawn"></param>
        /// <param name="sprite"></param>
        public CustomShiny(string ItemName, string sceneName, Vector3 position, bool isStand, bool isTrinket, Action Callback, Func<bool> ShouldSpawn, Sprite sprite)
        {
            this.ItemName = ItemName;
            this.sceneName = sceneName;
            this.position = position;
            this.isTrinket = isTrinket;
            this.Callback = Callback;
            this.ShouldSpawn = ShouldSpawn;
            this.sprite = sprite;
            this.isStand = isStand;
        }
        /// <summary>
        /// Spawn a shiny using a prefab of a shiny
        /// </summary>
        /// <param name="prefab">A preload of a Shiny</param>
        public void Spawn(GameObject prefab)
        {
            var go = preparePrefab(prefab);
            go.transform.position = position;
            go.SetActive(true);
        }

    }
}