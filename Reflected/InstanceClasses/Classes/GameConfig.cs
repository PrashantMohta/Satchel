namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameConfig allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameConfigR : InstanceClassWrapper<GameConfig>
{
    public GameConfigR(GameConfig _orig) : base(_orig)
    {
    }

    public bool showTargetSceneNamesOnGates
    {
        get => orig.showTargetSceneNamesOnGates;
        set => orig.showTargetSceneNamesOnGates = value;
    }

    public bool enableDebugButtons
    {
        get => orig.enableDebugButtons;
        set => orig.enableDebugButtons = value;
    }

    public bool enableCheats
    {
        get => orig.enableCheats;
        set => orig.enableCheats = value;
    }

    public bool disableSaveGame
    {
        get => orig.disableSaveGame;
        set => orig.disableSaveGame = value;
    }

    public bool useSaveEncryption
    {
        get => orig.useSaveEncryption;
        set => orig.useSaveEncryption = value;
    }

    public bool steamEnabled
    {
        get => orig.steamEnabled;
        set => orig.steamEnabled = value;
    }

    public bool galaxyEnabled
    {
        get => orig.galaxyEnabled;
        set => orig.galaxyEnabled = value;
    }

    public bool clearRecordsOnStart
    {
        get => orig.clearRecordsOnStart;
        set => orig.clearRecordsOnStart = value;
    }

    public bool unlockPermadeathMode
    {
        get => orig.unlockPermadeathMode;
        set => orig.unlockPermadeathMode = value;
    }

    public bool unlockBossRushMode
    {
        get => orig.unlockBossRushMode;
        set => orig.unlockBossRushMode = value;
    }

    public bool clearPreferredLanguageSetting
    {
        get => orig.clearPreferredLanguageSetting;
        set => orig.clearPreferredLanguageSetting = value;
    }

    public bool unlockAllMenuStyles
    {
        get => orig.unlockAllMenuStyles;
        set => orig.unlockAllMenuStyles = value;
    }

    public bool hideExtrasMenu
    {
        get => orig.hideExtrasMenu;
        set => orig.hideExtrasMenu = value;
    }

    public bool hideKeyboardMenu
    {
        get => orig.hideKeyboardMenu;
        set => orig.hideKeyboardMenu = value;
    }

    public bool hideLanguageOption
    {
        get => orig.hideLanguageOption;
        set => orig.hideLanguageOption = value;
    }

    public bool nativeAchievementsSettingAlwaysOn
    {
        get => orig.nativeAchievementsSettingAlwaysOn;
        set => orig.nativeAchievementsSettingAlwaysOn = value;
    }

    public bool hideVsyncSetting
    {
        get => orig.hideVsyncSetting;
        set => orig.hideVsyncSetting = value;
    }

    public bool enableTFRSetting
    {
        get => orig.enableTFRSetting;
        set => orig.enableTFRSetting = value;
    }

    public bool hideMonitorSetting
    {
        get => orig.hideMonitorSetting;
        set => orig.hideMonitorSetting = value;
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }
}