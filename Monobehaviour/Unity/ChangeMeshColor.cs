using System;
using UnityEngine;
using static DandyCore.TextureUtils;

namespace DandyCore{
    class ChangeMeshColor : MonoBehaviour
    {
        private Material mat;
        public Color color = Color.black;
        public void Start()
        {
            MeshRenderer Mr = gameObject.GetComponent<MeshRenderer>();
            if(Mr != null){
                mat = new Material(Shader.Find("tk2d/BlendVertexColor"));
                mat.SetTexture(Shader.PropertyToID("_MainTex"), TextureUtils.createTextureOfColor(2,2,color));
                Mr.material = mat;       
            }
        }
    }
}