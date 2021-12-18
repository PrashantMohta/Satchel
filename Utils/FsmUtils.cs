using System;
using System.Collections.Generic;
using System.Linq;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using Logger = Modding.Logger;
using Satchel.Futils;
using Satchel.Futils.Extractors;

namespace Satchel
{
    
    [Obsolete("Satchel.MethodAction is deprecated, please use Satchel.Futils.CustomFsmAction instead.")]
    public class MethodAction : CustomFsmAction{}   
    [Obsolete("Satchel.FsmUtil is deprecated, please use Satchel.Futils.* instead.")]
    public static class FsmUtil
    {
        [Obsolete("Satchel.FsmUtil.AddFsmState is deprecated, please use Satchel.Futils.Fsm.AddState instead.")]
        public static FsmState AddFsmState(PlayMakerFSM fsm, string stateName)
        {
            return Futils.Fsm.AddState(fsm,stateName);
        }

        [Obsolete("Satchel.FsmUtil.GetState is deprecated, please use Satchel.Futils.Fsm.GetState instead.")]
        public static FsmState GetState(PlayMakerFSM fsm, string stateName)
        {
            return Futils.Fsm.GetState(fsm,stateName);
        }

        [Obsolete("Satchel.FsmUtil.CopyState is deprecated, please use Satchel.Futils.Fsm.CopyState instead.")]
        public static FsmState CopyState(PlayMakerFSM fsm, string fromState, string toState)
        {
            return Futils.Fsm.CopyState(fsm,fromState,toState);
        }

        [Obsolete("Satchel.FsmUtil.AddTransition is deprecated, please use Satchel.Futils.Fsm.AddTransition instead.")]
        public static FsmEvent AddTransition(PlayMakerFSM fsm, string stateName, string eventName, string toState)
        {
            Futils.Fsm.AddTransition(fsm,stateName,eventName,toState);
            return null;
        }

        [Obsolete("Satchel.FsmUtil.ChangeTransition is deprecated, please use Satchel.Futils.Fsm.ChangeTransition instead.")]
        public static void ChangeTransition(PlayMakerFSM fsm, string stateName, string eventName, string toState)
        {
            Futils.Fsm.ChangeTransition(fsm,stateName,eventName,toState);
        }

        [Obsolete("Satchel.FsmUtil.AddGlobalTransition is deprecated, please use Satchel.Futils.Fsm.AddGlobalTransition instead.")]
        public static FsmEvent AddGlobalTransition(PlayMakerFSM fsm, string globalEventName, string toState)
        {
            Futils.Fsm.AddGlobalTransition(fsm, globalEventName, toState);
            return null;
        }
        
        [Obsolete("Satchel.FsmUtil.GetAction is deprecated, please use Satchel.Futils.Fsm.GetAction instead.")]
        public static TAction GetAction<TAction>(PlayMakerFSM self, string state, int index) where TAction : FsmStateAction
        {
            return Futils.Fsm.GetAction(self,state,index) as TAction;
        }
        [Obsolete("Satchel.FsmUtil.GetAction is deprecated, please use Satchel.Futils.Fsm.GetAction instead.")]
        public static FsmStateAction GetAction(PlayMakerFSM self, string state, int index)
        {
            return Futils.Fsm.GetAction(self,state,index);
        }
        
        [Obsolete("Satchel.FsmUtil.AddAction is deprecated, please use Satchel.Futils.Fsm.AddAction instead.")]
        public static void AddAction(PlayMakerFSM self, string state, FsmStateAction action)
        {
            Futils.Fsm.AddAction(self,state,action);
        }
        [Obsolete("Satchel.FsmUtil.InsertAction is deprecated, please use Satchel.Futils.Fsm.InsertAction instead.")]
        public static void InsertAction(PlayMakerFSM self, string state, FsmStateAction action, int index)
        {
            Futils.Fsm.InsertAction(self,state,action,index);
        }

        [Obsolete("Satchel.FsmUtil.RemoveAction is deprecated, please use Satchel.Futils.Fsm.RemoveAction instead.")]
        public static void RemoveAction(PlayMakerFSM self, string state, int index)
        {
            Futils.Fsm.RemoveAction(self,state,index);
        }
        
        [Obsolete("Satchel.FsmUtil.AddMethod is deprecated, please use Satchel.Futils.Fsm.AddCustomAction instead.")]
        public static void AddMethod(PlayMakerFSM self, string state, Action method)
        {
            Futils.Fsm.AddCustomAction(self,state, method );
        }
        [Obsolete("Satchel.FsmUtil.InsertMethod is deprecated, please use Satchel.Futils.Fsm.InsertCustomAction instead.")]
        public static void InsertMethod(PlayMakerFSM self, string state, Action method, int index)
        {
            Futils.Fsm.InsertCustomAction(self,state, method,index);
        }


        [Obsolete("Satchel.FsmUtil.getAudioClips is deprecated, please use Satchel.Futils.Extractors.GetAudioClips instead.")]
        public static Dictionary<string,AudioClip> getAudioClips(PlayMakerFSM self){
            return self.GetAudioClips();
        }
    }
}