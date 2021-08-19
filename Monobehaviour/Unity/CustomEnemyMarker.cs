using Modding;
using UnityEngine;
using System.Collections;


namespace DandyCore{
    public class CustomEnemyMarker : MonoBehaviour{
        //this script just marks the go as one to add a custom enemy to

        // damage hero
        public int damageDealt = 1;
        public int hazardType = 1;
        public bool shadowDashHazard;
        public bool resetOnEnable;

        // manage health
        public bool manageHealth = true;
        public int initialHp = 100;

        // hit effects 
        public bool showHiteffects = false;
        public bool isInfected = false;

        // recoil
        public bool hasRecoil = false;
        public bool freezeInPlace = false ,stopVelocityXWhenRecoilingUp  = false ,preventRecoilUp  = false ;
        public float recoilSpeedBase = 15f ,recoilDuration = 0.1f;

        // dont show in editer
        private bool processed = false;

        public bool isProcessed(){
            return processed;
        }
        public void setProcessed(){
            processed = true;
        }
    
    }
}