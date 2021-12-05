using System;
using InControl;

namespace SatchelBetterMenus.Example 
{
    public class KeyBinds : PlayerActionSet
    {
        public PlayerAction Action;

        public KeyBinds()
        {
            Action = CreatePlayerAction("xyz");
            DefaultBinds();
        }

        private void DefaultBinds()
        {
                Action.AddDefaultBinding(Key.Backspace);
        }
    }

    public class ButtonBinds : PlayerActionSet
    {
        public PlayerAction Action;
        public ButtonBinds()
        {
            Action = CreatePlayerAction("xyzController");
            DefaultBinds();
        }

        private void DefaultBinds()
        {
            Action.AddDefaultBinding(InputControlType.Action2);
        }
    }
}