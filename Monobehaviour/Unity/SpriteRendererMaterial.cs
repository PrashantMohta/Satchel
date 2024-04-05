namespace Satchel
{
    /// <summary>
    /// Fix the shader on the sprite renderers that have been loaded after asset bundling
    /// </summary>
    public class SpriteRendererMaterial : MonoBehaviour
    {

        public bool enableFlash = false;

        void Awake()
        {
            SpriteRenderer Sr = GetComponent<SpriteRenderer>();
            if (Sr != null)
            {
                Shader shader = null;
                if (enableFlash)
                {
                    shader = Core.spriteFlash;
                }
                else
                {
                    shader = Shader.Find("Sprites/Default");
                }
                Sr.material = new Material(shader);
            }
        }

    }
}
