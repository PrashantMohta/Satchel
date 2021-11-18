using System;
using System.Collections.Generic;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.MenuOptions
{
    //just a bunch of classes we need
    public abstract class MenuOption
    {
        public string Name;

        public abstract void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject, GameObject)> ListSubOptions);
    }

    public interface PrimaryMenuOption
    {
        public abstract void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject, GameObject)> ListSubOptions);
        public abstract void AddUpdateMenu(Action UpdateMenu);
    }
    public class KeyAndButtonBind : MenuOption
    {
        public string KeyBindName;
        public InControl.PlayerAction KeyBindAction;
        public string ButtonBindName;
        public InControl.PlayerAction ButtonBindAction;
        
        public KeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction)
        {
            KeyBindName = keyBindName;
            KeyBindAction = keyBindAction;
            ButtonBindName = buttonBindName;
            ButtonBindAction = buttonBindAction;
        }
        
        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(750f);
            layout.ChangeColumns(2, newSize: l);
            
            c.AddKeybind(
                KeyBindName,
                KeyBindAction,
                new KeybindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = KeyBindName,
                }, out var option);

            c.AddButtonBind(
                ButtonBindName,
                ButtonBindAction,
                new ButtonBindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = ButtonBindName,
                }, out var option2);
            
            l.x = new RelLength(1920f);
            layout.ChangeColumns(1, 0.25f, l);
            
            go = (option.gameObject, option2.gameObject);
            ListSubOptions = null;
        }
    }
    public class KeyBind : MenuOption
    {
        public InControl.PlayerAction PlayerAction;

        public KeyBind(string name,InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddKeybind(
                Name,
                PlayerAction,
                new KeybindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);
            go = (option.gameObject, null);
            ListSubOptions = null;
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
        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddButtonBind(
                Name,
                PlayerAction,
                new ButtonBindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);
            go = (option.gameObject, null);
            ListSubOptions = null;
        }
    }
    
    //plagerism isnt bad if its used in a good way OK!!!!!!
    public class HorizontalOption : MenuOption, PrimaryMenuOption
    {
        public string Description;
        public string[] Values;
        public Action<int> ApplySetting;
        public Func<int> LoadSetting;

        public HorizontalOption(string name, string[] values, string description, Action<int> applySetting, Func<int> loadSetting)
        {
            Name = name;
            Description = description;
            Values = values;
            ApplySetting = applySetting;
            LoadSetting= loadSetting;
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddHorizontalOption(
                Name,
                new HorizontalOptionConfig
                {
                    ApplySetting = (_, i) => ApplySetting(i),
                    RefreshSetting = (s, _) => s.optionList.SetOptionTo(LoadSetting()),
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Options = Values,
                    Style = HorizontalOptionStyle.VanillaStyle
                },
                out var option);
            go = (option.gameObject, null);
            ListSubOptions = null;
        }

        public void AddUpdateMenu(Action UpdateMenu)
        {
            ApplySetting += _ => UpdateMenu.Invoke();
        }
    }
    public class MenuButton : MenuOption, PrimaryMenuOption
    {
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        public string Description;

        public MenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
        }
        
        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddMenuButton(
                Name,
                new MenuButtonConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Description = new DescriptionInfo
                    {
                        Text = Description
                    },
                    Label = Name,
                    Proceed = false,
                    SubmitAction = SubmitAction,
                }, out var option);

            go = (option.gameObject, null);
            ListSubOptions = null;
        }

        public void AddUpdateMenu(Action UpdateMenu)
        {
            SubmitAction += _ => UpdateMenu.Invoke();
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

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddTextPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                new TextPanelConfig
                {
                    Anchor = TextAnchor.MiddleCenter,
                    Font = TextPanelConfig.TextFont.TrajanBold,
                    Size = 46,
                    Text = Name
                }, out var option);
            go = (option.gameObject, null);
            ListSubOptions = null;
        }
    }
    public class StaticPanel: MenuOption
    {
        //the paramater that will be passed in is the static panel that you'll have to make the new object the parent of
        public Action<GameObject> CreateCustomItem;
        public float Width;
        public StaticPanel(string name, Action<GameObject> createCustomItem, float width = 1500f)
        {
            Name = name;
            CreateCustomItem = createCustomItem;
            Width = width;
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            c.AddStaticPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                out var option);
            CreateCustomItem.Invoke(option);
            go = (option.gameObject, null);
            ListSubOptions = null;
        }
    }

    public class ModToggleOption: MenuOption, PrimaryMenuOption
    {
        public ModToggleDelegates ToggleDelegates;
        public string Description;
        private Action<int> ApplySetting;
        
        public ModToggleOption(string name, ModToggleDelegates toggleDelegates, string description)
        {
            Name = name;
            ToggleDelegates = toggleDelegates;
            Description = description;
            ApplySetting = i => toggleDelegates.SetModEnabled(i == 0);
            
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            var horizontalOption = new HorizontalOption(Name, new[] {"On", "Off"}, Description,
                i => { ToggleDelegates.SetModEnabled(i == 0);}, 
                () => ToggleDelegates.GetModEnabled() ? 0 : 1);
            
            horizontalOption.CreateMenuOption(c, modlistMenu, Instance,out go, out ListSubOptions);
        }

        public void AddUpdateMenu(Action UpdateMenu)
        {
            ApplySetting +=  _ => UpdateMenu.Invoke();
        }
    }

    public class HideableMenuOption : MenuOption
    {
        public PrimaryMenuOption MainOption;
        public List<MenuOption> SubOptions;
        //the function that will return a bool. the bool will determine whether the sub options should show or not
        public Func<bool> EnableSubOptions;
        
        private List<(GameObject,GameObject)> AllSubOptions = new List<(GameObject,GameObject)>();

        public HideableMenuOption(PrimaryMenuOption mainOption, List<MenuOption> subOptions,Func<bool> enableSubOptions)
        {
            MainOption = mainOption;
            SubOptions = subOptions;
            EnableSubOptions = enableSubOptions;
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            MainOption.AddUpdateMenu(() =>
            {
                bool enable = EnableSubOptions.Invoke();
                foreach ((GameObject,GameObject) go in AllSubOptions)
                {
                    go.Item1.SetActive(enable);
                    if (go.Item2 != null) go.Item2.SetActive(enable);
                }
                Instance.Reorder();
            });
            
            MainOption.CreateMenuOption(c, modlistMenu, Instance, out var primaryoption, out _);
            
            foreach (MenuOption menuOption in SubOptions)
            {
                menuOption.CreateMenuOption(c, modlistMenu,Instance,out var option, out _);
                AllSubOptions.Add(option);
            }

            go = primaryoption;
            ListSubOptions = AllSubOptions;
        }
    }

    public class SideBySideOptions : MenuOption
    {
        public MenuOption LeftOption;
        public MenuOption RightOption;

        public SideBySideOptions(MenuOption leftOption, MenuOption rightOption)
        {
            LeftOption = leftOption;
            RightOption = rightOption;
        }

        public override void CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, out (GameObject, GameObject) go, out List<(GameObject,GameObject)> ListSubOptions)
        {
            
            if (LeftOption is KeyAndButtonBind or SideBySideOptions ||
                RightOption is KeyAndButtonBind or SideBySideOptions)
            {
                go = (null, null);
                ListSubOptions = null;
                Modding.Logger.LogError("[Satchel] - You cannot create Side by side options inside itself");
                return;
            }
            
            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(750f);
            layout.ChangeColumns(2, newSize: l);

            LeftOption.CreateMenuOption(c,modlistMenu,Instance,out var option1, out _);
            RightOption.CreateMenuOption(c, modlistMenu,Instance ,out var option2, out _);
            
            l.x = new RelLength(1920f);
            layout.ChangeColumns(1, 0.25f, l);

            go = (option1.Item1, option2.Item2);
            ListSubOptions = null;
        }
    }
}
