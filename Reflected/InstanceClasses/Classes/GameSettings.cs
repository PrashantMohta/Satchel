using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameSettingsR : InstanceClassWrapper<GameSettings>
{
    public GameSettingsR(GameSettings _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string settingLog
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string[] commArgs
    {
        get => GetField<string[]>();
        set => SetField(value);
    }

    public SupportedLanguages gameLanguage
    {
        get => orig.gameLanguage;
        set => orig.gameLanguage = value;
    }

    public int backerCredits
    {
        get => orig.backerCredits;
        set => orig.backerCredits = value;
    }

    public int showNativeAchievementPopups
    {
        get => orig.showNativeAchievementPopups;
        set => orig.showNativeAchievementPopups = value;
    }

    public bool isNativeInput
    {
        get => orig.isNativeInput;
        set => orig.isNativeInput = value;
    }

    public bool vibrationMuted
    {
        get => orig.vibrationMuted;
        set => orig.vibrationMuted = value;
    }

    public float masterVolume
    {
        get => orig.masterVolume;
        set => orig.masterVolume = value;
    }

    public float musicVolume
    {
        get => orig.musicVolume;
        set => orig.musicVolume = value;
    }

    public float soundVolume
    {
        get => orig.soundVolume;
        set => orig.soundVolume = value;
    }

    public int fullScreen
    {
        get => orig.fullScreen;
        set => orig.fullScreen = value;
    }

    public int vSync
    {
        get => orig.vSync;
        set => orig.vSync = value;
    }

    public int useDisplay
    {
        get => orig.useDisplay;
        set => orig.useDisplay = value;
    }

    public float overScanAdjustment
    {
        get => orig.overScanAdjustment;
        set => orig.overScanAdjustment = value;
    }

    public float brightnessAdjustment
    {
        get => orig.brightnessAdjustment;
        set => orig.brightnessAdjustment = value;
    }

    public int overscanAdjusted
    {
        get => orig.overscanAdjusted;
        set => orig.overscanAdjusted = value;
    }

    public int brightnessAdjusted
    {
        get => orig.brightnessAdjusted;
        set => orig.brightnessAdjusted = value;
    }

    public int targetFrameRate
    {
        get => orig.targetFrameRate;
        set => orig.targetFrameRate = value;
    }

    public bool frameCapOn
    {
        get => orig.frameCapOn;
        set => orig.frameCapOn = value;
    }

    public int particleEffectsLevel
    {
        get => orig.particleEffectsLevel;
        set => orig.particleEffectsLevel = value;
    }

    public ShaderQualities shaderQuality
    {
        get => orig.shaderQuality;
        set => orig.shaderQuality = value;
    }

    public ControllerMapping controllerMapping
    {
        get => orig.controllerMapping;
        set => orig.controllerMapping = value;
    }

    public string jumpKey
    {
        get => orig.jumpKey;
        set => orig.jumpKey = value;
    }

    public string attackKey
    {
        get => orig.attackKey;
        set => orig.attackKey = value;
    }

    public string dashKey
    {
        get => orig.dashKey;
        set => orig.dashKey = value;
    }

    public string castKey
    {
        get => orig.castKey;
        set => orig.castKey = value;
    }

    public string superDashKey
    {
        get => orig.superDashKey;
        set => orig.superDashKey = value;
    }

    public string dreamNailKey
    {
        get => orig.dreamNailKey;
        set => orig.dreamNailKey = value;
    }

    public string quickMapKey
    {
        get => orig.quickMapKey;
        set => orig.quickMapKey = value;
    }

    public string quickCastKey
    {
        get => orig.quickCastKey;
        set => orig.quickCastKey = value;
    }

    public string inventoryKey
    {
        get => orig.inventoryKey;
        set => orig.inventoryKey = value;
    }

    public string upKey
    {
        get => orig.upKey;
        set => orig.upKey = value;
    }

    public string downKey
    {
        get => orig.downKey;
        set => orig.downKey = value;
    }

    public string leftKey
    {
        get => orig.leftKey;
        set => orig.leftKey = value;
    }

    public string rightKey
    {
        get => orig.rightKey;
        set => orig.rightKey = value;
    }

    public void LoadGameOptionsSettings()
    {
        orig.LoadGameOptionsSettings();
    }

    public void SaveGameOptionsSettings()
    {
        orig.SaveGameOptionsSettings();
    }

    public void ResetGameOptionsSettings()
    {
        orig.ResetGameOptionsSettings();
    }

    public void LoadVideoSettings()
    {
        orig.LoadVideoSettings();
    }

    public void SaveVideoSettings()
    {
        orig.SaveVideoSettings();
    }

    public void ResetVideoSettings()
    {
        orig.ResetVideoSettings();
    }

    public void LoadOverscanSettings()
    {
        orig.LoadOverscanSettings();
    }

    public void SaveOverscanSettings()
    {
        orig.SaveOverscanSettings();
    }

    public void ResetOverscanSettings()
    {
        orig.ResetOverscanSettings();
    }

    public void LoadOverscanConfigured()
    {
        orig.LoadOverscanConfigured();
    }

    public void LoadBrightnessSettings()
    {
        orig.LoadBrightnessSettings();
    }

    public void SaveBrightnessSettings()
    {
        orig.SaveBrightnessSettings();
    }

    public void ResetBrightnessSettings()
    {
        orig.ResetBrightnessSettings();
    }

    public void LoadBrightnessConfigured()
    {
        orig.LoadBrightnessConfigured();
    }

    public void LoadAudioSettings()
    {
        orig.LoadAudioSettings();
    }

    public void SaveAudioSettings()
    {
        orig.SaveAudioSettings();
    }

    public void ResetAudioSettings()
    {
        orig.ResetAudioSettings();
    }

    public void LoadKeyboardSettings()
    {
        orig.LoadKeyboardSettings();
    }

    public void LoadAndUpgradeKeyboardKey(string prefsKey, string setString, Key defaultKey)
    {
        CallMethod(new object[] { prefsKey, setString, defaultKey });
    }

    public void SaveKeyboardSettings()
    {
        orig.SaveKeyboardSettings();
    }

    public bool LoadGamepadSettings(GamepadType gamepadType)
    {
        return orig.LoadGamepadSettings(gamepadType);
    }

    public void SaveGamepadSettings(GamepadType gamepadType)
    {
        orig.SaveGamepadSettings(gamepadType);
    }

    public void ResetGamepadSettings(GamepadType gamepadType)
    {
        orig.ResetGamepadSettings(gamepadType);
    }

    public GamepadType RemapGamepadTypeForSettings(GamepadType sourceType)
    {
        return CallMethod<GamepadType>(new object[] { sourceType });
    }

    public bool LoadInt(string key, int val, int def)
    {
        return CallMethod<bool>(new object[] { key, val, def });
    }

    public bool HasSetting(string key)
    {
        return CallMethod<bool>(new object[] { key });
    }

    public bool LoadEnum<EnumTy>(string key, EnumTy val, EnumTy def)
    {
        return CallMethod<bool>(new object[] { key, val, def });
    }

    public bool LoadBool(string key, bool val, bool def)
    {
        return CallMethod<bool>(new object[] { key, val, def });
    }

    public bool LoadFloat(string key, float val, float def)
    {
        return CallMethod<bool>(new object[] { key, val, def });
    }

    public bool LoadString(string key, string val, string def)
    {
        return CallMethod<bool>(new object[] { key, val, def });
    }

    public void LogMissingKey(string key)
    {
        CallMethod(new object[] { key });
    }

    public void LogLoadedKey(string key, int value)
    {
        CallMethod(new object[] { key, value });
    }

    public void LogLoadedKey(string key, float value)
    {
        CallMethod(new object[] { key, value });
    }

    public void LogLoadedKey(string key, string value)
    {
        CallMethod(new object[] { key, value });
    }

    public void LogSavedKey(string key, int value)
    {
        CallMethod(new object[] { key, value });
    }

    public void LogSavedKey(string key, float value)
    {
        CallMethod(new object[] { key, value });
    }

    public void LogSavedKey(string key, string value)
    {
        CallMethod(new object[] { key, value });
    }

    public bool CommandArgumentUsed(string arg)
    {
        return orig.CommandArgumentUsed(arg);
    }
}