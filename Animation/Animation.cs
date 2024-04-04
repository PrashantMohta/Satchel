using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Satchel
{
    /// <summary>
    /// Holds the serializable parameters for an Animation
    /// </summary>
    public class Animation
    {
        /// <summary>
        /// Names of the files that will make up each of the frames of the animation
        /// </summary>
        public string[] frames;

        /// <summary>
        /// The Rate of animation playback
        /// </summary>
        public float fps;

        /// <summary>
        /// if the animation must loop after ending
        /// </summary>
        public bool loop;

    }
}
