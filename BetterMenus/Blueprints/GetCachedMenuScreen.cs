namespace Satchel.BetterMenus;

public static partial class Blueprints
{
    /// <summary>
    /// Gets or creates new menuscreen to use in modmenu
    /// </summary>
    /// <param name="MenuRef">The Menu you want the MenuScreen of</param>
    /// <param name="returnScreen">The screen to return to on esc/back button press</param>
    /// <returns></returns>
    public static MenuScreen GetCachedMenuScreen(this Menu MenuRef, MenuScreen returnScreen) {
        if (MenuRef.menuScreen == null) {
            return MenuRef.GetMenuScreen(returnScreen);
        }
        else {
            var button = MenuRef.menuScreen.controls.gameObject.transform.Find("BackButton").GetComponent<UnityEngine.UI.MenuButton>();
            button.submitAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen);
            button.customCancelAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen);
            return MenuRef.menuScreen;
        }
    }
}