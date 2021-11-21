using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modding;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;

namespace Satchel.MenuOptions
{
    /// <summary>
    /// Represents a pair of GameObjects.
    /// </summary>
    public class GameObjectPair
    {
        /// <summary>
        /// The left GameObject.
        /// </summary>
        public GameObject LeftGo;
        /// <summary>
        /// The right GameObject.
        /// </summary>
        public GameObject RightGo;

        /// <summary>
        /// Generates a GameObjectPair from 2 GameObjects.
        /// </summary>
        /// <param name="LeftGo">The left GameObject to add.</param>
        /// <param name="RightGo">The right GameObject to add.</param>
        public GameObjectPair(GameObject LeftGo, GameObject RightGo)
        {
            this.LeftGo = LeftGo;
            this.RightGo = RightGo;
        }

        /// <summary>
        /// Generates a GameObjectPair when there is only 1 GameObject
        /// </summary>
        /// <param name="LeftGo">The left GameObject to add.</param>
        public GameObjectPair(GameObject LeftGo)
        {
            this.LeftGo = LeftGo;
            RightGo = ISlightlyBetterMenuMod.TempObj;
        }
        /// <summary>
        /// Generates a new GameObjectPair from the provided GameObjectPair.
        /// </summary>
        /// <param name="menuOptionGos">The GameObjectPair to build on.</param>
        public GameObjectPair(GameObjectPair menuOptionGos)
        {
            LeftGo = menuOptionGos.LeftGo;
            RightGo = menuOptionGos.RightGo;
        }
        /// <summary>
        /// Generates a new GameObjectPair from 2 GameObjectPairs that contain 1 Real GameObject each
        /// </summary>
        /// <param name="LeftOptionGo">The left GameObjectPair.</param>
        /// <param name="RightOptionGo">The right GameObjectPair.</param>
        public GameObjectPair(GameObjectPair LeftOptionGo, GameObjectPair RightOptionGo)
        {
            LeftGo = LeftOptionGo.LeftGo;
            RightGo = RightOptionGo.LeftGo;
        }
        /// <summary>
        /// Generates an empty GameObjectPair. To be used as instead of null
        /// </summary>
        public GameObjectPair()
        {
            LeftGo = ISlightlyBetterMenuMod.TempObj;
            RightGo = ISlightlyBetterMenuMod.TempObj;
        }
    }

    #region Interfaces/Bases
    public interface IMenuOption
    {
        string Name { get; }

        public abstract GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true);
    }

    public interface IPrimaryMenuOption
    {
        public abstract GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true);
        public abstract void AddUpdateMenuAction(Action UpdateMenu);
    }
    #endregion

    /// <summary>
    /// A KeyBind.
    /// </summary>
    public class KeyBind : IMenuOption
    {
        /// <summary>
        /// The PlayerAction connected to this bind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new KeyBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this bind.</param>
        public KeyBind(string name,InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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
    public class ButtonBind : IMenuOption
    {
        /// <summary>
        /// The PlayerAction connected to this ButtonBind.
        /// </summary>
        public InControl.PlayerAction PlayerAction;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new ButtonBind.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="playerAction">The PlayerAction connected to this ButtonBind.</param>
        public ButtonBind(string name, InControl.PlayerAction playerAction)
        {
            Name = name;
            PlayerAction = playerAction;
        }
        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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
    
    /// <summary>
    /// A horizontal option.
    /// </summary>
    public class HorizontalOption : IMenuOption, IPrimaryMenuOption
    {
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        /// <summary>
        /// The values the HorizontalOption can have.
        /// </summary>
        public string[] Values;
        /// <summary>
        /// Triggered when a setting is applied.
        /// </summary>
        public Action<int> ApplySetting;
        /// <summary>
        /// The Func(int) to call when settings are being loaded.
        /// </summary>
        public Func<int> LoadSetting;

        /// <summary>
        /// Creates a new HorizontalOption.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="values">The values the HorizontalOption can have.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="applySetting">Triggered when a setting is applied.</param>
        /// <param name="loadSetting">The Func(int) to call when settings are being loaded.</param>
        public HorizontalOption(string name, string[] values, string description, Action<int> applySetting, Func<int> loadSetting)
        {
            Name = name;
            Description = description;
            Values = values;
            ApplySetting = applySetting;
            LoadSetting= loadSetting;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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

        /// <summary>
        /// Adds a new Action to when the setting is applied.
        /// </summary>
        /// <param name="UpdateMenu">The Action to add.</param>
        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            ApplySetting += _ => UpdateMenu.Invoke();
        }
    }
    /// <summary>
    /// A menu button.
    /// </summary>
    public class MenuButton : IMenuOption, IPrimaryMenuOption
    {
        /// <summary>
        /// The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.
        /// </summary>
        public Action<UnityEngine.UI.MenuButton> SubmitAction;
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a MenuButton.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="submitAction">The Action(UnityEngine.UI.MenuButton) to call when a value is submitted.</param>
        public MenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            Name = name;
            Description = description;
            SubmitAction = submitAction;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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

        /// <summary>
        /// Adds a new Action to when the setting is applied.
        /// </summary>
        /// <param name="UpdateMenu">The Action to add.</param>
        public void AddUpdateMenuAction(Action UpdateMenu)
        {
            SubmitAction += _ => UpdateMenu.Invoke();
        }
    }
    /// <summary>
    /// A TextPanel.
    /// </summary>
    public class TextPanel : IMenuOption
    {
        /// <summary>
        /// The width of the TextPanel (default 1500f).
        /// </summary>
        public float Width;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new TextPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="width">The width of the TextPanel.</param>
        public TextPanel(string name, float width = 1500f)
        {
            Name = name;
            Width = width;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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
    /// <summary>
    /// A static panel.
    /// </summary>
    public class StaticPanel: IMenuOption
    {
        /// <summary>
        /// Use this Action to create the Custom Object you want to add. The GameObject paramater in the action is the GameObject that will be the parent of of custom object
        /// </summary>
        public Action<GameObject> CreateCustomItem;
        /// <summary>
        /// The width of the panel (default 1500f).
        /// </summary>
        public float Width;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new StaticPanel.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="createCustomItem">The Action(GameObject) te be called on creation.</param>
        /// <param name="width">The width of the panel.</param>
        public StaticPanel(string name, Action<GameObject> createCustomItem, float width = 1500f)
        {
            Name = name;
            CreateCustomItem = createCustomItem;
            Width = width;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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

    /// <summary>
    /// An option that toggles a mod.
    /// </summary>
    public class ModToggleOption: IMenuOption
    {
        /// <summary>
        /// The ModToggleDelegates of the mod.
        /// </summary>
        public ModToggleDelegates ToggleDelegates;
        /// <summary>
        /// The description to be displayed.
        /// </summary>
        public string Description;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new ModToggleOption.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="toggleDelegates">The ModToggleDelegates of the mod.</param>
        /// <param name="description">The description to be displayed.</param>
        public ModToggleOption(string name, ModToggleDelegates toggleDelegates, string description)
        {
            Name = name;
            ToggleDelegates = toggleDelegates;
            Description = description;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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

    /// <summary>
    /// A hideable menu option.
    /// </summary>
    public class HideableMenuOption : IMenuOption
    {
        /// <summary>
        /// The primary option.
        /// </summary>
        public IPrimaryMenuOption PrimaryOption;
        /// <summary>
        /// The sub-options.
        /// </summary>
        public List<IMenuOption> SubOptions;
        //the function that will return a bool. the bool will determine whether the sub options should show or not
        /// <summary>
        /// The Func(bool) that hides/shows the options. (The bool determines whether the sub options should show or not.)
        /// </summary>
        public Func<bool> EnableSubOptions;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        private List<GameObjectPair> AllSubOptions = new List<GameObjectPair>();

        /// <summary>
        /// Creates a new HideableMenuOption.
        /// </summary>
        /// <param name="primaryOption">The primary option.</param>
        /// <param name="subOptions">The sub-options.</param>
        /// <param name="enableSubOptions">The Func(bool) that hides/shows the options. (The bool determines whether the sub options should show or not.)</param>
        public HideableMenuOption(IPrimaryMenuOption primaryOption, List<IMenuOption> subOptions,Func<bool> enableSubOptions)
        {
            PrimaryOption = primaryOption;
            SubOptions = subOptions;
            EnableSubOptions = enableSubOptions;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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
            
            foreach (IMenuOption menuOption in SubOptions)
            {
                var option = menuOption.CreateMenuOption(c, modlistMenu,Instance, false);
                AllSubOptions.Add(option);
                Instance.MenuOrder.Add(option);
            }

            return primaryoption;
        }
    }
    
    /// <summary>
    /// A bind for a button and a key.
    /// </summary>
    public class KeyAndButtonBind : IMenuOption
    {
        /// <summary>
        /// The name of the KeyBind.
        /// </summary>
        public string KeyBindName;
        /// <summary>
        /// The PlayerAction of the KeyBind.
        /// </summary>
        public InControl.PlayerAction KeyBindAction;
        /// <summary>
        /// The name of the ButtonBind,
        /// </summary>
        public string ButtonBindName;
        /// <summary>
        /// The PlayerAction of the ButtonBind.
        /// </summary>
        public InControl.PlayerAction ButtonBindAction;
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Creates a new KeyAndButtonBind.
        /// </summary>
        /// <param name="keyBindName">The name of the KeyBind.</param>
        /// <param name="keyBindAction">The PlayerAction of the KeyBind.</param>
        /// <param name="buttonBindName">The name of the ButtonBind.</param>
        /// <param name="buttonBindAction">The PlayerAction of the ButtonBind.</param>
        public KeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction)
        {
            KeyBindName = keyBindName;
            KeyBindAction = keyBindAction;
            ButtonBindName = buttonBindName;
            ButtonBindAction = buttonBindAction;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
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

    /// <summary>
    /// A collection of side-by-side options.
    /// </summary>
    public class SideBySideOptions : IMenuOption
    {
        /// <summary>
        /// The left options.
        /// </summary>
        public IMenuOption LeftOption;

        /// <summary>
        /// The right options.
        /// </summary>
        public IMenuOption RightOption;

        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new SideBySideOptions instance.
        /// </summary>
        /// <param name="leftOption">The left options.</param>
        /// <param name="rightOption">The right options.</param>
        public SideBySideOptions(IMenuOption leftOption, IMenuOption rightOption)
        {
            LeftOption = leftOption;
            RightOption = rightOption;
        }

        /// <summary>
        /// Adds the MenuOption into the ModMenu.
        /// </summary>
        /// <returns>The created GameObjectPair which can be used to add to the corresponding Lists.</returns>
        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance,
            bool AddToList = true)
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
    public class VolumeSlider : IMenuOption
    {
        /// <summary>
        /// The name to be displayed.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.
        /// </summary>
        public Action<float> StoreValue;
        
        /// <summary>
        /// The initial value that you need the volume slider to be, probably from previous session or a default
        /// </summary>
        public Func<int> SavedValue;


        /// <summary>
        /// Creates a new VolumeSlider instance.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="storeValue">The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.</param>
        /// <param name="savedValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        public VolumeSlider(string name, Action<float> storeValue, Func<int> savedValue)
        {
            Name = name;
            StoreValue = storeValue;
            SavedValue = savedValue;
        }

        public GameObjectPair CreateMenuOption(ContentArea c, MenuScreen modlistMenu, ISlightlyBetterMenuMod Instance, bool AddToList = true)
        {
            c.AddVolumeSlider(Name, 105f, StoreValue, SavedValue, out var option);

            if (AddToList)
            {
                Instance.MenuOrder.Add(new GameObjectPair(option));
            }

            return new GameObjectPair(option);
        }
    }
}
