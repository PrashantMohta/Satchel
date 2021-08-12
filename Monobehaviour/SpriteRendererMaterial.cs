using System;
using UnityEngine;

namespace DandyCore{
    public class SpriteRendererMaterial : MonoBehaviour {

        public Material mat;

        void Awake () {
            SpriteRenderer Sr = GetComponent<SpriteRenderer>();
            if(Sr != null){
                Sr.material = new Material(Shader.Find("Sprites/Default"));
            }
            Debug.Log("version 2 of DandyCore");
        }
        
    }
}
