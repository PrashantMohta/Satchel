using Modding;
using System;
using System.Collections.Generic;

using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterPreloads;

#pragma warning disable CS0649 //because we'll set the values later using reflection
namespace SatchelBetterPreloads.Example 
{
    public class MyPreloads {

        [Preload("Cliffs_01","Cornifer Card")]
        public GameObject cornifierCard {set; get;}

        [Preload("GG_Hornet_2", "Boss Holder/Hornet Boss 2")]
        internal GameObject hornetTwo;
    }
}