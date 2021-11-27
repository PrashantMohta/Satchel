using Modding;
using System;
using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;

namespace SatchelBetterMenus.Example 
{
    public class MenuExample : Mod, ICustomMenuMod
    {
        private string getVersionSafely(){
            return Satchel.AssemblyUtils.GetAssemblyVersionHash();
        }
        public override string GetVersion()
        {
            var version = "Install Satchel";
            try{
                version = getVersionSafely();
            } catch(Exception e){
                Modding.Logger.Log(e.ToString());
            }
            return version;
        }

        
        public bool ToggleButtonInsideMenu => false;
        public KeyBinds keybind = new KeyBinds();
        public ButtonBinds button = new ButtonBinds();
        public Menu MenuRef;
        public int selectedOption = 0;
        public override void Initialize()
        {

        }
       
        public Menu PrepareMenu(){
            return new Menu("SatchelBetterMenus", new Element[]{
                new TextPanel("Example Mod Menu Text Panel",1000f,Id:"textyboi"),
                new TextPanel("uses name",1000f),
                new HorizontalOption(
                    "Option 1", 
                    "horizotal option description",
                    new string[]{"O1","O2","O3"},
                    (setting) => {
                        selectedOption = setting;
                        MenuRef?.Find("textyboi")?.updateAfter((elem)=>{
                            ((Element)elem).Name="uses Id " + setting;
                        });
                        MenuRef?.Find("uses name")?.updateAfter((elem)=>{
                            ((Element)elem).Name="uses name" + setting;
                        });
                        },
                    () => selectedOption
                ),
                new KeyBind("Key",keybind.Action),
                new ButtonBind("button",button.Action)
            });
        }
       
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            if(MenuRef == null){
                MenuRef = PrepareMenu();
            }
            return MenuRef.GetMenuScreen(modListMenu);
        }


    }
}
