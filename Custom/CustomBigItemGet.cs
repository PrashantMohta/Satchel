using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

using Modding;
using static Modding.Logger;
using UnityEngine;
using Satchel.Futils;
using InControl;

namespace Satchel{
    public static class CustomBigItemGet {
        public static GameObject MsgUiPrefab;
        public static void Prepare(GameObject ShinyPrefab){
           var fsm = ShinyPrefab.LocateMyFSM("Shiny Control");
           MsgUiPrefab = fsm.GetAction<CreateUIMsgGetItem>("Walljump",3).gameObject.Value;
        }
        public static void ShowDialog(
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