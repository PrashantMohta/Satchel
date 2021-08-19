using UnityEngine;
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Modding;
namespace DandyCore{
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
    
        /*public static void enableCustomEnemies(){ 
            foreach(CustomEnemyMarker enemy in GameObject.FindObjectsOfType<CustomEnemyMarker>())
            {    
               enemy.gameObject.AddComponent<CustomEnemy>();
            }
        }*/

        /*private void OnCollisionEnter2D(Collider2D other)
        {   
            Vector2 force = transform.position - other.transform.position;
            force.Normalize();
            rb.AddForce(-force*30);
        }*/
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
               ReflectionHelper.SetAttr<Recoil,bool>(recoil,"freezeInPlace", freezeInPlace);
               ReflectionHelper.SetAttr<Recoil,bool>(recoil,"stopVelocityXWhenRecoilingUp", stopVelocityXWhenRecoilingUp);
               ReflectionHelper.SetAttr<Recoil,bool>(recoil,"preventRecoilUp", preventRecoilUp);
               ReflectionHelper.SetAttr<Recoil,float>(recoil,"recoilSpeedBase", recoilSpeedBase);
               ReflectionHelper.SetAttr<Recoil,float>(recoil,"recoilDuration", recoilDuration);
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
            ReflectionHelper.SetAttr<EnemyDreamnailReaction,int>(_dnReaction,"convoAmount", Amount);
            return _dnReaction;
        }

        public static EnemyDreamnailReaction disableDreamNailDialogue(this GameObject enemy){
            var _dnReaction = enemy.gameObject.GetAddComponent<EnemyDreamnailReaction>();
            _dnReaction.enabled = false;
            return _dnReaction;
        }
    
    
    }
}