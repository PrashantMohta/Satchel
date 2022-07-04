namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ModHooksGlobalSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModHooksGlobalSettingsR:InstanceClassWrapper<Modding.ModHooksGlobalSettings>
{
public ModHooksGlobalSettingsR(Modding.ModHooksGlobalSettings _orig) : base(_orig) {}
public System.Collections.Generic.Dictionary<System.String,System.Boolean> ModEnabledSettings
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Boolean>>();
set => SetField(value);
}

public Modding.LogLevel LoggingLevel
{
get => orig.LoggingLevel;
set => orig.LoggingLevel = value;
}

public Modding.InGameConsoleSettings ConsoleSettings
{
get => orig.ConsoleSettings;
set => orig.ConsoleSettings = value;
}

public bool ShowDebugLogInGame
{
get => orig.ShowDebugLogInGame;
set => orig.ShowDebugLogInGame = value;
}

public int PreloadBatchSize
{
get => orig.PreloadBatchSize;
set => orig.PreloadBatchSize = value;
}

public int ModlogMaxAge
{
get => orig.ModlogMaxAge;
set => orig.ModlogMaxAge = value;
}

}
}
