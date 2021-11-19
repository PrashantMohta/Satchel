using System;
using System.Collections.Generic;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.MenuOptions
{

    public class GameObjectPair
    {
        public GameObject LeftGo;
        public GameObject RightGo;

        public GameObjectPair(GameObject go1, GameObject RightGo)
        {
            this.LeftGo = LeftGo;
            this.RightGo = RightGo;
        }
        
        public GameObjectPair(GameObject LeftGo)
        {
            this.LeftGo = LeftGo;
            this.RightGo = ISlightlyBetterMenuMod.TempObj;
        }
        public GameObjectPair(GameObjectPair menuOptionGos)
        {
            this.LeftGo = menuOptionGos.LeftGo;
            this.RightGo = menuOptionGos.RightGo;
        }
        public GameObjectPair(GameObjectPair LeftOptionGo, GameObjectPair RightOptionGo)
        {
            this.LeftGo = LeftOptionGo.LeftGo;
            this.RightGo = RightOptionGo.LeftGo;
        }
        public GameObjectPair()
        {
            this.LeftGo = ISlightlyBetterMenuMod.TempObj;
            this.RightGo = ISlightlyBetterMenuMod.TempObj;
        }
    }
    //just a bunch of classes we need
    public interface MenuOption
    {
        string Name { get; }

        public abstract GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true);
    }

    public interface PrimaryMenuOption
    {
        public abstract GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true);
        public abstract void AddUpdateMenuAction(Action UpdateMenu);
    }
   
    public class KeyBind : MenuOption
    {
        public InControl.PlayerAction PlayerAction;
        public string Name { get; }

        public KeyBind(string name,InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            c.AddKeybind(
                Name,
                PlayerAction,
                new KeybindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }
    }
    public class ButtonBind : MenuOption
    {
        public InControl.PlayerAction PlayerAction;
        public string Name { get; }

        public ButtonBind(string name, InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }
        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            c.AddButtonBind(
                Name,
                PlayerAction,
                new ButtonBindConfig
                {
                    CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modlistMenu),
                    Label = Name,
                }, out var option);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }
    }
    
    //plagerism isnt bad if its used in a good way OK!!!!!!
    public class HorizontalOption : MenuOption, PrimaryMenuOption
    {
        public string Name { get; }
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

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
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
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }

        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            ApplySetting += _ => UpdateMenu.Invoke();
        }
    }
    public class MenuButton : MenuOption, PrimaryMenuOption
    {
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        public string Description;
        public string Name { get; }
        
        public MenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
        }
        
        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
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

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }

        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            SubmitAction += _ => UpdateMenu.Invoke();
        }
    }
    public class TextPanel : MenuOption
    {
        public float Width;
        public string Name { get; }

        public TextPanel(string name, float width = 1500f)
        {
            Name = name;
            Width = width;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
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
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }
    }
    public class StaticPanel: MenuOption
    {
        //the paramater that will be passed in is the static panel that you'll have to make the new object the parent of
        public Action<GameObject> CreateCustomItem;
        public float Width;
        public string Name { get; }
        
        
        public StaticPanel(string name, Action<GameObject> createCustomItem, float width = 1500f)
        {
            Name = name;
            CreateCustomItem = createCustomItem;
            Width = width;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            c.AddStaticPanel(
                Name,
                new RelVector2(new Vector2(Width, 105f)),
                out var option);
            CreateCustomItem.Invoke(option);
            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option.gameObject));
            }

            return new GameObjectPair(option.gameObject);
        }
    }

    public class ModToggleOption: MenuOption
    {
        public ModToggleDelegates ToggleDelegates;
        public string Description;
        public string Name { get; }
        
        public ModToggleOption(string name, ModToggleDelegates toggleDelegates, string description)
        {
            Name = name;
            ToggleDelegates = toggleDelegates;
            Description = description;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            var horizontalOption = new HorizontalOption(Name, new[] {"On", "Off"}, Description,
                i =>
                {
                    ToggleDelegates.SetModEnabled(i == 0);
                }, () => ToggleDelegates.GetModEnabled() ? 0 : 1);
            
            var option = horizontalOption.CreateMenuOption(c, modlistMenu, Instance, false);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(option);
            }

            return new GameObjectPair(option);
        }
    }

    public class HideableMenuOption : MenuOption
    {
        public PrimaryMenuOption PrimaryOption;
        public List<MenuOption> SubOptions;
        //the function that will return a bool. the bool will determine whether the sub options should show or not
        public Func<bool> EnableSubOptions;
        public string Name { get; }
        
        private List<GameObjectPair> AllSubOptions = new List<GameObjectPair>();

        public HideableMenuOption(PrimaryMenuOption primaryOption, List<MenuOption> subOptions,Func<bool> enableSubOptions)
        {
            PrimaryOption = primaryOption;
            SubOptions = subOptions;
            EnableSubOptions = enableSubOptions;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            PrimaryOption.AddUpdateMenuAction(() =>
            {
                bool enable = EnableSubOptions.Invoke();
                foreach (GameObjectPair gos in AllSubOptions)
                {
                    if (gos.LeftGo != ISlightlyBetterMenuMod.TempObj ) gos.LeftGo.SetActive(enable);
                    if (gos.RightGo != ISlightlyBetterMenuMod.TempObj ) gos.RightGo.SetActive(enable);
                }
                Instance.Reorder();
            });
            
            var primaryoption = PrimaryOption.CreateMenuOption(c, modlistMenu, Instance, false);
            
            Instance.MenuOrder.Add(primaryoption);
            
            foreach (MenuOption menuOption in SubOptions)
            {
                var option = menuOption.CreateMenuOption(c, modlistMenu,Instance, false);
                AllSubOptions.Add(option);
                Instance.MenuOrder.Add(option);
            }

            return primaryoption;
        }
    }
    
    public class KeyAndButtonBind : MenuOption
    {
        public string KeyBindName;
        public InControl.PlayerAction KeyBindAction;
        public string ButtonBindName;
        public InControl.PlayerAction ButtonBindAction;
        public string Name { get; }
        
        public KeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction)
        {
            KeyBindName = keyBindName;
            KeyBindAction = keyBindAction;
            ButtonBindName = buttonBindName;
            ButtonBindAction = buttonBindAction;
        }
        
        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {

            var NewOption = new SideBySideOptions(new KeyBind(KeyBindName, KeyBindAction),
                new ButtonBind(ButtonBindName, ButtonBindAction));

            var option = NewOption.CreateMenuOption(c, modlistMenu, Instance, false);
            
            if (AddToList)
            {
                Instance.MenuOrder.Add(option);
            }
            return new GameObjectPair(option);
        }
    }

    public class SideBySideOptions : MenuOption
    {
        public MenuOption LeftOption;
        public MenuOption RightOption;
        public string Name { get; }

        public SideBySideOptions(MenuOption leftOption, MenuOption rightOption)
        {
            LeftOption = leftOption;
            RightOption = rightOption;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu,
            ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {

            if (LeftOption is KeyAndButtonBind or SideBySideOptions ||
                RightOption is KeyAndButtonBind or SideBySideOptions)
            {
                Modding.Logger.LogError("[Satchel] - You cannot create Side by side options inside itself");
                return new GameObjectPair();
            }

            var layout = c.Layout as RegularGridLayout;
            var l = layout.ItemAdvance;
            l.x = new RelLength(750f);
            layout.ChangeColumns(2, newSize: l);

            var option1 = LeftOption.CreateMenuOption(c, modlistMenu, Instance, false);
            var option2 = RightOption.CreateMenuOption(c, modlistMenu, Instance, false);

            l.x = new RelLength(1920f);
            layout.ChangeColumns(1, 0.25f, l);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option1, option2));
            }
            return new GameObjectPair(option1, option2);
        }
    }
}
