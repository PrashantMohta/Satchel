
namespace Satchel
{
    /// <summary>
    /// Monobehavior to manage the uniqueness of a Tk2d animation system
    /// </summary>
    public class UniqueTk2d : MonoBehaviour
    {
        private tk2dSpriteAnimator animator;
        private tk2dSpriteAnimation animation, animationClone;
        private tk2dSpriteCollectionData collection, collectionClone;

        /// <summary>
        /// Current state of the tk2d system
        /// </summary>
        public bool IsUnique { get; private set; } = false;


        private void EnsureDefaults()
        {
            animator = GetComponent<tk2dSpriteAnimator>();
            if (animator != null)
            {
                if (animation == null)
                {
                    animation = animator.Library;
                }
                if (collection == null)
                {
                    collection = animator.Library.clips[0].frames[0].spriteCollection;
                }
            }
        }
        private void EnsureClones()
        {
            EnsureDefaults();
            if (animationClone == null)
            {
                animationClone = animation.Clone();
                animationClone.gameObject.transform.SetParent(transform);
            }
            if (collectionClone == null)
            {
                collectionClone = collection.Clone();
                collectionClone.gameObject.transform.SetParent(transform);
                foreach (tk2dSpriteAnimationClip clip in animationClone.clips)
                {
                    foreach (tk2dSpriteAnimationFrame frame in clip.frames)
                    {

                        frame.spriteCollection = collectionClone;
                    }
                }
            }
        }
        /// <summary>
        /// Make the current Tk2d system unique
        /// </summary>
        /// <returns>self</returns>
        public UniqueTk2d MakeUnique()
        {
            EnsureClones();
            animator.Library = animationClone;
            IsUnique = true;
            return this;
        }

        /// <summary>
        /// Make the current Tk2d system generic
        /// </summary>
        /// <returns>self</returns>
        public UniqueTk2d MakeGeneric()
        {
            EnsureDefaults();
            animator.Library = animation;
            IsUnique = false;
            return this;
        }

        /// <summary>
        /// Set the texture to the current tk2d animation system
        /// </summary>
        /// <param name="tex"></param>
        public void SetTexture(Texture2D tex)
        {
            if (IsUnique)
            {
                collectionClone.SetTexture(tex);
            }
            else
            {
                collection.SetTexture(tex);
            }

        }
    }

}
