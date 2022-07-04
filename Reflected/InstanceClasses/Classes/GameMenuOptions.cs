using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameMenuOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameMenuOptionsR : InstanceClassWrapper<GameMenuOptions>
{
    public GameMenuOptionsR(GameMenuOptions _orig) : base(_orig)
    {
    }

    public MenuScreen gameOptionsMenuScreen
    {
        get => orig.gameOptionsMenuScreen;
        set => orig.gameOptionsMenuScreen = value;
    }

    public MenuSelectable languageOption
    {
        get => orig.languageOption;
        set => orig.languageOption = value;
    }

    public GameObject languageOptionDescription
    {
        get => orig.languageOptionDescription;
        set => orig.languageOptionDescription = value;
    }

    public MenuSelectable backerOption
    {
        get => orig.backerOption;
        set => orig.backerOption = value;
    }

    public MenuSelectable nativeAchievementsOption
    {
        get => orig.nativeAchievementsOption;
        set => orig.nativeAchievementsOption = value;
    }

    public MenuSelectable resetButton
    {
        get => orig.resetButton;
        set => orig.resetButton = value;
    }

    public MenuSelectable applyButton
    {
        get => orig.applyButton;
        set => orig.applyButton = value;
    }

    public bool reconfigureOnEnable
    {
        get => orig.reconfigureOnEnable;
        set => orig.reconfigureOnEnable = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void ConfigureNavigation()
    {
        orig.ConfigureNavigation();
    }
}