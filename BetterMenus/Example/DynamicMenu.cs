using Modding;
using System;
using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;

namespace SatchelBetterMenus.Example 
{
    public static class DynamicMenu
    {
        public static int selectedOption = 1, selectedOption2 = 0,count = 0;
        public static Menu MenuRef;
        public static Menu PrepareMenu(){
            return new Menu("Dynamic Menu",new Element[]{
                new TextPanel("Please Press the button below",Id:"btncount"),
                new MenuButton("button","use to change text",(mb)=>{
                    count++;
                    MenuRef.updateAfter((menuElement)=>{
                        var btn = MenuRef.Find("DynamicButton");
                        btn.Name = btn.Name == "button" ? "buttoff" : "button";
                        MenuRef.Find("btncount").Name = $"Button Pressed {count} times";
                    });
                },Id:"DynamicButton"),
                new TextPanel("Flexibility to create menus that can dynamically update to player interaction",800f),
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