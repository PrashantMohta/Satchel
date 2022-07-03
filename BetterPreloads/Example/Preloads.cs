using Modding;
using System;
using System.Collections.Generic;

using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterPreloads;

namespace SatchelBetterPreloads.Example 
{
    public class MyPreloads {

        [Preload("Cliffs_01","Cornifer Card")]
        public GameObject cornifierCard;

        [Preload("GG_Hornet_2", "Boss Holder/Hornet Boss 2")]
        public GameObject hornetTwo;
    }
}