using Modding;
using System;
using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;

namespace SatchelBetterMenus.Example 
{
    public static class ToggleGroups
    {
        public static int selectedToggleOption = 1;
        public static Menu MenuRef;
        public static Menu PrepareMenu(){
            return new Menu("Toggle Groups",new Element[]{
                new HorizontalOption(
                    "Toggle-3-below", 
                    "Toggles 3 elements below",
                    new string[]{"Show","Hide"},
                    (setting) => {
                        selectedToggleOption = setting;
                        MenuRef.UpdateVisibility(setting == 0,new string[]{
                            "toggle1",
                            "toggle2",
                            "toggle3"
                        });
                        },
                    () => selectedToggleOption
                ),
                new TextPanel("first toggled text",1000f,Id:"toggle1"){isVisible=false},
                new TextPanel("More text",1000f,Id:"toggle2"){isVisible=false},
                new TextPanel("Always visible",1000f),
                new TextPanel("3 toggle",1000f,Id:"toggle3"){isVisible=false},
            });
        }
        public static MenuScreen GetMenu(MenuScreen lastMenu){
            if(MenuRef == null){
                MenuRef = PrepareMenu();
            }
            return MenuRef.GetMenuScreen(lastMenu);
        }
    }
}