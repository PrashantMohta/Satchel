using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Modding;
using static Modding.Logger;
using UnityEngine;

namespace Satchel{
    public class CustomAnimationFrames : MonoBehaviour {
        public Dictionary<string,Dictionary<int,Sprite>> customClips = new Dictionary<string,Dictionary<int,Sprite>>();
        public Animator anim;
        private SpriteRenderer sr;
        public bool dump;
        public string dumpPath;
        public string dumpingClip = "";
        public List<int> dumpedFrames;
        private void Awake()
        {
            sr = GetComponent<SpriteRenderer>();
            anim = GetComponent<Animator>();
        }
        public void Add(string clip,int frame,Sprite s){
            if(!customClips.TryGetValue(clip, out var data)){
                customClips[clip] = new Dictionary<int,Sprite>();
            }
            customClips[clip][frame] = s;
        }
        private void LateUpdate(){
            var currentClipName = anim.GetClipName();
            var currentFrame = anim.GetCurrentFrame();
            if(dump){
                if(dumpingClip != currentClipName){
                    dumpedFrames = new List<int>();
                }
                if(!dumpedFrames.Contains(currentFrame)){
                    dumpedFrames.Add(currentFrame);
                    var path = Path.Combine(dumpPath, gameObject.GetName(true));
                    var fileName = $"{currentClipName}.{currentFrame}.png";
                    if(!Directory.Exists(path)){
                        Directory.CreateDirectory(path);
                    }
                    var filePath = Path.Combine(path,fileName);
                    if(!File.Exists(filePath)){
                        var texture = SpriteUtils.ExtractTextureFromSprite(sr.sprite);
                        TextureUtils.WriteTextureToFile(texture,filePath);
                    }
                }
                return;
            }
            if(anim != null){
               if(customClips.TryGetValue(currentClipName,out var frames)){
                   try{
                        sr.sprite = frames[currentFrame];
                   } catch (Exception e){
                       Log(e.ToString());
                   }
               } else {
                   Log($"Unable to find clip {currentClipName} in Animator for {gameObject.name}");
               }
            }
        }
        private void OnDestroy()
        {
        }

    }
}