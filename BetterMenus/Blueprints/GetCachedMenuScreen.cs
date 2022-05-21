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
        
        return MenuRef.menuScreen;
        
    }
}