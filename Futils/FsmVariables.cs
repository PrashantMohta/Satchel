using System;
using System.Collections.Generic;
using System.Linq;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using Logger = Modding.Logger;

namespace Satchel.Futils{

    public static class FsmVariables{
        public static NamedVariable[] GetVariables<T>(this PlayMakerFSM fsm) where T : NamedVariable, new(){
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
        public static void SetVariables<T>(this PlayMakerFSM fsm,NamedVariable[] namedVariables) where T : NamedVariable, new(){
            var variables = fsm.FsmVariables;
            var typ = typeof(T);
            if(typ == typeof(FsmFloat)){
                variables.FloatVariables = (FsmFloat[])namedVariables;
            }
            if(typ == typeof(FsmInt)){
                variables.IntVariables = (FsmInt[])namedVariables;
            }
            if(typ == typeof(FsmBool)){
                variables.BoolVariables = (FsmBool[])namedVariables;
            }
            if(typ == typeof(FsmString)){
                variables.StringVariables = (FsmString[])namedVariables;
            }
            if(typ == typeof(FsmVector2)){
                variables.Vector2Variables = (FsmVector2[])namedVariables;
            }
            if(typ == typeof(FsmVector3)){
                variables.Vector3Variables = (FsmVector3[])namedVariables;
            }
            if(typ == typeof(FsmColor)){
                variables.ColorVariables = (FsmColor[])namedVariables;
            }
            if(typ == typeof(FsmRect)){
                variables.RectVariables = (FsmRect[])namedVariables;
            }
            if(typ == typeof(FsmQuaternion)){
                variables.QuaternionVariables = (FsmQuaternion[])namedVariables;
            }
            if(typ == typeof(FsmGameObject)){
                variables.GameObjectVariables = (FsmGameObject[])namedVariables;
            }
        }
        public static void AddVariable<T>(this PlayMakerFSM fsm, string name)  where T : NamedVariable, new() {
            AddGetVariable<T>(fsm,name);
        }
        
        public static T AddGetVariable<T>(this PlayMakerFSM fsm, string name)  where T : NamedVariable, new() {
            T[] VariableArray = (T[])fsm.GetVariables<T>();
            if(VariableArray == null){ return null;}
            List<T> tempList = new List<T>(VariableArray);
            T newVar = new T(){Name = name};
            tempList.Add(newVar);
            fsm.SetVariables<T>(tempList.ToArray());
            return newVar;
        }
        public static T GetVariable<T>(this PlayMakerFSM fsm, string name) where T : NamedVariable, new(){
            T[] VariableArray = (T[])fsm.GetVariables<T>();
            if(VariableArray == null){ return null;}
            return Array.Find(VariableArray,x => x.Name == name);
        }

    }
}