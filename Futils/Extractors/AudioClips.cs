using System;
using System.Collections.Generic;
using System.Linq;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using UnityEngine;
using Logger = Modding.Logger;

namespace Satchel.Futils.Extractors{
    public static class AudioClips{
        public static Dictionary<string,AudioClip> GetAudioClips(this PlayMakerFSM self){
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