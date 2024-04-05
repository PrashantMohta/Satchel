namespace Satchel
{
    /// <summary>
    /// Handles Custom Enemies
    /// </summary>
    public class CustomEnemyManager
    {
        private GameObject defaultInfectedEnemyPrefab;
        private GameObject defaultUnInfectedEnemyPrefab;
        private List<GameObject> customEnemies = new List<GameObject>();

        private List<Action<List<GameObject>>> enemyCreatedCallbacks = new List<Action<List<GameObject>>>();
        public CustomEnemyManager()
        {
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnSceneChanged;
        }

        /// <summary>
        /// load Prefabs of InfectedEnemy and UnInfectedEnemy to act as base to use
        /// </summary>
        /// <param name="InfectedEnemyPrefab"></param>
        /// <param name="UnInfectedEnemyPrefab"></param>
        public void Setup(GameObject InfectedEnemyPrefab, GameObject UnInfectedEnemyPrefab)
        {
            if (InfectedEnemyPrefab != null)
            {
                defaultInfectedEnemyPrefab = InfectedEnemyPrefab;
            }
            if (UnInfectedEnemyPrefab != null)
            {
                defaultUnInfectedEnemyPrefab = UnInfectedEnemyPrefab;
            }
        }
        /// <summary>
        /// Add callback for new enemies (called when new enemies are loaded)
        /// </summary>
        /// <param name="callback"></param>
        public void AddCallbackForNewEnemies(Action<List<GameObject>> callback)
        {
            enemyCreatedCallbacks.Add(callback);
        }
        //Make a gameObject into Enemy based on config
        // Go , HM , config to set values into HM
        public GameObject Add() { return null; }

        private void OnSceneChanged(Scene from, Scene to)
        {
            customEnemies = new List<GameObject>();
            foreach (CustomEnemyMarker enemy in GameObject.FindObjectsOfType<CustomEnemyMarker>())
            {
                if (enemy == null && enemy.gameObject == null) { continue; }
                // process an enemy only once
                if (enemy.isProcessed()) { continue; }
                enemy.setProcessed();

                customEnemies.Add(enemy.gameObject);
                enemy.gameObject.AddComponent<CustomEnemy>();
                enemy.gameObject.activateAlertRanges();
                if (enemy.manageHealth)
                {
                    if (enemy.hasRecoil)
                    {
                        enemy.gameObject.addRecoil(
                            enemy.freezeInPlace,
                            enemy.stopVelocityXWhenRecoilingUp,
                            enemy.preventRecoilUp,
                            enemy.recoilSpeedBase,
                            enemy.recoilDuration);
                    }

                    if (enemy.isInfected)
                    {
                        EnemyUtils.copyHealthManagerFields(defaultInfectedEnemyPrefab.GetComponent<HealthManager>(), enemy.gameObject.GetAddComponent<HealthManager>());
                        if (enemy.showHiteffects)
                        {
                            EnemyUtils.copyEnemyPrefabFields(defaultInfectedEnemyPrefab, enemy.gameObject, enemy.manageHealth, enemy.isInfected);
                        }
                    }
                    else
                    {
                        EnemyUtils.copyHealthManagerFields(defaultUnInfectedEnemyPrefab.GetComponent<HealthManager>(), enemy.gameObject.GetAddComponent<HealthManager>());
                        if (enemy.showHiteffects)
                        {
                            EnemyUtils.copyEnemyPrefabFields(defaultUnInfectedEnemyPrefab, enemy.gameObject, enemy.manageHealth, enemy.isInfected);
                        }
                    }

                    var hm = enemy.gameObject.manageHealth(enemy.initialHp);
                    hm.OnDeath += () =>
                    {
                        // make it a corpse
                        enemy.gameObject.layer = 26;
                    };

                }

            }
            if (customEnemies.Count > 0)
            {
                foreach (var callback in enemyCreatedCallbacks)
                {
                    callback(customEnemies);
                }
            }

        }
    }
}