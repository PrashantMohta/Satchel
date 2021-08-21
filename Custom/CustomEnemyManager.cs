using System;
using System.Collections;
using System.Collections.Generic;

using Modding;
using static Modding.Logger;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DandyCore{
    public class CustomEnemyManager{
        private GameObject defaultInfectedEnemyPrefab;
        private GameObject defaultUnInfectedEnemyPrefab;
        private List<GameObject> customEnemies = new List<GameObject>();
        private List<Action<List<GameObject>>> enemyCreatedCallbacks = new List<Action<List<GameObject>>>();
        public CustomEnemyManager(){
            UnityEngine.SceneManagement.SceneManager.activeSceneChanged += OnSceneChanged;
        }

        //provide default configs
        public void Setup(GameObject InfectedEnemyPrefab,GameObject UnInfectedEnemyPrefab){
            if(InfectedEnemyPrefab != null){
                defaultInfectedEnemyPrefab = InfectedEnemyPrefab;
            }
            if(UnInfectedEnemyPrefab != null){
                defaultUnInfectedEnemyPrefab = UnInfectedEnemyPrefab;
            }
        }
        public void AddCallbackForNewEnemies(Action<List<GameObject>> callback){
            enemyCreatedCallbacks.Add(callback);
        }
        //Make a gameObject into Enemy based on config
        // Go , HM , config to set values into HM
        public GameObject Add(){ return null; }

        public void OnSceneChanged(Scene from, Scene to){
            customEnemies = new List<GameObject>();
            foreach(CustomEnemyMarker enemy in GameObject.FindObjectsOfType<CustomEnemyMarker>())
            {  
               if(enemy == null && enemy.gameObject == null) {continue;}
               // process an enemy only once
               if(enemy.isProcessed()) {continue;}
               enemy.setProcessed();

               customEnemies.Add(enemy.gameObject);               
               enemy.gameObject.AddComponent<CustomEnemy>();
               enemy.gameObject.activateAlertRanges();
               if(enemy.manageHealth){
                    if(enemy.hasRecoil) {
                        enemy.gameObject.addRecoil(
                            enemy.freezeInPlace,
                            enemy.stopVelocityXWhenRecoilingUp,
                            enemy.preventRecoilUp,
                            enemy.recoilSpeedBase,
                            enemy.recoilDuration);    
                    }
                    
                    if(enemy.isInfected){
                        EnemyUtils.copyHealthManagerFields(defaultInfectedEnemyPrefab.GetComponent<HealthManager>(),enemy.gameObject.GetAddComponent<HealthManager>());
                        if(enemy.showHiteffects){   
                            EnemyUtils.copyEnemyPrefabFields(defaultInfectedEnemyPrefab,enemy.gameObject,enemy.manageHealth,enemy.isInfected);
                        }
                    } else {
                        EnemyUtils.copyHealthManagerFields(defaultUnInfectedEnemyPrefab.GetComponent<HealthManager>(),enemy.gameObject.GetAddComponent<HealthManager>());
                        if(enemy.showHiteffects){   
                            EnemyUtils.copyEnemyPrefabFields(defaultUnInfectedEnemyPrefab,enemy.gameObject,enemy.manageHealth,enemy.isInfected);
                        }
                    }

                    var hm = enemy.gameObject.manageHealth(enemy.initialHp);
                    hm.OnDeath += ()=>{
                        // make it a corpse
                        enemy.gameObject.layer = 26;
                    };

                }
                SpriteRenderer Sr = enemy.gameObject.GetComponent<SpriteRenderer>();
                if(Sr != null){
                    Sr.material = new Material(Core.spriteFlash);
                }
                
            }
            if(customEnemies.Count > 0){
                foreach(var callback in enemyCreatedCallbacks){
                    callback(customEnemies);
                }
            }

        }
    }
}