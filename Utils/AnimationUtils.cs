namespace Satchel
{
    /// <summary>
    /// Utilities to work with Animations
    /// </summary>
    public static class AnimationUtils {
        
        /// <summary>
        /// Checks if an animation clip is playing.
        /// </summary>
        /// <param name="anim"></param>
        /// <returns>
        /// true if animation is playing
        /// false if animation is not playing
        /// </returns>
        public static bool IsPlaying(this Animator anim)
        {
            return anim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f;
        }

        /// <summary>
        /// Checks if a specific animation clip is playing.
        /// </summary>
        /// <param name="anim"></param>
        /// <param name="s"></param>
        /// <returns>
        /// true if animation is playing
        /// false if animation is not playing
        /// </returns>
        public static bool IsPlaying(this Animator anim, string s)
        {
            return anim.GetCurrentAnimatorStateInfo(0).IsName(s) && anim.IsPlaying();
        }

        /// <summary>
        /// Returns the name of the animation clip
        /// </summary>
        /// <param name="anim"></param>
        /// <returns>
        /// returns an string clip name
        /// </returns>
        public static string GetClipName(this Animator anim)
        {
            AnimatorClipInfo att = anim.GetCurrentAnimatorClipInfo(0)[0];
            return att.clip.name;
        }

        /// <summary>
        /// Returns the frame the animation clip is at.
        /// </summary>
        /// <param name="anim"></param>
        /// <returns>
        /// returns an integer frame number
        /// </returns>
        public static int GetCurrentFrame(this Animator anim)
        {
            AnimatorClipInfo att = anim.GetCurrentAnimatorClipInfo(0)[0];
            int currentFrame = (int)(anim.GetCurrentAnimatorStateInfo(0).normalizedTime % 1f * (att.clip.length * att.clip.frameRate));
            return currentFrame;
        }

        /// <summary>
        /// Plays the clip named [name] at frame [frame].
        /// </summary>
        /// <param name="anim"></param>
        /// <param name="name"></param>
        /// <param name="frame"></param>
        public static void PlayAt(this Animator anim, string name, int frame)
        {
            AnimatorClipInfo att = anim.GetCurrentAnimatorClipInfo(0)[0];
            float normTime = frame / (att.clip.length * att.clip.frameRate);
            anim.Play(name, 0, normTime);
        }

        /// <summary>
        /// Logs All tk2d animation clips.
        /// </summary>
        public static void logTk2dAnimationClips(this GameObject go) {
            tk2dSpriteAnimator spriteAnimator = go.GetComponent<tk2dSpriteAnimator>();
            Satchel.Instance.Log($"clip.names for {go.name}");
            foreach(var clip in spriteAnimator.Library.clips){
                Satchel.Instance.Log(clip.name);
            }
        }

        /// <summary>
        /// Plays All tk2d animation clips.
        /// </summary>
        public static IEnumerator playAllAnim(this GameObject go,int i = 0) {
            tk2dSpriteAnimator spriteAnimator = go.GetComponent<tk2dSpriteAnimator>();
            var clips = spriteAnimator.Library.clips;
            i++;
            if(clips.Length <= i){
                i=0;
            } 
            spriteAnimator.PlayFromFrame(clips[i], 0);
            Satchel.Instance.Log(clips[i].name);
            yield return new WaitForSeconds(2f);
            CoroutineHelper.GetRunner().StartCoroutine(go.playAllAnim(i));
        }
    
    } 
}