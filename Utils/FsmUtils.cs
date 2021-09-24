using System;
using System.Collections.Generic;
using System.Linq;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using Logger = Modding.Logger;

namespace Satchel
{
    public class ActionArg
    {
        public GameObject go;
        public HutongGames.PlayMaker.FsmString fsmString;
    }
    public class ActionAction<Targ> : FsmStateAction
    {
        public Action<Targ> action;
        public Targ arg;

        public override void Reset()
        {
            action = null;

            base.Reset();
        }

        public override void OnEnter()
        {
            if (action != null) action.Invoke(arg);
            Finish();
        }
    }

    public class MethodAction : FsmStateAction
    {
        public Action method;

        public override void Reset()
        {
            method = null;

            base.Reset();
        }

        public override void OnEnter()
        {
            if (method != null) method.Invoke();
            Finish();
        }
    }
    public static class FsmUtil
    {
        public static FsmState AddFsmState(this PlayMakerFSM fsm, string stateName)
        {
            var states = fsm.Fsm.States.ToList();
            var ret = new FsmState(fsm.Fsm);
            states.Add(ret);
            fsm.Fsm.States = states.ToArray();
            return ret;
        }

        public static FsmEvent AddTransition(this PlayMakerFSM fsm, string stateName, string eventName, string toState)
        {
            var state = fsm.Fsm.GetState(stateName);
            var list = state.Transitions.ToList();
            var ret = FsmEvent.GetFsmEvent(eventName);
            list.Add(new FsmTransition
            {
                ToState = toState,
                ToFsmState = fsm.GetState(toState),
                FsmEvent = ret
            });
            state.Transitions = list.ToArray();
            return ret;
        }

        public static FsmEvent AddGlobalTransition(this PlayMakerFSM fsm, string globalEventName, string toState)
        {
            List<FsmTransition> tmpFsmGlobalTransitions = new List<FsmTransition>(fsm.Fsm.GlobalTransitions);
            var ret = new FsmEvent(globalEventName) { IsGlobal = true };
            tmpFsmGlobalTransitions.Add(new FsmTransition
            {
                ToState = toState,
                ToFsmState = fsm.GetState(toState),
                FsmEvent = ret
            });
            fsm.Fsm.GlobalTransitions = tmpFsmGlobalTransitions.ToArray();
            return ret;
        }

        public static void ChangeTransition(this PlayMakerFSM fsm, string stateName, string eventName, string toState)
        {
            var state = fsm.Fsm.GetState(stateName);
            var transition = state.Transitions.First(t => t.EventName.Equals(eventName));
            transition.ToState = toState;
            transition.ToFsmState = fsm.GetState(toState);
        }

        public static FsmState GetState(this PlayMakerFSM fsm, string stateName)
        {
            return fsm.Fsm.GetState(stateName);
        }

        public static FsmState CopyState(this PlayMakerFSM fsm, string fromState, string toState)
        {
            FsmState copy = new FsmState(fsm.Fsm.GetState(fromState))
            {
                Name = toState
            };
            foreach (var t in copy.Transitions)
            {
                t.ToFsmState = fsm.GetState(t.ToState);
            }
            List<FsmState> tmpList = new List<FsmState>(fsm.FsmStates);
            tmpList.Add(copy);
            fsm.Fsm.States = tmpList.ToArray();
            return copy;
        }

        public static TAction GetAction<TAction>(this PlayMakerFSM self, string state, int index)
            where TAction : FsmStateAction
        {
            return (TAction) self.FsmStates.First(s => s.Name.Equals(state)).Actions[index];
        }

        public static void AddAction(this PlayMakerFSM self, string state, FsmStateAction action)
        {
            FsmState fsmState = self.FsmStates.First(s => s.Name.Equals(state));
            List<FsmStateAction> actions = new List<FsmStateAction>(fsmState.Actions);
            actions.Add(action);
            fsmState.Actions = actions.ToArray();
        }

        public static void InsertAction(this PlayMakerFSM self, string state, FsmStateAction action, int index)
        {
            FsmState fsmState = self.FsmStates.First(s => s.Name.Equals(state));
            List<FsmStateAction> actions = new List<FsmStateAction>(fsmState.Actions);
            actions.Insert(index, action);
            fsmState.Actions = actions.ToArray();
        }

        public static void RemoveAction(this PlayMakerFSM self, string state, int index)
        {
            FsmState fsmState = self.FsmStates.First(s => s.Name.Equals(state));
            List<FsmStateAction> actions = new List<FsmStateAction>(fsmState.Actions);
            actions.RemoveAt(index);
            fsmState.Actions = actions.ToArray();
        }

        public static void AddMethod(this PlayMakerFSM self, string state, Action method)
        {
            self.AddAction(state, new MethodAction() { method = method });
        }

        public static void InsertMethod(this PlayMakerFSM self, string state, Action method, int index)
        {
            self.InsertAction(state, new MethodAction() { method = method }, index);
        }

        public static void AddFloatVariable(this PlayMakerFSM self, string name)
        {
            List<FsmFloat> tmpFloats = new List<FsmFloat>(self.FsmVariables.FloatVariables);
            tmpFloats.Add(new FsmFloat(name));
            self.FsmVariables.FloatVariables = tmpFloats.ToArray();
        }
        public static void AddIntVariable(this PlayMakerFSM self, string name)
        {
            List<FsmInt> tmpInts = new List<FsmInt>(self.FsmVariables.IntVariables);
            tmpInts.Add(new FsmInt(name));
            self.FsmVariables.IntVariables = tmpInts.ToArray();
        }
        public static void AddBoolVariable(this PlayMakerFSM self, string name)
        {
            List<FsmBool> tmpBools = new List<FsmBool>(self.FsmVariables.BoolVariables);
            tmpBools.Add(new FsmBool(name));
            self.FsmVariables.BoolVariables = tmpBools.ToArray();
        }
        public static void AddStringVariable(this PlayMakerFSM self, string name)
        {
            List<FsmString> tmpStrings = new List<FsmString>(self.FsmVariables.StringVariables);
            tmpStrings.Add(new FsmString(name));
            self.FsmVariables.StringVariables = tmpStrings.ToArray();
        }
        public static void AddVector2Variable(this PlayMakerFSM self, string name)
        {
            List<FsmVector2> tmpVector2s = new List<FsmVector2>(self.FsmVariables.Vector2Variables);
            tmpVector2s.Add(new FsmVector2(name));
            self.FsmVariables.Vector2Variables = tmpVector2s.ToArray();
        }
        public static void AddVector3Variable(this PlayMakerFSM self, string name)
        {
            List<FsmVector3> tmpVector3s = new List<FsmVector3>(self.FsmVariables.Vector3Variables);
            tmpVector3s.Add(new FsmVector3(name));
            self.FsmVariables.Vector3Variables = tmpVector3s.ToArray();
        }
        public static void AddColorVariable(this PlayMakerFSM self, string name)
        {
            List<FsmColor> tmpColors = new List<FsmColor>(self.FsmVariables.ColorVariables);
            tmpColors.Add(new FsmColor(name));
            self.FsmVariables.ColorVariables = tmpColors.ToArray();
        }
        public static void AddRectVariable(this PlayMakerFSM self, string name)
        {
            List<FsmRect> tmpRects = new List<FsmRect>(self.FsmVariables.RectVariables);
            tmpRects.Add(new FsmRect(name));
            self.FsmVariables.RectVariables = tmpRects.ToArray();
        }
        public static void AddQuaternionVariable(this PlayMakerFSM self, string name)
        {
            List<FsmQuaternion> tmpQuaternions = new List<FsmQuaternion>(self.FsmVariables.QuaternionVariables);
            tmpQuaternions.Add(new FsmQuaternion(name));
            self.FsmVariables.QuaternionVariables = tmpQuaternions.ToArray();
        }
        public static void AddGameObjectVariable(this PlayMakerFSM self, string name)
        {
            List<FsmGameObject> tmpGameObjects = new List<FsmGameObject>(self.FsmVariables.GameObjectVariables);
            tmpGameObjects.Add(new FsmGameObject(name));
            self.FsmVariables.GameObjectVariables = tmpGameObjects.ToArray();
        }

        public static Dictionary<string,AudioClip> getAudioClips(this PlayMakerFSM self){
            Dictionary<string,AudioClip> ac = new Dictionary<string,AudioClip>();
            foreach (var state in self.FsmStates)
            {
                foreach(var action in state.Actions){
                    Type t = action.GetType();
                    if (action is AudioPlay){
                        AudioPlay a = (AudioPlay) action;
                        var clip = a.oneShotClip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } else if(action is AudioPlayerOneShot){
                        AudioPlayerOneShot a = (AudioPlayerOneShot) action;
                        foreach( var clip in a.audioClips){
                            ac[clip.name]=clip;
                        }
                    }  else if(action is AudioPlayerOneShotSingle){
                        AudioPlayerOneShotSingle a = (AudioPlayerOneShotSingle) action;
                        var clip = a.audioClip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } else if (action is AudioPlayRandom){
                        AudioPlayRandom a = (AudioPlayRandom) action;
                        foreach( var clip in a.audioClips){
                            ac[clip.name]=clip;
                        }
                    } else if (action is AudioPlayRandomSingle){
                        AudioPlayRandomSingle a = (AudioPlayRandomSingle) action;
                        var clip = a.audioClip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } else if (action is AudioPlaySimple){
                        AudioPlaySimple a = (AudioPlaySimple) action;
                        var clip = a.oneShotClip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } else if (action is AudioPlayV2){
                        AudioPlayV2 a = (AudioPlayV2) action;
                        var clip = a.oneShotClip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } else if (action is PlayRandomSound){
                        PlayRandomSound a = (PlayRandomSound) action;
                        foreach( var clip in a.audioClips){
                            ac[clip.name]=clip;
                        }
                    } else if (action is PlaySound){
                        PlaySound a = (PlaySound) action;
                        var clip = a.clip.Value as AudioClip;
                        ac[clip.name]=clip;
                    } 
                }
            }
            return ac;
        }
    }
}