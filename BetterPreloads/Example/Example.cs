using Modding;
using System;
using System.Collections.Generic;

using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterPreloads;

namespace SatchelBetterPreloads.Example 
{
    public class PreloadExample : BetterPreloadsMod<MyPreloads>
    {
        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
        {
            base.Initialize(preloadedObjects);
            Log(PreloadExample.Preloads.cornifierCard != null);
            Log(PreloadExample.Preloads.hornetTwo != null);
        }
    }
}
