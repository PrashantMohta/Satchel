using Modding;
using System;
using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;

namespace SatchelBetterMenus.Example 
{
    public static class ComplexMenu
    {
        public static int selectedOption = 1, selectedOption2 = 0;
        public static Menu MenuRef;
        public static KeyBinds keybind = new KeyBinds();
        public static ButtonBinds button = new ButtonBinds();
        public static Menu PrepareMenu(){
            return new Menu("Complex Menu",new Element[]{
                new TextPanel("Example Mod Menu Text Panel",1000f,Id:"textyboi"),
                new TextPanel("uses name",1000f),
                new TextPanel("1 boy",1000f,Id:"1boi"){isVisible=false},
                new TextPanel("2 boi",1000f,Id:"2boi"){isVisible=false},
                new TextPanel("3 bois",1000f,Id:"3boi"){isVisible=false},
                new HorizontalOption(
                    "Option 1", 
                    "horizotal option description",
                    new string[]{"O1","O2","O3"},
                    (setting) => {
                        selectedOption = setting;
                        if(setting == 0){
                            MenuRef?.Find("1boi")?.Show();
                            MenuRef?.Find("2boi")?.Hide();
                            MenuRef?.Find("3boi")?.Hide();
                            MenuRef?.Find("ComboWammie")?.updateAfter((elem)=>{
                                ((SideBySideElements)elem).RightElement.isVisible = false;
                            });
                        } else if(setting == 1){
                            MenuRef?.Find("1boi")?.Hide();
                            MenuRef?.Find("2boi")?.Show();
                            MenuRef?.Find("3boi")?.Hide();
                            MenuRef?.Find("ComboWammie")?.updateAfter((elem)=>{
                                ((SideBySideElements)elem).RightElement.isVisible = false;
                            });
                        } else {
                            MenuRef?.Find("1boi")?.Hide();
                            MenuRef?.Find("2boi")?.Hide();
                            MenuRef?.Find("3boi")?.Show();
                            MenuRef?.Find("ComboWammie")?.updateAfter((elem)=>{
                                ((SideBySideElements)elem).RightElement.isVisible = true;
                            });
                        }
                        MenuRef?.Find("textyboi")?.updateAfter((elem)=>{
                            ((Element)elem).Name="uses Id " + setting;
                        });
                        MenuRef?.Find("uses name")?.updateAfter((elem)=>{
                            ((Element)elem).Name="uses name" + setting;
                        });
                        },
                    () => selectedOption
                ),
                Blueprints.KeyAndButtonBind("ComboWammie",keybind.Action,button.Action),
                new TextPanel("create complex menus if that's what you need",800f),
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