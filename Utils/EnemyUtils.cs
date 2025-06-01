using System.Linq;
using System.Reflection;
namespace Satchel
{
    /// <summary>
    /// Class representing a conversation for CustomDreamNail Dialogues
    /// </summary>
    public class Convo
    {
        public static string prefix = "dc_custom_dn_";
        public string Id;
        public string Key;
        public int Amount = 0;

        public Convo(string convId)
        {
            this.Id = convId;
            this.Key = Convo.prefix + this.Id;

        }
    }

    /// <summary>
    /// Utilities to work with enemies
    /// </summary>
    public static class EnemyUtils
    {

        /// <summary>
        /// Create a stripped down version of a Prefab (perfect for controlling using a script)
        /// </summary>
        /// <param name="CompanionPrefab">A preload of the original GameObject</param>
        /// <returns></returns>
        public static GameObject createCompanionFromPrefab(this GameObject CompanionPrefab)
        {
            return CompanionPrefab.createCompanionFromPrefab(false);
        }
        /// <summary>
        /// Create a stripped down version of a Prefab (perfect for controlling using a script)
        /// </summary>
        /// <param name="CompanionPrefab">A preload of the original GameObject</param>
        /// <param name="DestroyOnLoad">if prefab should be destroyed on load</param>
        /// <returns></returns>
        public static GameObject createCompanionFromPrefab(this GameObject CompanionPrefab, bool DestroyOnLoad = false)
        {
            GameObject Companion = GameObject.Instantiate(CompanionPrefab);
            Companion.name = "Companion";
            Companion.layer = 18;
            Companion.DisableChildren();
            Companion.SetActive(false);
            // remove extra things that the prefab might have
            while (Companion.RemoveComponent<PlayMakerFSM>()) { }
            ;
            Companion.RemoveComponent<PlayMakerUnity2DProxy>();
            Companion.RemoveComponent<PlayMakerFixedUpdate>();
            Companion.RemoveComponent<Recoil>();
            Companion.RemoveComponent<EnemyDreamnailReaction>();
            Companion.RemoveComponent<EnemyHitEffectsUninfected>();
            Companion.RemoveComponent<EnemyDeathEffectsUninfected>();
            Companion.RemoveComponent<HealthManager>();
            Companion.RemoveComponent<ExtraDamageable>();
            Companion.RemoveComponent<DamageHero>();
            Companion.RemoveComponent<ConstrainPosition>();
            if (!DestroyOnLoad)
            {
                UnityEngine.Object.DontDestroyOnLoad(Companion);
            }
            return Companion;
        }

        /// <summary>
        /// Create custom dialog from a Cornifer's card prefab
        /// </summary>
        /// <param name="prefab">A preload of Cornifer's card</param>
        /// <returns></returns>
        public static GameObject createCustomDialogFromPrefab(this GameObject prefab)
        {
            GameObject dialog = GameObject.Instantiate(prefab);
            dialog.name = "CustomDialog";
            dialog.SetActive(false);
            // remove extra things that the prefab might have
            var fsms = dialog.GetComponents<PlayMakerFSM>();
            foreach (var fsm in fsms)
            {
                if (fsm.FsmName != "Conversation Control")
                {
                    GameObject.DestroyImmediate(fsm);
                }
            }
            dialog.RemoveComponent<PlayMakerUnity2DProxy>();
            dialog.RemoveComponent<PlayMakerFixedUpdate>();
            UnityEngine.Object.DontDestroyOnLoad(dialog);
            return dialog;
        }
        /// <summary>
        /// Activate the AlertRangeMarkers on this GameObject
        /// </summary>
        /// <param name="enemy">GameObject</param>
        public static void activateAlertRanges(this GameObject enemy)
        {
            foreach (var arm in enemy.GetComponentsInChildren<AlertRangeMarker>(true))
            {
                arm.gameObject.AddComponent<AlertRange>();
            }
        }

        /// <summary>
        /// Move a Rigidbody2D in a direction for a certain distance in a certain amount of time
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="direction"></param>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static WaitForSeconds moveTowards(this Rigidbody2D rb, Vector2 direction, float distance, float time)
        {
            var speed = distance / time;
            var velocity = direction.normalized * speed;
            rb.velocity = velocity;
            return new WaitForSeconds(time);
        }

        /// <summary>
        /// Copy all HealthManagerFields
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void copyHealthManagerFields(HealthManager from, HealthManager to)
        {
            if (from == null) { return; }
            foreach (FieldInfo fi in typeof(HealthManager).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name.Contains("Prefab")))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }
        /// <summary>
        /// Copy all Infected Enemy Effects Fields
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void copyInfectedEnemyEffectsFields(InfectedEnemyEffects from, InfectedEnemyEffects to)
        {
            if (from == null) { return; }
            foreach (FieldInfo fi in typeof(InfectedEnemyEffects).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }
        /// <summary>
        /// Copy all Enemy HitEffects Uninfected
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void copyEnemyHitEffectsUninfectedFields(EnemyHitEffectsUninfected from, EnemyHitEffectsUninfected to)
        {
            if (from == null) { return; }
            foreach (FieldInfo fi in typeof(EnemyHitEffectsUninfected).GetFields(BindingFlags.Default | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.CreateInstance | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.IgnoreCase | BindingFlags.IgnoreReturn | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.OptionalParamBinding | BindingFlags.PutDispProperty | BindingFlags.SuppressChangeType | BindingFlags.PutRefDispProperty))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }

        /// <summary>
        /// Copy all Enemy DeathEffects Uninfected
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public static void copyEnemyDeathEffectsUninfectedFields(EnemyDeathEffectsUninfected from, EnemyDeathEffectsUninfected to)
        {
            if (from == null) { return; }
            foreach (FieldInfo fi in typeof(EnemyDeathEffectsUninfected).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }

        /// <summary>
        /// Copy all Enemy prefab fields
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="isHealthManaged">if enemy has a HealthManager</param>
        /// <param name="isInfected">if enemy is infected</param>
        public static void copyEnemyPrefabFields(GameObject from, GameObject to, bool isHealthManaged, bool isInfected)
        {
            /*if(isHealthManaged){
                copyHealthManagerFields(from.GetComponent<HealthManager>(),to.GetAddComponent<HealthManager>());
            }*/
            if (isInfected)
            {
                copyInfectedEnemyEffectsFields(from.GetComponent<InfectedEnemyEffects>(), to.GetAddComponent<InfectedEnemyEffects>());
            }
            else
            {
                copyEnemyHitEffectsUninfectedFields(from.GetComponent<EnemyHitEffectsUninfected>(), to.GetAddComponent<EnemyHitEffectsUninfected>());
                copyEnemyDeathEffectsUninfectedFields(from.GetComponent<EnemyDeathEffectsUninfected>(), to.GetAddComponent<EnemyDeathEffectsUninfected>());
            }
        }

        /// <summary>
        /// Add Hit recoil to an enemy
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="freezeInPlace"></param>
        /// <param name="stopVelocityXWhenRecoilingUp"></param>
        /// <param name="preventRecoilUp"></param>
        /// <param name="recoilSpeedBase"></param>
        /// <param name="recoilDuration"></param>
        public static void addRecoil(this GameObject enemy,
               bool freezeInPlace, bool stopVelocityXWhenRecoilingUp, bool preventRecoilUp, float recoilSpeedBase, float recoilDuration)
        {
            var recoil = enemy.gameObject.GetAddComponent<Recoil>();
            ReflectionHelper.SetField<Recoil, bool>(recoil, "freezeInPlace", freezeInPlace);
            ReflectionHelper.SetField<Recoil, bool>(recoil, "stopVelocityXWhenRecoilingUp", stopVelocityXWhenRecoilingUp);
            ReflectionHelper.SetField<Recoil, bool>(recoil, "preventRecoilUp", preventRecoilUp);
            ReflectionHelper.SetField<Recoil, float>(recoil, "recoilSpeedBase", recoilSpeedBase);
            ReflectionHelper.SetField<Recoil, float>(recoil, "recoilDuration", recoilDuration);
            recoil.enabled = true;
        }

        /// <summary>
        /// Get or Add a HealthManager with given health to the enemy
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="health"></param>
        /// <returns></returns>
        public static HealthManager manageHealth(this GameObject enemy, int health)
        {
            var hm = enemy.gameObject.GetAddComponent<HealthManager>();
            hm.hp = health;
            return hm;
        }
        /// <summary>
        /// Add a DreamNail Dialogue to a CustomEnemy
        /// </summary>
        /// <param name="enemy"></param>
        /// <param name="key"></param>
        /// <param name="Amount"></param>
        /// <returns></returns>
        public static EnemyDreamnailReaction addDreamNailDialogue(this GameObject enemy, string key, int Amount = 1)
        {
            var _dnReaction = enemy.gameObject.GetAddComponent<EnemyDreamnailReaction>();
            _dnReaction.enabled = true;
            _dnReaction.SetConvoTitle(key);
            ReflectionHelper.SetField<EnemyDreamnailReaction, int>(_dnReaction, "convoAmount", Amount);
            return _dnReaction;
        }
        /// <summary>
        /// Disable DreamNail Dialogue for an enemy
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public static EnemyDreamnailReaction disableDreamNailDialogue(this GameObject enemy)
        {
            var _dnReaction = enemy.gameObject.GetAddComponent<EnemyDreamnailReaction>();
            _dnReaction.enabled = false;
            return _dnReaction;
        }


    }
}