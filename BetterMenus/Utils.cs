using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine.UI;
using Lang = Language.Language;

namespace Satchel.BetterMenus;

public static class Utils
{
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
                    CancelAction = _ => GoToMenuScreen(returnScreen),
                    SubmitAction = _ => GoToMenuScreen(returnScreen),
                    Style = MenuButtonStyle.VanillaStyle,
                    Proceed = true
                }, out BackButton));
        backButton = BackButton;
        return builder;
    }

    public static MenuBuilder AddBackButton(this MenuBuilder builder, MenuScreen returnScreen) => AddBackButton(builder, returnScreen, out _);

    //add a button near the back button
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

    public static MenuBuilder AddBackButton(this MenuBuilder builder, Menu menuRef, out UnityEngine.UI.MenuButton backButton)
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
                    CancelAction = _ => menuRef.CancelAction(),
                    SubmitAction = _ => menuRef.CancelAction(),
                    Style = MenuButtonStyle.VanillaStyle,
                    Proceed = true
                }, out BackButton));
        backButton = BackButton;
        return builder;
    }

    public static void GoToMenuScreen(MenuScreen menuScreen) => UIManager.instance.UIGoToDynamicMenu(menuScreen);

    public static Animator CreateRegularMenuCursor(GameObject parent, bool leftSide)
    {
        var cursor = new GameObject("Cursor" + (leftSide ? "Left" : "Right"));
        cursor.transform.SetParent(parent.transform, false);
        // CanvasRenderer
        cursor.AddComponent<CanvasRenderer>();
        // RectTransform
        var cursorRt = cursor.AddComponent<RectTransform>();
        Vector2 sizeDelta, pivot, anchorMin, anchorMax, anchoredPosition;
        Vector3 localScale;
        
        // from mapi code
        if (leftSide)
        {
            sizeDelta = new Vector2(164f, 119f);
            pivot = new Vector2(0.5f, 0.5f);
            anchorMin = new Vector2(0f, 0.5f);
            anchorMax = new Vector2(0f, 0.5f);
            anchoredPosition = new Vector2(-65f, 0f);
            localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }
        else
        {
            sizeDelta = new Vector2(164f, 119f);
            pivot = new Vector2(0.5f, 0.5f);
            anchorMin = new Vector2(1f, 0.5f);
            anchorMax = new Vector2(1f, 0.5f);
            anchoredPosition = new Vector2(65f, 0f);
            localScale = new Vector3(-0.4f, 0.4f, 0.4f);
        }
        
        cursorRt.sizeDelta = sizeDelta;
        cursorRt.pivot = pivot;
        cursorRt.anchorMin = anchorMin;
        cursorRt.anchorMax = anchorMax;
        cursorRt.anchoredPosition = anchoredPosition;
        cursorRt.localScale = localScale;
         
        
        // Animator
        var cursorAnimator = cursor.AddComponent<Animator>();
        cursorAnimator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
        cursorAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        cursorAnimator.applyRootMotion = false;
        // Image
        cursor.AddComponent<Image>();

        return cursorAnimator;
    }
}


