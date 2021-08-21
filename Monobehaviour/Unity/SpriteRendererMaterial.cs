using static Modding.Logger;
using System;
using UnityEngine;

namespace DandyCore{
    public class SpriteRendererMaterial : MonoBehaviour {

        public bool enableFlash = false;

        void Awake () {
            SpriteRenderer Sr = GetComponent<SpriteRenderer>();
            if(Sr != null){
                Shader shader = null;
                if(enableFlash){
                    shader = Core.spriteFlash;
                } else {
                    shader = Shader.Find("Sprites/Default");
                }
                Sr.material = new Material(shader);
            }
        }
        
    }
}
