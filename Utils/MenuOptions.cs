using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public GameObjectPair(GameObject LeftGo, GameObject RightGo)
        {
            this.LeftGo = LeftGo;
            this.RightGo = RightGo;
        }
        
        public GameObjectPair(GameObject LeftGo)
        {
            this.LeftGo = LeftGo;
            RightGo = ISlightlyBetterMenuMod.TempObj;
        }
        public GameObjectPair(GameObjectPair menuOptionGos)
        {
            LeftGo = menuOptionGos.LeftGo;
            RightGo = menuOptionGos.RightGo;
        }
        public GameObjectPair(GameObjectPair LeftOptionGo, GameObjectPair RightOptionGo)
        {
            LeftGo = LeftOptionGo.LeftGo;
            RightGo = RightOptionGo.LeftGo;
        }
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

#nullable enable
    public abstract class MenuOptionBuilderBase
    {
        //For context, I (Ruttie) made this, so it's probably bad.
        public static IMenuOption[]? Build(MenuOptionBuilder builder) =>
            builder.Build();
        public abstract MenuOptionBuilder AddList(List<IMenuOption> customOptions);
        public abstract MenuOptionBuilder AddOption(IMenuOption option);
        public abstract MenuOptionBuilder AddButtonBind(ButtonBind button);
        public abstract MenuOptionBuilder AddButtonBind(string name, InControl.PlayerAction playerAction, out ButtonBind? bind);
        public abstract MenuOptionBuilder AddHideableMenuOption(HideableMenuOption option);
        public abstract MenuOptionBuilder AddHideableMenuOption(IPrimaryMenuOption primaryOption, List<IMenuOption> subOptions, Func<bool> enableSubOptions, out HideableMenuOption? option);
        public abstract MenuOptionBuilder AddHorizontalOption(HorizontalOption option);
        public abstract MenuOptionBuilder AddHorizontalOption(string name, string[] values, string description, Action<int> applySetting, Func<int> loadSetting, out HorizontalOption option);
        public abstract MenuOptionBuilder AddKeyAndButtonBind(KeyAndButtonBind bind);
        public abstract MenuOptionBuilder AddKeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction, out KeyAndButtonBind? bind);
        public abstract MenuOptionBuilder AddKeyBind(KeyBind option);
        public abstract MenuOptionBuilder AddKeyBind(string name, InControl.PlayerAction action, out KeyBind? bind);
        public abstract MenuOptionBuilder AddMenuButton(MenuButton button);
        public abstract MenuOptionBuilder AddMenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction, out MenuButton? button);
        public abstract MenuOptionBuilder AddModToggleOption(ModToggleOption option);
        public abstract MenuOptionBuilder AddModToggleOption(string name, ModToggleDelegates toggleDelegates, string description, out ModToggleOption? option);
        public abstract MenuOptionBuilder AddSideBySideOptions(SideBySideOptions options);
        public abstract MenuOptionBuilder AddSideBySideOptions(IMenuOption leftOption, IMenuOption rightOption, out SideBySideOptions? option);
        public abstract MenuOptionBuilder AddStaticPanel(StaticPanel panel);
        public abstract MenuOptionBuilder AddStaticPanel(string name, Action<GameObject> createCustomItem, out StaticPanel? panel, float width = 1500f);
        public abstract MenuOptionBuilder AddTextPanel(TextPanel panel);
        public abstract MenuOptionBuilder AddTextPanel(string name, out TextPanel? panel, float width = 1500f);
        public abstract IMenuOption[]? Build();
        public abstract object Clone();
        public abstract MenuOptionBuilder Reset();
        protected abstract void Dispose(bool disposing);
    }
#nullable restore
    #endregion


    /// <summary>
    /// A class used to build MenuOptions.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MenuOptionBuilder : MenuOptionBuilderBase, ICloneable
    {
#nullable enable
        private readonly List<IMenuOption> options = new();
        private bool disposedValue;

        /// <summary>
        /// Creates a new MenuOptionBuilder.
        /// </summary>
        public MenuOptionBuilder() { }

        internal MenuOptionBuilder(List<IMenuOption> _options) =>
            options = _options;

        #region Add

        /// <summary>
        /// Adds a custom IMenuOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="option">The custom option to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddOption(IMenuOption option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("Could not add custom item.");
            return this;
        }

        /// <summary>
        /// Adds the List(IMenuOption) to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="customOptions">The list to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddList(List<IMenuOption> customOptions)
        {
            if (!disposedValue && customOptions.Count > 0)
                foreach (var option in customOptions) options.Add(option);
            else Modding.Logger.LogError("Could not add option list.");
            return this;
        }

        /// <summary>
        /// Adds a keybind.
        /// </summary>
        /// <param name="option">The keybind to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddKeyBind(KeyBind option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("[Satchel] - Could not add keybind.");
            return this;
        }

        /// <summary>
        /// Adds a keybind.
        /// </summary>
        /// <param name="name">The name of the keybind.</param>
        /// <param name="action">The keybind to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddKeyBind(string name, InControl.PlayerAction action, out KeyBind? bind)
        {
            bind = default;
            if (!disposedValue && name != null && name != string.Empty && action != null)
            {
                bind = new KeyBind(name, action);
                options.Add(bind);
            }
            else Modding.Logger.LogError("[Satchel] - Could not add keybind.");
            return this;
        }

        /// <summary>
        /// Adds a ButtonBind to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="button">The ButtonBind to add.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddButtonBind(ButtonBind button)
        {
            if (!disposedValue && button != null) options.Add(button);
            else Modding.Logger.LogError("[Satchel] - Could not add buttonbind.");
            return this;
        }

        /// <summary>
        /// Adds a ButtonBind to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the button.</param>
        /// <param name="playerAction">The PlayerAction to add.</param>
        /// <param name="bind">The bind created. Null if button couldn't be created.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddButtonBind(string name, InControl.PlayerAction playerAction, out ButtonBind? bind)
        {
            bind = default;
            if (!disposedValue && name != null && name != string.Empty && playerAction != null)
            {
                bind = new ButtonBind(name, playerAction);
                options.Add(bind);
            }
            else Modding.Logger.LogError("[Satchel] - Could not add buttonbind.");
            return this;
        }

        /// <summary>
        /// Adds a HorizontalOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="option">The HorizontalOption to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddHorizontalOption(HorizontalOption option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("[Satchel] - Could not add horizontaloption.");
            return this;
        }

        /// <summary>
        /// Adds a HorizontalOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the HorizontalOption.</param>
        /// <param name="values">The possible values of the HorizontalOption.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="applySetting">The Action(int) to execute when the value is changed.</param>
        /// <param name="loadSetting">The Func(int) to load.</param>
        /// <param name="option">The created HorizontalOption. Null if the HorizontalOption couldn't be created.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddHorizontalOption(string name, string[] values, string description, Action<int> applySetting, Func<int> loadSetting, out HorizontalOption option)
        {
            option = new HorizontalOption(name, values, description, applySetting, loadSetting);
            options.Add(option);
            return this;
        }

        /// <summary>
        /// Adds a MenuButton to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="button">The MenuButton to add.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddMenuButton(MenuButton button)
        {
            if (!disposedValue && button != null) options.Add(button);
            else Modding.Logger.LogError("[Satchel] - Couldn't add menubutton.");
            return this;
        }

        /// <summary>
        /// Adds a MenuButton to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the option.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="submitAction">The Action(UnityEngine.UI.MenuButton) to be executed.</param>
        /// <param name="button">The MenuButton added. Null if the button could not be added.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddMenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction, out MenuButton? button)
        {
            button = default;
            if (!disposedValue && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description) && submitAction != null)
            {
                button = new MenuButton(name, description, submitAction);
                options.Add(button);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't add menubutton");
            return this;
        }

        /// <summary>
        /// Adds a TextPanel to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="panel">The TextPanel to add.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddTextPanel(TextPanel panel)
        {
            if (!disposedValue && panel != null) options.Add(panel);
            else Modding.Logger.LogError("[Satchel] - Could not add TextPanel.");
            return this;
        }

        /// <summary>
        /// Adds a TextPanel to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the TextPanel</param>
        /// <param name="panel">The TextPanel created. Null if the panel could not be added.</param>
        /// <param name="width">The width of the TextPanel.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddTextPanel(string name, out TextPanel? panel, float width = 1500f)
        {
            panel = default;
            if (!disposedValue && !string.IsNullOrEmpty(name))
            {
                panel = new TextPanel(name, width);
                options.Add(panel);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't add TextPanel");
            return this;
        }

        /// <summary>
        /// Adds a StaticPanel to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="panel">The StaticPanel to add.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public override MenuOptionBuilder AddStaticPanel(StaticPanel panel)
        {
            if (!disposedValue && panel != null) options.Add(panel);
            else Modding.Logger.LogError("[Satchel] - Couldn't add StaticPanel.");
            return this;
        }

        /// <summary>
        /// Adds a StaticPanel to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the StaticPanel.</param>
        /// <param name="createCustomItem">The Action(GameObject) to execute when a custom item is created. (Dandy halp)</param>
        /// <param name="panel">The StaticPanel created. Null if the panel could not be added.</param>
        /// <param name="width">The width of the StaticPanel.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddStaticPanel(string name, Action<GameObject> createCustomItem, out StaticPanel? panel, float width = 1500f)
        {
            panel = default;
            if (!disposedValue && !string.IsNullOrEmpty(name) && createCustomItem != null)
            {
                panel = new StaticPanel(name, createCustomItem, width);
                options.Add(panel);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't add StaticPanel.");
            return this;
        }

        /// <summary>
        /// Adds a ModToggleOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="option">The ModToggleOption to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddModToggleOption(ModToggleOption option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("[Satchel] - Couldn't create ModToggleOption.");
            return this;
        }

        /// <summary>
        /// Adds a ModToggleOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the ModToggleOption.</param>
        /// <param name="toggleDelegates">The ModToggleDelegates to use.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="option">The created ModToggleOption. Null if the option could not be added.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddModToggleOption(string name, ModToggleDelegates toggleDelegates, string description, out ModToggleOption? option)
        {
            option = default;
            if (!disposedValue && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                option = new ModToggleOption(name, toggleDelegates, description);
                options.Add(option);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't create ModToggleOption.");
            return this;
        }

        /// <summary>
        /// Adds a HideableMenuOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="option">The HideableOption to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddHideableMenuOption(HideableMenuOption option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("[Satchel] - Coudln't create HideableMenuOption.");
            return this;
        }

        /// <summary>
        /// Adds a HideableMenuOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="primaryOption">The primary option.</param>
        /// <param name="subOptions">A List of suboptions.</param>
        /// <param name="enableSubOptions">The Func(bool) that determines whether to show the suboptions.</param>
        /// <param name="option">The HideableMenuOption created. Null if the option could not be added.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddHideableMenuOption(IPrimaryMenuOption primaryOption, List<IMenuOption> subOptions, Func<bool> enableSubOptions, out HideableMenuOption? option)
        {
            option = default;
            if (!disposedValue && primaryOption != null && subOptions.Count > 0 && enableSubOptions != null)
            {
                option = new HideableMenuOption(primaryOption, subOptions, enableSubOptions);
                options.Add(option);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't create HideableMenuOption.");
            return this;
        }

        /// <summary>
        /// Adds a KeyAndButtonBind to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="bind">The KeyAndButtonBind to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddKeyAndButtonBind(KeyAndButtonBind bind)
        {
            if (!disposedValue && bind != null) options.Add(bind);
            else Modding.Logger.LogError("[Satchel] - Couldn't create KeyAndButtonBind.");
            return this;
        }

        /// <summary>
        /// Adds a KeyAndButtonBind to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="keyBindName">The name of the keybind.</param>
        /// <param name="keyBindAction">The InControl.PlayerAction of the keybind.</param>
        /// <param name="buttonBindName">The name of the buttonbind.</param>
        /// <param name="buttonBindAction">The InControl.PlayerAction of the buttonbind</param>
        /// <param name="bind">The created KeyAndButtonBind. Null if the bind could not be added.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddKeyAndButtonBind(string keyBindName, InControl.PlayerAction keyBindAction, string buttonBindName, InControl.PlayerAction buttonBindAction, out KeyAndButtonBind? bind)
        {
            bind = default;
            if (!disposedValue && !string.IsNullOrEmpty(keyBindName) && keyBindAction != null && !string.IsNullOrEmpty(buttonBindName) && buttonBindAction != null)
            {
                bind = new KeyAndButtonBind(keyBindName, keyBindAction, buttonBindName, buttonBindAction);
                options.Add(bind);
            }
            else Modding.Logger.LogError("[Satchel] - Couldn't create KeyAndButtonBind");
            return this;
        }

        /// <summary>
        /// Adds the provided SideBySideOptions to the MenuOptionBuilder.
        /// </summary>
        /// <param name="options">The SideBySideOptions to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddSideBySideOptions(SideBySideOptions options)
        {
            if (!disposedValue && options != null) this.options.Add(options);
            else Modding.Logger.LogError("[Satchel] - Couldn't create SideBySideOptions.");
            return this;
        }

        /// <summary>
        /// Adds SideBySideOptions to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="leftOption">The left option to add.</param>
        /// <param name="rightOption">The right option to add.</param>
        /// <param name="option">The created SideBySideOptions. Null if the options could not be added.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder AddSideBySideOptions(IMenuOption leftOption, IMenuOption rightOption, out SideBySideOptions? option)
        {
            option = default;
            if (!disposedValue && leftOption != null & rightOption != null)
            {
                option = new SideBySideOptions(leftOption, rightOption);
                options.Add(option);
            }
            return this;
        }
        #endregion

        /// <summary>
        /// Build the current MenuOptionBuilder into an array of MenuOptions.
        /// </summary>
        /// <returns>The array of MenuOptions created.</returns>
        public override IMenuOption[]? Build()
        {
            if (disposedValue || options.Count <= 0) Modding.Logger.LogError("[Satchel] - There is nothing to build!");
            else
            {
                var built = options.ToArray();
                Reset();
                return built;
            }
            return null;
        }
        
        /// <summary>
        /// Builds an MenuOptionBuilder.
        /// </summary>
        /// <param name="builder">The MenuOptionBuilder to build.</param>
        /// <returns>The built MenuOptionBuilder.</returns>
        public new IMenuOption[]? Build(MenuOptionBuilder builder) => 
            builder.Build();

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    options.Clear();
                }
                disposedValue = true;
            }
        }

        /// <summary>
        /// Resets this MenuOptionBuilder.
        /// </summary>
        /// <returns>A backup of the current MenuOptionBuilder.</returns>
        public override MenuOptionBuilder Reset()
        {
            var backup = this;
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
            return backup;
        }

        /// <summary>
        /// Clones the current MenuOptionBuilder.
        /// </summary>
        /// <returns>The cloned MenuOptionBuilder.</returns>
        public override object Clone() =>
            new MenuOptionBuilder(options);

        private string GetDebuggerDisplay()
            => ToString();
#nullable restore
    }


    internal sealed class BuildExample
    {
        public MenuScreen GetMenuScreen(MenuScreen modListMenu, ModToggleDelegates? toggleDelegates)
        {
            return new ISlightlyBetterMenuMod().GetMenuScreen("", modListMenu, new MenuOptionBuilder()
                .AddKeyBind("Test", null, out _) //Will add a KeyBind.
                .AddKeyBind("Test2", null, out var Bind) //Will add a KeyBind and store it.
                .AddTextPanel("Test3", out _, 1000f) //Will add a TextPanel.
                .AddHorizontalOption(new HorizontalOption("Name", new string[] { "Op1", "Op2" }, "lol", null, null)) //Will attempt to add a Horizontal option.
                                                                                                                     //This will likely go weird, but that's a problem
                                                                                                                     //for the one that made HorizontalOption.
                .AddHorizontalOption("Name", new string[] { "Op1" }, "Desc", null, null, out _) //Will log an error saying that the option couldn't be added. (Because null values were given.)
                .AddTextPanel("", out _) //Will log an error saying the TextPanel couldn't be added. (Because the name value is an empty string.)
                .Build()); //Builds the MenuOptionBuilder.
        }
    }

    public class KeyBind : IMenuOption
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
    public class ButtonBind : IMenuOption
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
    public class HorizontalOption : IMenuOption, IPrimaryMenuOption
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
    public class MenuButton : IMenuOption, IPrimaryMenuOption
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
    public class TextPanel : IMenuOption
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
    public class StaticPanel: IMenuOption
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

    public class ModToggleOption: IMenuOption
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

    public class HideableMenuOption : IMenuOption
    {
        public IPrimaryMenuOption PrimaryOption;
        public List<IMenuOption> SubOptions;
        //the function that will return a bool. the bool will determine whether the sub options should show or not
        public Func<bool> EnableSubOptions;
        public string Name { get; }
        
        private List<GameObjectPair> AllSubOptions = new List<GameObjectPair>();

        public HideableMenuOption(IPrimaryMenuOption primaryOption, List<IMenuOption> subOptions,Func<bool> enableSubOptions)
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
            
            foreach (IMenuOption menuOption in SubOptions)
            {
                var option = menuOption.CreateMenuOption(c, modlistMenu,Instance, false);
                AllSubOptions.Add(option);
                Instance.MenuOrder.Add(option);
            }

            return primaryoption;
        }
    }
    
    public class KeyAndButtonBind : IMenuOption
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

    public class SideBySideOptions : IMenuOption
    {
        public IMenuOption LeftOption;
        public IMenuOption RightOption;
        public string Name { get; }

        public SideBySideOptions(IMenuOption leftOption, IMenuOption rightOption)
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
