using Modding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Satchel.BetterMenus;

namespace Satchel.BetterMenus
{
#nullable enable
    /// <summary>
    /// A class used to build MenuOptions.
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class MenuOptionBuilder: ICloneable
    {

        private readonly List<Element> options = new();
        private bool disposedValue;

        /// <summary>
        /// Creates a new MenuOptionBuilder.
        /// </summary>
        public MenuOptionBuilder() { }

        internal MenuOptionBuilder(List<Element> _options) =>
            options = _options;

        #region Add

        /// <summary>
        /// Adds a custom Element to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="option">The custom option to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddOption(Element option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("Could not add custom item.");
            return this;
        }

        /// <summary>
        /// Adds the List(Element) to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="customOptions">The list to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddList(List<Element> customOptions)
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
        public MenuOptionBuilder AddKeyBind(KeyBind option)
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
        public MenuOptionBuilder AddKeyBind(string name, InControl.PlayerAction action, out KeyBind? bind)
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
        public MenuOptionBuilder AddButtonBind(ButtonBind button)
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
        public MenuOptionBuilder AddButtonBind(string name, InControl.PlayerAction playerAction, out ButtonBind? bind)
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
        public MenuOptionBuilder AddHorizontalOption(HorizontalOption option)
        {
            if (!disposedValue && option != null) options.Add(option);
            else Modding.Logger.LogError("[Satchel] - Could not add horizontaloption.");
            return this;
        }

        /// <summary>
        /// Adds a HorizontalOption to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="name">The name of the HorizontalOption.</param>
        /// <param name="description">The description to be displayed.</param>
        /// <param name="values">The possible values of the HorizontalOption.</param>
        /// <param name="applySetting">The Action(int) to execute when the value is changed.</param>
        /// <param name="loadSetting">The Func(int) to load.</param>
        /// <param name="option">The created HorizontalOption. Null if the HorizontalOption couldn't be created.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddHorizontalOption
        (string name, 
        string description, 
        string[] values, 
        Action<int> applySetting,
        Func<int> loadSetting, 
        out HorizontalOption option)
        {
            option = new HorizontalOption(name, description, values, applySetting, loadSetting);
            options.Add(option);
            return this;
        }

        /// <summary>
        /// Adds a MenuButton to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="button">The MenuButton to add.</param>
        /// <returns>The current MenuOptionBuilder instance.</returns>
        public MenuOptionBuilder AddMenuButton(MenuButton button)
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
        public MenuOptionBuilder AddMenuButton(string name, string description, Action<UnityEngine.UI.MenuButton> submitAction, out MenuButton? button)
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
        public MenuOptionBuilder AddTextPanel(TextPanel panel)
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
        public MenuOptionBuilder AddTextPanel(string name, out TextPanel? panel, float width = 1500f)
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
        public MenuOptionBuilder AddStaticPanel(StaticPanel panel)
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
        public MenuOptionBuilder AddStaticPanel(string name, Action<GameObject> createCustomItem, out StaticPanel? panel, float width = 1500f)
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
        /// Adds the provided MenuRow to the MenuOptionBuilder.
        /// </summary>
        /// <param name="options">The MenuRow to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddMenuRow(MenuRow options)
        {
            if (!disposedValue && options != null) this.options.Add(options);
            else Modding.Logger.LogError("[Satchel] - Couldn't create MenuRow.");
            return this;
        }

        /// <summary>
        /// Adds MenuRow to the current MenuOptionBuilder.
        /// </summary>
        /// <param name="LeftElement">The left option to add.</param>
        /// <param name="RightElement">The right option to add.</param>
        /// <param name="option">The created MenuRow. Null if the options could not be added.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddMenuRow(
            Element LeftElement, 
            Element RightElement, 
            out MenuRow? option,
            string Id)
        {
            option = default;
            if (!disposedValue && LeftElement != null & RightElement != null)
            {
                option = new MenuRow(LeftElement, RightElement,Id:Id);
                options.Add(option);
            }
            return this;
        } 
        
        /// <summary>
        /// Adds the provided CustomSlider to the MenuOptionBuilder.
        /// </summary>
        /// <param name="slider">The Slider to add.</param>
        /// <returns>The current MenuOptionBuilder.</returns>
        public MenuOptionBuilder AddCustomSlider(CustomSlider slider)
        {
            if (!disposedValue && options != null) this.options.Add(slider);
            else Modding.Logger.LogError("[Satchel] - Couldn't create Volume Slider.");
            return this;
        }
        
        /// <summary>
        /// Creates a new CustomSlider instance.
        /// </summary>
        /// <param name="name">The name to be displayed.</param>
        /// <param name="storeValue">The Action that will be invoked when the slider is moved. Use the float paramter to save the value to use in mod.</param>
        /// <param name="savedValue">The initial value that you need the volume slider to be, probably from previous session or a default</param>
        public MenuOptionBuilder AddCustomSlider(string name, Action<float> storeValue, Func<float> savedValue, out CustomSlider? option)
        {
            option = default;
            if (!disposedValue && !string.IsNullOrEmpty(name))
            {
                option = new CustomSlider(name,storeValue,savedValue);
                options.Add(option);
            }
            return this;
        }
        #endregion

        /// <summary>
        /// Build the current MenuOptionBuilder into an array of MenuOptions.
        /// </summary>
        /// <returns>The array of MenuOptions created.</returns>
        public Element[]? Build()
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
        public new Element[]? Build(MenuOptionBuilder builder) =>
            builder.Build();

        protected void Dispose(bool disposing)
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
        public MenuOptionBuilder Reset()
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
        public object Clone() =>
            new MenuOptionBuilder(options);

        private string GetDebuggerDisplay()
            => ToString();

    }

#nullable restore
}
