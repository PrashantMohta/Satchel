namespace Satchel
{
    /// <summary>
    /// Change the color of the mesh after loading it from an asset bundle
    /// </summary>
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