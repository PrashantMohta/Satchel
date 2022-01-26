using System;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;
using Lang = Language.Language;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A class to hold helper functions for creating ICustomMenuMods
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// this should contain the prefab of a slider once we have it
        /// </summary>
        public static GameObject SliderPrefab;
        /// <summary>
        /// creates a standard menu builder with a grid nav graph
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        public static MenuBuilder CreateMenuBuilder(string Title)
        {
            return new MenuBuilder(UIManager.instance.UICanvas.gameObject, Title)
                .CreateTitle(Title, MenuTitleStyle.vanillaStyle)
                .CreateContentPane(RectTransformData.FromSizeAndPos(
                    new RelVector2(new Vector2(1920f, 903f)),
                    new AnchoredPosition(
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0f, -60f)
                    )
                ))
                .CreateControlPane(RectTransformData.FromSizeAndPos(
                    new RelVector2(new Vector2(1920f, 259f)),
                    new AnchoredPosition(
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0f, -502f)
                    )
                ))
                .SetDefaultNavGraph(new GridNavGraph(1));
        }
        /// <summary>
        /// Adds a back button to the menu in the center of the control pane
        /// </summary>
        /// <param name="builder">the builder to put the back button on</param>
        /// <param name="returnScreen">the screen previous screen(that game with go to when button is pressed)</param>
        /// <param name="backButton">the button created</param>
        /// <returns>The menu builder with a back button</returns>
        public static MenuBuilder AddBackButton(this MenuBuilder builder, MenuScreen returnScreen, out UnityEngine.UI.MenuButton backButton)
        {
            UnityEngine.UI.MenuButton BackButton = null;
            builder.AddControls(
                new SingleContentLayout(new AnchoredPosition(
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0f, -64f)
                )), c => c.AddMenuButton(
                    "BackButton",
                    new MenuButtonConfig
                    {
                        Label = Lang.Get("NAV_BACK", "MainMenu"),
                        CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen),
                        SubmitAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen),
                        Style = MenuButtonStyle.VanillaStyle,
                        Proceed = true
                    }, out BackButton));
            backButton = BackButton;
            return builder;
        }

        /// <summary>
        /// Adds a back button to the menu in the center of the control pane
        /// </summary>
        /// <param name="builder">the builder to put the back button on</param>
        /// <param name="returnScreen">the screen previous screen(that game with go to when button is pressed)</param>
        /// <returns>The menu builder with a back button</returns>
        public static MenuBuilder AddBackButton(this MenuBuilder builder, MenuScreen returnScreen) => AddBackButton(builder, returnScreen, out _);

        /// <summary>
        /// Adds a button in the control pane near the back button
        /// </summary>
        /// <param name="builder">the builder to put the back button on</param>
        /// <param name="name">The name of the button</param>
        /// <param name="offset">the offset of the button from the center of the control pane (at bottom of screen)</param>
        /// <param name="cancelAction">The action that will be invoked when the user pressed esc while this is the current selected element</param>
        /// <param name="submitAction">the action that will be invoked when the user pressed this menubutton</param>
        /// <returns>The menu builder with the control button</returns>
        public static MenuBuilder AddControlButton(this MenuBuilder builder, string name, Vector2 offset, Action<MenuSelectable> cancelAction, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            return builder.AddControls(
                new SingleContentLayout(new AnchoredPosition(
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0.5f, 0.5f),
                    offset
                )), c => c.AddMenuButton(
                    name,
                    new MenuButtonConfig
                    {
                        Label = name,
                        CancelAction = cancelAction,
                        SubmitAction = submitAction,
                        Style = MenuButtonStyle.VanillaStyle,
                        Proceed = true
                    }));
        }

    }
}


