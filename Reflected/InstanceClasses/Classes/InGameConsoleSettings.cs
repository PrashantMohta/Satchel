namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InGameConsoleSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InGameConsoleSettingsR : InstanceClassWrapper<InGameConsoleSettings>
{
    public InGameConsoleSettingsR(InGameConsoleSettings _orig) : base(_orig)
    {
    }

    public bool UseLogColors
    {
        get => orig.UseLogColors;
        set => orig.UseLogColors = value;
    }

    public string FineColor
    {
        get => orig.FineColor;
        set => orig.FineColor = value;
    }

    public string InfoColor
    {
        get => orig.InfoColor;
        set => orig.InfoColor = value;
    }

    public string DebugColor
    {
        get => orig.DebugColor;
        set => orig.DebugColor = value;
    }

    public string WarningColor
    {
        get => orig.WarningColor;
        set => orig.WarningColor = value;
    }

    public string ErrorColor
    {
        get => orig.ErrorColor;
        set => orig.ErrorColor = value;
    }

    public string DefaultColor
    {
        get => orig.DefaultColor;
        set => orig.DefaultColor = value;
    }

    public KeyCode ToggleHotkey
    {
        get => orig.ToggleHotkey;
        set => orig.ToggleHotkey = value;
    }

    public int MaxMessageCount
    {
        get => orig.MaxMessageCount;
        set => orig.MaxMessageCount = value;
    }

    public string Font
    {
        get => orig.Font;
        set => orig.Font = value;
    }

    public int FontSize
    {
        get => orig.FontSize;
        set => orig.FontSize = value;
    }
}