namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MainMenuOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MainMenuOptionsR:InstanceClassWrapper<MainMenuOptions>
{
public MainMenuOptionsR(MainMenuOptions _orig) : base(_orig) {}
public UnityEngine.UI.MenuButton startButton
{
get => orig.startButton;
set => orig.startButton = value;
}

public UnityEngine.UI.MenuButton optionsButton
{
get => orig.optionsButton;
set => orig.optionsButton = value;
}

public UnityEngine.UI.MenuButton achievementsButton
{
get => orig.achievementsButton;
set => orig.achievementsButton = value;
}

public UnityEngine.UI.MenuButton extrasButton
{
get => orig.extrasButton;
set => orig.extrasButton = value;
}

public UnityEngine.UI.MenuButton quitButton
{
get => orig.quitButton;
set => orig.quitButton = value;
}

public UnityEngine.UI.Selectable itemToHighlight
{
get => orig.itemToHighlight;
set => orig.itemToHighlight = value;
}



public void ConfigureNavigation () =>
orig.ConfigureNavigation();

}
}
