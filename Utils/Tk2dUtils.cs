using System.Reflection;
using UObject = UnityEngine.Object;

namespace Satchel
{
    /// <summary>
    /// Utilities to Work with a tk2d system
    /// </summary>
    public static class Tk2dUtils
    {
        private static FieldInfo[] spriteDefinitionFields;
        private static Type spriteDefinitionType;

        /// <summary>
        /// Sets the texture of a tk2dSpriteCollectionData
        /// </summary>
        /// <param name="collection">the tk2dSpriteCollectionData to set the texture</param>
        /// <param name="tex">the texture to set</param>
        public static void SetTexture(this tk2dSpriteCollectionData collection, Texture tex)
        {

            if (collection.textures.Length > 0)
            {
                collection.textures[0] = tex;
            }
            if (collection.materials.Length > 0)
            {
                collection.materials[0].mainTexture = tex;
            }
            else
            {
                collection.material.mainTexture = tex;
            }
        }

        /// <summary>
        /// Clones the tk2dSpriteAnimation passed in so that it can be modified without modifying all instances
        /// </summary>
        /// <param name="animation">tk2dSpriteAnimation to clone</param>
        /// <returns>cloned tk2dSpriteAnimation</returns>
        public static tk2dSpriteAnimation Clone(this tk2dSpriteAnimation animation)
        {
            tk2dSpriteAnimation newAnimation = UObject.Instantiate(animation);
            for (int i = 0; i < newAnimation.clips.Length; i++)
            {
                newAnimation.clips[i] = new tk2dSpriteAnimationClip(newAnimation.clips[i]);
            }

            newAnimation.name = animation.name;
            return newAnimation;
        }

        /// <summary>
        /// Clones the tk2dSpriteCollectionData passed in so that it can be modified without modifying all instances
        /// </summary>
        /// <param name="collection">tk2dSpriteCollectionData to clone</param>
        /// <returns>cloned tk2dSpriteCollectionData</returns>
        public static tk2dSpriteCollectionData Clone(this tk2dSpriteCollectionData collection)
        {
            tk2dSpriteCollectionData newCollection = UObject.Instantiate(collection);
            for (int i = 0; i < newCollection.materials.Length; i++)
            {
                newCollection.materials[i] = UObject.Instantiate(newCollection.materials[i]);
            }

            for (int i = 0; i < newCollection.spriteDefinitions.Length; i++)
            {
                tk2dSpriteDefinition definition = new tk2dSpriteDefinition();
                if (spriteDefinitionType == null) spriteDefinitionType = typeof(tk2dSpriteDefinition);
                if (spriteDefinitionFields == null) spriteDefinitionFields = spriteDefinitionType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo fi in spriteDefinitionFields)
                    fi.SetValue(definition, fi.GetValue(newCollection.spriteDefinitions[i]));
                definition.material = newCollection.materials[definition.materialId];
                newCollection.spriteDefinitions[i] = definition;
            }

            newCollection.spriteCollectionName = collection.spriteCollectionName;
            newCollection.name = collection.name;
            return newCollection;
        }
    }
}
