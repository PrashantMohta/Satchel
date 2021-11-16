using System;
using System.Collections.Generic;
using System.Linq;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Satchel
{
    public abstract class MenuOption
    {
        public string Name;
    }

    public class KeyBind : MenuOption
    {
        public InControl.PlayerAction PlayerAction;

        public KeyBind(string name,InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }
    }
    public class ButtonBind : MenuOption
    {
        public InControl.PlayerAction PlayerAction;

        public ButtonBind(string name, InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }
    }
    
    //plagerism isnt bad if its used in a good way OK!!!!!!
    public class HorizontalOption : MenuOption
    {
        public string Description;
        public string[] Values;
        public Action<int> Saver;
        public Func<int> Loader;

        public HorizontalOption(string name, string[] values, string description, Action<int> saver, Func<int> loader)
        {
            Name = name;
            Description = description;
            Values = values;
            Saver = saver;
            Loader = loader;
        }
    }
    public class MenuButton : MenuOption
    {
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        public string Description;

        public MenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
        }
    }
    public class TextPanel : MenuOption
    {
        public float Width;

        public TextPanel(string name, float width = 1500f)
        {
            Name = name;
            Width = width;
        }
    }
}
