using Modding;
using System;
using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;
using static Satchel.BetterMenus.Blueprints;

namespace SatchelBetterMenus.Example 
{
    public static class SimpleMenu
    {
        public static int selectedOption = 1, selectedOption2 = 0;
        public static Menu MenuRef;
        
        public static KeyBinds keybind = new KeyBinds();
        public static ButtonBinds button = new ButtonBinds();
        public static Menu PrepareMenu(){
            return new Menu("Simple Menu",new Element[]{
                new HorizontalOption(
                    "Option 1", "Horizontal option",
                    new string[]{"Show","Hide"},
                    (setting) => { selectedOption = setting; },
                    () => selectedOption
                ),
                new HorizontalOption(
                    "Option 2", "",
                    new string[]{"1","2","3","4"},
                    (setting) => { selectedOption2 = setting; },
                    () => selectedOption2
                ),
                new TextPanel("Simple to create basic menus if that's all you need"),
                new KeyBind("Key",keybind.Action),
                new ButtonBind("button",button.Action)
            });
        }
        public static MenuScreen GetMenu(MenuScreen lastMenu){
            if(MenuRef == null){
                MenuRef = PrepareMenu();
                MenuRef.OnBuilt += (_, R) =>
                {
                    MenuRef.AddConfirmDialog("Do you want to continue?", "", new string[] { "continue", "Git Good", "Quit" }, (inp) =>
                    {
                        if (inp.StartsWith("continue"))
                        {
                            Utils.GoToMenuScreen(MenuRef.returnScreen);
                        } else
                        {
                            Utils.GoToMenuScreen(MenuRef.menuScreen);
                        }
                        Modding.Logger.Log(inp);
                    });
                };
            }
            return MenuRef.GetMenuScreen(lastMenu);
        }
    }
}