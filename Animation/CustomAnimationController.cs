namespace Satchel
{


    /// <summary>
    /// The MonoBehaviour that controls the animation once loaded
    /// </summary>
    public class CustomAnimationController : MonoBehaviour
    {
        public Animation anim;
        public Sprite[] sprites;
        public int currentFrame = 0;
        public bool animating = false;
        private SpriteRenderer sr;
        private DateTime lastFrameChange;

        public void Start()
        {
            sr = gameObject.GetAddComponent<SpriteRenderer>();
        }
        public void Init(Animation animation)
        {
            anim = animation;
            // init values
            lastFrameChange = DateTime.MinValue;
            currentFrame = -1;
            animating = true;
            sprites = CustomAnimation.loadedSprites[anim];

        }

        public void Update()
        {
            if (!animating) { return; }
            if (lastFrameChange == null || (DateTime.Now - lastFrameChange).TotalMilliseconds > 1000 / anim.fps)
            {
                currentFrame++;
                if (currentFrame >= sprites.Length)
                {
                    if (anim.loop)
                    {
                        currentFrame = 0;
                    }
                    else
                    {
                        currentFrame = sprites.Length - 1;
                    }
                }
                lastFrameChange = DateTime.Now;
            }
            if (sr == null)
            {
                sr = gameObject.GetAddComponent<SpriteRenderer>();
            }
            sr.sprite = sprites[currentFrame];
        }
    }

}