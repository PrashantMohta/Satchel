using Modding;
using System;
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
        public KeyBinds keybind = new KeyBinds();
        public ButtonBinds button = new ButtonBinds();
        public Menu MenuRef;
        public int selectedOption = 0,selectedToggleOption = 1;
        public override void Initialize()
        {

        }
        public void Unload(){
            Log("Unloaded");
        }
        public Menu PrepareMenu(ModToggleDelegates toggleDelegates){
            return new Menu("SatchelBetterMenus", new Element[]{
                new MenuButton("button","i do nothing",(mb)=>{
                    MenuRef.Find("fb").updateAfter((elem)=>{
                        var btn = (Element)elem;
                        btn.Name = btn.Name == "button" ? "buttoff" : "button";
                    });
                },Id:"fb"),
                new SideBySideOptions(
                    new MenuButton("button","i do nothing",(mb)=>{
                        MenuRef.Find("bgroup").updateAfter((elem)=>{
                            var btn = ((SideBySideOptions)elem).LeftOption;
                            btn.Name = btn.Name == "button" ? "buttoff" : "button";
                        });
                    }),
                    new MenuButton("button","i do nothing",(mb)=>{
                        MenuRef.Find("bgroup").updateAfter((elem)=>{
                            var btn = ((SideBySideOptions)elem).RightOption;
                            btn.Name = btn.Name == "button" ? "buttoff" : "button";
                        });
                    }),
                Id:"bgroup"
                ),
                new TextPanel("Example Mod Menu Text Panel",1000f,Id:"textyboi"),
                toggleDelegates.CreateToggle("ExampleMod","Enables or disables the mod"),
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
                                ((SideBySideOptions)elem).RightOption.isVisible = false;
                            });
                        } else if(setting == 1){
                            MenuRef?.Find("1boi")?.Hide();
                            MenuRef?.Find("2boi")?.Show();
                            MenuRef?.Find("3boi")?.Hide();
                            MenuRef?.Find("ComboWammie")?.updateAfter((elem)=>{
                                ((SideBySideOptions)elem).RightOption.isVisible = false;
                            });
                        } else {
                            MenuRef?.Find("1boi")?.Hide();
                            MenuRef?.Find("2boi")?.Hide();
                            MenuRef?.Find("3boi")?.Show();
                            MenuRef?.Find("ComboWammie")?.updateAfter((elem)=>{
                                ((SideBySideOptions)elem).RightOption.isVisible = true;
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
                new HorizontalOption(
                    "Toggle-below", 
                    "horizotal option description",
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
                new TextPanel("first toggle",1000f,Id:"toggle1"){isVisible=false},
                new TextPanel("2 toggle",1000f,Id:"toggle2"){isVisible=false},
                new TextPanel("3 toggle",1000f,Id:"toggle3"){isVisible=false},
                new KeyBind("Key",keybind.Action),
                new ButtonBind("button",button.Action),
                Blueprints.KeyAndButtonBind("ComboWammie",keybind.Action,button.Action),
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
