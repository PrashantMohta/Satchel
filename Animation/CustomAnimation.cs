using System.IO;
using Newtonsoft.Json;
using static Satchel.TextureUtils;

namespace Satchel
{
    /// <summary>
    /// Loads and manages CustomAnimations
    /// </summary>
    public static class CustomAnimation
    {
        /// <summary>
        /// All currently loaded Sprites
        /// </summary>
        public static Dictionary<Animation, Sprite[]> loadedSprites = new Dictionary<Animation, Sprite[]>();

        /// <summary>
        /// Load an animation using a serialised JSON
        /// </summary>
        /// <param name="animationJsonPath">path to the json file</param>
        /// <returns></returns>
        public static Animation LoadAnimation(string animationJsonPath)
        {
            var animationRootFolder = Path.GetDirectoryName(animationJsonPath);
            var animationJson = File.ReadAllText(animationJsonPath);

            Animation anim = JsonConvert.DeserializeObject<Animation>(animationJson, new JsonSerializerSettings() { ObjectCreationHandling = ObjectCreationHandling.Replace });
            loadedSprites[anim] = new Sprite[anim.frames.Length];
            // load textures as sprites
            for (var frame = 0; frame < anim.frames.Length; frame++)
            {
                var tex = LoadTextureFromFile(Path.Combine(animationRootFolder, anim.frames[frame]));
                loadedSprites[anim][frame] = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 64f, 0, SpriteMeshType.FullRect);
            }
            return anim;
        }

        /// <summary>
        /// Load an animation using an Animation Object
        /// </summary>
        /// <param name="anim">Animation Object to load</param>
        /// <param name="sprites">An array of sprites corresponding to the frames</param>
        /// <returns></returns>
        public static Animation LoadAnimation(Animation anim, Sprite[] sprites)
        {
            loadedSprites[anim] = sprites;
            return anim;
        }

    }
}