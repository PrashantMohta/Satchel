using System;
using System.Collections.Generic;
using System.Linq;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using Logger = Modding.Logger;

namespace Satchel.Futils{

    public static class FsmVariables{
        public static System.Object GetVariables<T>(this PlayMakerFSM fsm) where T : NamedVariable, new(){
            var variables = fsm.FsmVariables;
            var typ = typeof(T);
            if(typ == typeof(FsmFloat)){
                return variables.FloatVariables;
            }
            if(typ == typeof(FsmInt)){
                return variables.IntVariables;
            }
            if(typ == typeof(FsmBool)){
                return variables.BoolVariables;
            }
            if(typ == typeof(FsmString)){
                return variables.StringVariables;
            }
            if(typ == typeof(FsmVector2)){
                return variables.Vector2Variables;
            }
            if(typ == typeof(FsmVector3)){
                return variables.Vector3Variables;
            }
            if(typ == typeof(FsmColor)){
                return variables.ColorVariables;
            }
            if(typ == typeof(FsmRect)){
                return variables.RectVariables;
            }
            if(typ == typeof(FsmQuaternion)){
                return variables.QuaternionVariables;
            }
            if(typ == typeof(FsmGameObject)){
                return variables.GameObjectVariables;
            }
            return null;
        }
        public static void AddVariable<T>(this PlayMakerFSM fsm, string name)  where T : NamedVariable, new() {
            T[] VariableArray = (T[])fsm.GetVariables<T>();
            if(VariableArray == null){ return;}
            List<T> tempList = new List<T>(VariableArray);
            tempList.Add(new T(){Name = name});
            VariableArray = tempList.ToArray();
        }
        public static T GetVariable<T>(this PlayMakerFSM fsm, string name) where T : NamedVariable, new(){
            T[] VariableArray = (T[])fsm.GetVariables<T>();
            if(VariableArray == null){ return null;}
            return Array.Find(VariableArray,x => x.Name == name);
        }

    }
}