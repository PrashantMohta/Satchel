using System.Linq;
using System.Reflection;
namespace Satchel
{
    public class Convo {
        public static string prefix = "dc_custom_dn_";
        public string Id;
        public string Key;
        public int Amount = 0;

        public Convo(string convId){
            this.Id=convId;
            this.Key = Convo.prefix + this.Id;

        }
    }
    public static class EnemyUtils{
    
        public static GameObject createCompanionFromPrefab(this GameObject CompanionPrefab){
                return CompanionPrefab.createCompanionFromPrefab(false);
        }        
        public static GameObject createCompanionFromPrefab(this GameObject CompanionPrefab,bool DestroyOnLoad = false){
            GameObject Companion = GameObject.Instantiate(CompanionPrefab);
            Companion.name = "Companion";
            Companion.layer = 18;
            Companion.DisableChildren();
            Companion.SetActive(false);
            // remove extra things that the prefab might have
            while(Companion.RemoveComponent<PlayMakerFSM>()){};
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
            if(!DestroyOnLoad){
                UnityEngine.Object.DontDestroyOnLoad(Companion);
            }
            return Companion;
        }

        public static GameObject createCustomDialogFromPrefab(this GameObject prefab){
            GameObject dialog = GameObject.Instantiate(prefab);
            dialog.name = "CustomDialog";
            dialog.SetActive(false);
            // remove extra things that the prefab might have
            var fsms = dialog.GetComponents<PlayMakerFSM>();
            foreach(var fsm in fsms){
                if(fsm.FsmName != "Conversation Control"){
                    GameObject.DestroyImmediate(fsm);
                }
            }
            dialog.RemoveComponent<PlayMakerUnity2DProxy>();
            dialog.RemoveComponent<PlayMakerFixedUpdate>();
            UnityEngine.Object.DontDestroyOnLoad(dialog);
            return dialog;
        }

        public static void activateAlertRanges(this GameObject enemy){
            foreach(var arm in enemy.GetComponentsInChildren<AlertRangeMarker>(true)){
                arm.gameObject.AddComponent<AlertRange>();
            }
        }

        public static WaitForSeconds moveTowards(this Rigidbody2D rb,Vector2 direction,float distance,float time){
            var speed = distance/time;
            var velocity = direction.normalized*speed;
            rb.velocity = velocity;
            return new WaitForSeconds(time);
        }

        public static void copyHealthManagerFields(HealthManager from,HealthManager to){
            if(from == null) {return;}
            foreach (FieldInfo fi in typeof(HealthManager).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name.Contains("Prefab")))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }
        public static void copyInfectedEnemyEffectsFields(InfectedEnemyEffects from,InfectedEnemyEffects to){
            if(from == null) {return;}
            foreach (FieldInfo fi in typeof(InfectedEnemyEffects).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }
        public static void copyEnemyHitEffectsUninfectedFields(EnemyHitEffectsUninfected from,EnemyHitEffectsUninfected to){
            if(from == null) {return;}
            foreach (FieldInfo fi in typeof(EnemyHitEffectsUninfected).GetFields(BindingFlags.Default | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.CreateInstance | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.IgnoreCase | BindingFlags.IgnoreReturn | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.OptionalParamBinding | BindingFlags.PutDispProperty | BindingFlags.SuppressChangeType | BindingFlags.PutRefDispProperty))
            {
                fi.SetValue(to, fi.GetValue(from));
            }  
            to.enabled = true;
        }
        public static void copyEnemyDeathEffectsUninfectedFields(EnemyDeathEffectsUninfected from,EnemyDeathEffectsUninfected to){
            if(from == null) {return;}
            foreach (FieldInfo fi in typeof(EnemyDeathEffectsUninfected).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Default | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                fi.SetValue(to, fi.GetValue(from));
            }
            to.enabled = true;
        }
        public static void copyEnemyPrefabFields(GameObject from,GameObject to,bool isHealthManaged, bool isInfected){
            /*if(isHealthManaged){
                copyHealthManagerFields(from.GetComponent<HealthManager>(),to.GetAddComponent<HealthManager>());
            }*/
            if(isInfected){
                copyInfectedEnemyEffectsFields(from.GetComponent<InfectedEnemyEffects>(),to.GetAddComponent<InfectedEnemyEffects>());
            } else {
                copyEnemyHitEffectsUninfectedFields(from.GetComponent<EnemyHitEffectsUninfected>(),to.GetAddComponent<EnemyHitEffectsUninfected>());
                copyEnemyDeathEffectsUninfectedFields(from.GetComponent<EnemyDeathEffectsUninfected>(),to.GetAddComponent<EnemyDeathEffectsUninfected>());
            }
        }
    
        public static void addRecoil(this GameObject enemy,
               bool freezeInPlace, bool stopVelocityXWhenRecoilingUp, bool preventRecoilUp,float recoilSpeedBase,float recoilDuration){
               var recoil = enemy.gameObject.GetAddComponent<Recoil>();
               ReflectionHelper.SetField<Recoil,bool>(recoil,"freezeInPlace", freezeInPlace);
               ReflectionHelper.SetField<Recoil,bool>(recoil,"stopVelocityXWhenRecoilingUp", stopVelocityXWhenRecoilingUp);
               ReflectionHelper.SetField<Recoil,bool>(recoil,"preventRecoilUp", preventRecoilUp);
               ReflectionHelper.SetField<Recoil,float>(recoil,"recoilSpeedBase", recoilSpeedBase);
               ReflectionHelper.SetField<Recoil,float>(recoil,"recoilDuration", recoilDuration);
               recoil.enabled = true;
        }

        public static HealthManager manageHealth(this GameObject enemy,int health){
               var hm = enemy.gameObject.GetAddComponent<HealthManager>();
               hm.hp = health;
               return hm;
        }
        public static EnemyDreamnailReaction addDreamNailDialogue(this GameObject enemy,string key , int Amount = 1){
            var _dnReaction = enemy.gameObject.GetAddComponent<EnemyDreamnailReaction>();
            _dnReaction.enabled = true;
            _dnReaction.SetConvoTitle(key);
            ReflectionHelper.SetField<EnemyDreamnailReaction,int>(_dnReaction,"convoAmount", Amount);
            return _dnReaction;
        }

        public static EnemyDreamnailReaction disableDreamNailDialogue(this GameObject enemy){
            var _dnReaction = enemy.gameObject.GetAddComponent<EnemyDreamnailReaction>();
            _dnReaction.enabled = false;
            return _dnReaction;
        }
    
    
    }
}