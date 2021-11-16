using System;
using System.Collections.Generic;
using System.Linq;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Satchel
{
    public static class ISlighlyBetterMenuMod
    {
        public static MenuScreen GetMenuScreen(string Title, MenuScreen modListMenu, List<MenuOption> AllMenuOptions)
        {
            MenuBuilder Menu = CustomModMenuUtils.CreateMenuBuilder(Title);
            UnityEngine.UI.MenuButton backButton = null;
            if (AllMenuOptions.Count > 5)
            {
                Menu.AddContent(new NullContentLayout(), c => c.AddScrollPaneContent(
                    new ScrollbarConfig
                    {
                        CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modListMenu),
                        Navigation = new Navigation
                        {
                            mode = Navigation.Mode.Explicit,
                            selectOnUp = backButton,
                            selectOnDown = backButton
                        },
                        Position = new AnchoredPosition
                        {
                            ChildAnchor = new Vector2(0f, 1f),
                            ParentAnchor = new Vector2(1f, 1f),
                            Offset = new Vector2(-310f, 0f)
                        }
                    },
                    new RelLength(AllMenuOptions.Count * 105f),
                    RegularGridLayout.CreateVerticalLayout(105f),
                    c => AddModMenuContent(AllMenuOptions, c, modListMenu)
                ));
            }
            else
            {
                Menu.AddContent(
                    RegularGridLayout.CreateVerticalLayout(105f),
                    c => AddModMenuContent(AllMenuOptions, c, modListMenu)
                );
            }

            Menu.AddBackButton(modListMenu, out backButton);
            return Menu.Build();
        }

        private static void AddModMenuContent(List<MenuOption> AllMenuOptions, ContentArea c, MenuScreen modListMenu)
        {
            Action<MenuSelectable> cancelAction = _ => UIManager.instance.UIGoToDynamicMenu(modListMenu);
            foreach (var menuOption in AllMenuOptions)
            {
                if (menuOption is HorizontalOption horizontaloption)
                {
                    c.AddHorizontalOption(
                        horizontaloption.Name,
                        new HorizontalOptionConfig
                        {
                            ApplySetting = (_, i) => horizontaloption.Saver(i),
                            RefreshSetting = (s, _) => s.optionList.SetOptionTo(horizontaloption.Loader()),
                            CancelAction = cancelAction,
                            Description = string.IsNullOrEmpty(horizontaloption.Description)
                                ? null
                                : new DescriptionInfo
                                {
                                    Text = horizontaloption.Description
                                },
                            Label = horizontaloption.Name,
                            Options = horizontaloption.Values,
                            Style = HorizontalOptionStyle.VanillaStyle
                        },
                        out var option
                    );
                    option.menuSetting.RefreshValueFromGameSettings();
                }
                else if (menuOption is KeyBind keybind)
                {
                    c.AddKeybind(
                        keybind.Name,
                        keybind.PlayerAction,
                        new KeybindConfig
                        {
                            CancelAction = cancelAction,
                            Label = keybind.Name,
                        }, out var option);
                }
                else if (menuOption is ButtonBind buttonbind)
                {
                    c.AddButtonBind(
                        buttonbind.Name,
                        buttonbind.PlayerAction,
                        new ButtonBindConfig
                        {
                            CancelAction = cancelAction,
                            Label = buttonbind.Name,
                        }, out var option);
                }
                else if (menuOption is MenuButton menubutton)
                {
                    c.AddMenuButton(
                        menubutton.Name,
                        new MenuButtonConfig
                        {
                            CancelAction = cancelAction,
                            Description = string.IsNullOrEmpty(menubutton.Description)
                                ? null
                                : new DescriptionInfo
                                {
                                    Text = menubutton.Description
                                },
                            Label = menubutton.Name,
                            Proceed = false,
                            SubmitAction = menubutton.SubmitAction,
                        }, out var option);
                }
                else if (menuOption is TextPanel textpanel)
                {
                    c.AddTextPanel(
                        textpanel.Name,
                        new RelVector2(new Vector2(textpanel.Width, 105f)),
                        new TextPanelConfig
                        {
                            Anchor = TextAnchor.MiddleCenter,
                            Font = TextPanelConfig.TextFont.TrajanBold,
                            Size = 46,
                            Text = textpanel.Name
                        }, out var option);
                }
            }
        }
    }
