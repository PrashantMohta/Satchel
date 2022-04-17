using static Satchel.SpriteUtils;
using static Satchel.TextureUtils;
using Newtonsoft.Json;
using System.IO;

namespace Satchel
{   
    public class Animation{
        public string[] frames;
        public float fps;
        public bool loop;
    }

    public class CustomAnimationController : MonoBehaviour {
        public Animation anim;
        public Sprite[] sprites;
        public int currentFrame = 0;
        public bool animating = false;
        private SpriteRenderer sr;
        private DateTime lastFrameChange;

        public void Start(){
            sr = GetComponent<SpriteRenderer>();
        }
        public void Init(Animation animation){
            anim = animation;
            // init values
            currentFrame = -1;
            animating = true;
            sprites = CustomAnimation.loadedSprites[anim];
        }

        public void Update(){
            if(!animating){ return;}
            if(lastFrameChange == null || (DateTime.Now - lastFrameChange).TotalMilliseconds > 1000/anim.fps){
                currentFrame++;
                if(currentFrame >= sprites.Length){
                    if(anim.loop){
                        currentFrame = 0;   
                    } else {
                        currentFrame = sprites.Length - 1;
                    }
                }
                lastFrameChange = DateTime.Now;
            }
            if(sr == null){
                sr = GetComponent<SpriteRenderer>();
            }
            Debug.Log($"currentFrame: {currentFrame} | sprites.Length: {sprites.Length}");
            sr.sprite = sprites[currentFrame];

        }
    }

    
    public static class CustomAnimation{

        public static Dictionary<Animation,Sprite[]> loadedSprites = new Dictionary<Animation, Sprite[]>(); 
        public static Animation LoadAnimation(string animationJsonPath){
            var animationRootFolder = Path.GetDirectoryName(animationJsonPath);
            var animationJson = File.ReadAllText(animationJsonPath);

            Animation anim = JsonConvert.DeserializeObject<Animation>(animationJson, new JsonSerializerSettings() { ObjectCreationHandling = ObjectCreationHandling.Replace });
            loadedSprites[anim] = new Sprite[anim.frames.Length];
            // load textures as sprites
            for(var frame = 0; frame < anim.frames.Length; frame++){
                var tex = LoadTextureFromFile(Path.Combine(animationRootFolder,anim.frames[frame]));
                loadedSprites[anim][frame] = Sprite.Create(tex,new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f),64f,0,SpriteMeshType.FullRect);
            }
            return anim;
        }

    }
}