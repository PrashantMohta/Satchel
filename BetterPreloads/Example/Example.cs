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
        public override void Initialize()
        {
            Log(PreloadExample.Preloads.cornifierCard != null);
            Log(PreloadExample.Preloads.hornetTwo != null);
        }
    }
}
