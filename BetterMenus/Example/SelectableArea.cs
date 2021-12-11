using Modding;
using System;
using System.Collections.Generic;

using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;
using Satchel.BetterMenus.Config;

namespace SatchelBetterMenus.Example 
{
    public static class SelectableAreaMenu
    {
        public static int selectedOption = 0, selectedOption2 = 0,count =0 ;
        public static Menu MenuRef;
        public static KeyBinds keybind = new KeyBinds();
        public static ButtonBinds button = new ButtonBinds();
        public static Menu PrepareMenu(){
            return new Menu("Complex Menu",new Element[]{
                new TextPanel("Selectable Area Mod Menu ",1000f),
                new HorizontalOption(
                    "Selectable area", 
                    "needs menu exit and re-entry to apply",
                    new string[]{"Button Only","Full"},
                    (setting) => {
                        selectedOption = setting;
                        if(setting == 0){
                            MenuRef?.Find("key")?.updateAfter((elem)=>{
                                ((KeyBind)elem).SelectableArea=SelectableArea.ButtonOnly;
                            });
                            MenuRef?.Find("button")?.updateAfter((elem)=>{
                                ((ButtonBind)elem).SelectableArea=SelectableArea.ButtonOnly;
                            });
                            MenuRow cw = (MenuRow) MenuRef?.Find("ComboWammie");
                           foreach(Element e in cw.Row){
                               if(e is KeyBind){
                                   ((KeyBind)e).SelectableArea = SelectableArea.ButtonOnly;
                               }else if(e is ButtonBind){
                                   ((ButtonBind)e).SelectableArea = SelectableArea.ButtonOnly;
                               }
                               e.gameObject.SetActive(false);
                               e.gameObject.SetActive(true);
                           }
                           MenuRef.Update();
                        }else {
                           MenuRef?.Find("key")?.updateAfter((elem)=>{
                                ((KeyBind)elem).SelectableArea=SelectableArea.Full;
                           });
                           MenuRef?.Find("button")?.updateAfter((elem)=>{
                                ((ButtonBind)elem).SelectableArea=SelectableArea.Full;
                           });
                           MenuRow cw = (MenuRow) MenuRef?.Find("ComboWammie");
                           foreach(Element e in cw.Row){
                               if(e is KeyBind){
                                   ((KeyBind)e).SelectableArea = SelectableArea.Full;
                               }else if(e is ButtonBind){
                                   ((ButtonBind)e).SelectableArea = SelectableArea.Full;
                               }
                               e.gameObject.SetActive(false);
                               e.gameObject.SetActive(true);
                           }
                           MenuRef.Update();
                        }
                        },
                    () => selectedOption
                ),
                new KeyBind("keybind" ,keybind.Action,Id:"key"){SelectableArea = SelectableArea.ButtonOnly},
                new ButtonBind("buttonbind",button.Action,Id:"button"){SelectableArea = SelectableArea.ButtonOnly},
                Blueprints.KeyAndButtonBind("ComboWammie",keybind.Action,button.Action)
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