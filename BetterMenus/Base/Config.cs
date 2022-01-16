using System;
using GlobalEnums;
using UnityEngine;
using UnityEngine.UI;

    
namespace Satchel.BetterMenus.Config
{
    
    /// <summary>
    /// An enum to help decide how much of the element can be selected
    /// </summary>
    public enum SelectableArea
    {
        /// <summary>
        /// Make the whole key/button bind selectable including the text
        /// </summary>
        Full,
        /// <summary>
        /// Only allow the key/button area to be selectable
        /// </summary>
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

        /// <summary>
        /// An enum to help decide how much of the element can be selected
        /// </summary>
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
        
        /// <summary>
        /// An enum to help decide how much of the element can be selected
        /// </summary>
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

