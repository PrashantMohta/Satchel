namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GameMenuOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameMenuOptionsR:InstanceClassWrapper<GameMenuOptions>
{
public GameMenuOptionsR(GameMenuOptions _orig) : base(_orig) {}
public MenuScreen gameOptionsMenuScreen
{
get => orig.gameOptionsMenuScreen;
set => orig.gameOptionsMenuScreen = value;
}

public UnityEngine.UI.MenuSelectable languageOption
{
get => orig.languageOption;
set => orig.languageOption = value;
}

public UnityEngine.GameObject languageOptionDescription
{
get => orig.languageOptionDescription;
set => orig.languageOptionDescription = value;
}

public UnityEngine.UI.MenuSelectable backerOption
{
get => orig.backerOption;
set => orig.backerOption = value;
}

public UnityEngine.UI.MenuSelectable nativeAchievementsOption
{
get => orig.nativeAchievementsOption;
set => orig.nativeAchievementsOption = value;
}

public UnityEngine.UI.MenuSelectable resetButton
{
get => orig.resetButton;
set => orig.resetButton = value;
}

public UnityEngine.UI.MenuSelectable applyButton
{
get => orig.applyButton;
set => orig.applyButton = value;
}

public bool reconfigureOnEnable
{
get => orig.reconfigureOnEnable;
set => orig.reconfigureOnEnable = value;
}



public void OnEnable () =>
CallMethod();

public void ConfigureNavigation () =>
orig.ConfigureNavigation();

}
}
