using System;
using GlobalEnums;
using UnityEngine;
using UnityEngine.UI;

    
namespace Satchel.BetterMenus.Config
{
    
    public enum SelectableArea
    {
        Full,
        ButtonOnly
    }

    /// <summary>
    /// Configuration options for creating a menu keybind option.
    /// </summary>
    public struct KeybindConfig
    {
        /// <summary>
        /// The displayed text for the name of the keybind.
        /// </summary>
        public string Label;
        /// <summary>
        /// The style of the keybind.
        /// </summary>
        public KeybindStyle? Style;
        /// <summary>
        /// The action to run when pressing the menu cancel key while selecting this item.
        /// </summary>
        public Action<MappableKey> CancelAction;

        public SelectableArea? selectableArea;
    }

    /// <summary>
    /// Configuration options for creating a menu buttonBind option.
    /// </summary>
    public struct ButtonBindConfig
    {
        /// <summary>
        /// The displayed text for the name of the ButtonBind.
        /// </summary>
        public string Label;
        /// <summary>
        /// The style of the ButtonBind.
        /// </summary>
        public KeybindStyle? Style;
        /// <summary>
        /// The action to run when pressing the menu cancel key while selecting this item.
        /// </summary>
        public Action<MappableControllerButton> CancelAction;
        
        public SelectableArea? selectableArea;
    }

    /// <summary>
    /// The styling options of a keybind menu item.
    /// </summary>
    public struct KeybindStyle
    {
        /// <summary>
        /// The style preset of a keybind in the vanilla game.
        /// </summary>
        public static readonly KeybindStyle VanillaStyle = new KeybindStyle
        {
            LabelTextSize = 37
        };
        /// <summary>
        /// The text size of the label text.
        /// </summary>
        public int LabelTextSize;
    }
}

