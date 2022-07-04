namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Logger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LoggerR:InstanceClassWrapper<InControl.Logger>
{
public LoggerR(InControl.Logger _orig) : base(_orig) {}
public System.Action<InControl.LogMessage> OnLogMessage
{
get => GetFieldStatic<System.Action<InControl.LogMessage>>();
set => SetField(value);
}

public void LogInfo (string text) =>
InControl.Logger.LogInfo(text);

public void LogWarning (string text) =>
InControl.Logger.LogWarning(text);

public void LogError (string text) =>
InControl.Logger.LogError(text);

}
}
