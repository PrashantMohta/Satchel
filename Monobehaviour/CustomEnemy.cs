using Modding;
using static Modding.Logger;
using UnityEngine;
using System.Collections;

namespace DandyCore{
    public class CustomEnemy : MonoBehaviour{
        public DamageHero dh;
        public Rigidbody2D rb;
        public IHitEffectReciever hitEffects;

        public SpriteRenderer sr;

        void Start(){
            if(sr == null){
                sr = GetComponent<SpriteRenderer>();
            }
            if(dh == null){
                var dhm = gameObject.GetComponent<CustomEnemyMarker>();
                dh = gameObject.AddComponent<DamageHero>();
                dh.damageDealt = dhm.damageDealt;
                dh.hazardType = dhm.hazardType;
                dh.shadowDashHazard = dhm.shadowDashHazard;
                dh.resetOnEnable = dhm.resetOnEnable;
            }
            if(rb == null){
                rb = gameObject.GetComponent<Rigidbody2D>();
            }
            if(hitEffects == null){
                hitEffects = gameObject.GetComponent<InfectedEnemyEffects>();
            }
            if(hitEffects == null){
                hitEffects = gameObject.GetComponent<EnemyHitEffectsUninfected>();
            }

            On.InfectedEnemyEffects.RecieveHitEffect   += ReceiveHit;
            On.EnemyHitEffectsUninfected.RecieveHitEffect += ReceiveHit;
            On.HealthManager.TakeDamage += OnHealthManagerTakeDamage;

        }
        private Coroutine _flashRoutine;
        public void FlashWhite(float time)
        {
            IEnumerator Flash()
            {
                float flashAmount = 1.0f;
                Material material = sr.material;
                while (flashAmount > 0)
                {
                    material.SetFloat("_FlashAmount", flashAmount);
                    flashAmount -= 0.01f;
                    yield return new WaitForSeconds(0.01f * time);
                }
                yield return null;
            }
            
            if (_flashRoutine != null) StopCoroutine(_flashRoutine);
            _flashRoutine = StartCoroutine(Flash());
        }

         private void OnHealthManagerTakeDamage(On.HealthManager.orig_TakeDamage orig, HealthManager self, HitInstance hitInstance)
        {

            //if names match then do our custom stuff     
            if (self.name == gameObject.name && hitEffects != null)
            {
                hitEffects.RecieveHitEffect(hitInstance.Direction);
                //if (self.hp >= HP_PHASE2){}   
            }
            orig(self, hitInstance);
        }

        private void ReceiveHit(On.InfectedEnemyEffects.orig_RecieveHitEffect orig, InfectedEnemyEffects self, float attack_direction)
        {
            //do orig stuff
            orig(self,attack_direction);
            //if names match then do our custom stuff
            if (self.name != gameObject.name) { return; }
            Log("flashing sprite");
            FlashWhite(0.1f);
        }
        private void ReceiveHit(On.EnemyHitEffectsUninfected.orig_RecieveHitEffect orig, EnemyHitEffectsUninfected self, float attack_direction)
        {
            //do orig stuff
            orig(self,attack_direction);
            // return
            //if names match then do our custom stuff
            if (self.name != gameObject.name) { return; }
            Log("flashing sprite");
            FlashWhite(0.1f);
        }

        private void OnDestroy()
        {
            On.InfectedEnemyEffects.RecieveHitEffect -= ReceiveHit;
            On.EnemyHitEffectsUninfected.RecieveHitEffect -= ReceiveHit;
            On.HealthManager.TakeDamage -= OnHealthManagerTakeDamage;

        }

    }
}