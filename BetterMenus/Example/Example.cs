using Modding;
using System;
using System.Collections.Generic;

using UnityEngine;
using InControl;
using Satchel;
using Satchel.BetterMenus;

namespace SatchelBetterMenus.Example 
{
    public class MenuExample : Mod, ICustomMenuMod , ITogglableMod
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

        public bool ToggleButtonInsideMenu => true;

        public float sliderValue = 0f;

        public Menu MenuRef;
        public int selectedOption = 0,selectedToggleOption = 1;
        public override void Initialize()
        {

        }
        public void Unload(){
            Log("Unloaded");
        }
        public Menu PrepareMenu(ModToggleDelegates toggleDelegates){
            return new Menu("Satchel BetterMenus", new Element[]{
                toggleDelegates.CreateToggle("Mod Toggle","Made using Blueprints"),
                new TextPanel("Explore a few menus that can be made",800f),
                new TextPanel("using the Better Menus system below",800f),
                new MenuRow(
                    new List<Element>{
                        Blueprints.NavigateToMenu(
                            "Simple Menu",
                            "Create Basic Menus quickly",
                            ()=>SimpleMenu.GetMenu(MenuRef.menuScreen)
                        ),
                        Blueprints.NavigateToMenu(
                            "Dupe",
                            "Dupe!",
                            ()=>SimpleMenu.GetMenu(MenuRef.menuScreen)
                        ),
                        Blueprints.NavigateToMenu(
                            "Dynamic Updates",
                            "Without messing around with GameObjects",
                            ()=>DynamicMenu.GetMenu(MenuRef.menuScreen)
                        )
                    },
                    Id:"group1"
                ){ XDelta = 425f},
                new MenuRow(
                    new List<Element>{
                        Blueprints.NavigateToMenu(
                            "ToggleGroups",
                            "Hide groups of elements easily",
                            ()=>ToggleGroups.GetMenu(MenuRef.menuScreen)
                        ),
                        Blueprints.NavigateToMenu(
                            "Full Control",
                            "Get specific and control individual elements",
                            ()=>ComplexMenu.GetMenu(MenuRef.menuScreen)
                        )
                    },
                    Id:"group2"
                ){ XDelta = 500f},
                new MenuRow(
                    new List<Element>{
                        Blueprints.NavigateToMenu(
                            "ToggleGroups",
                            "Hide groups of elements easily",
                            ()=>ToggleGroups.GetMenu(MenuRef.menuScreen)
                        ),
                        Blueprints.NavigateToMenu(
                            "Full Control",
                            "Get specific and control individual elements",
                            ()=>ComplexMenu.GetMenu(MenuRef.menuScreen)
                        )
                    },
                    Id:"group2"
                ){ XDelta = 500f},
                new CustomSlider(
                    "SliderBoi",
                    (f)=>{
                        sliderValue = f;
                        //Log($"slider value updated {f}");
                    },
                    () => (float)sliderValue,Id:"sliderboi")
            });
        }
       
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            if(MenuRef == null){
                MenuRef = PrepareMenu((ModToggleDelegates)toggleDelegates);
            }
            return MenuRef.GetMenuScreen(modListMenu);
        }


    }
}
