using static Modding.Logger;
using System;
using UnityEngine;

namespace DandyCore{
    public class SpriteRendererMaterial : MonoBehaviour {

        public bool enableFlash = true;

        void Awake () {
            SpriteRenderer Sr = GetComponent<SpriteRenderer>();
            if(Sr != null){
                Shader shader = null;
                if(enableFlash){
                    shader = Shader.Find("Sprites/Diffuse Flash");
                    Log(gameObject.name + " Sprites/Diffuse Flash");
                }
                if(shader == null){
                    shader = Shader.Find("Sprites/Default");
                    Log(gameObject.name + " Sprites/Default");

                }
                Sr.material = new Material(shader);
            }
        }
        
    }
}
