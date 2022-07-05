using InControl;
using Logger = InControl.Logger;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Logger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LoggerR : InstanceClassWrapper<Logger>
{
    public LoggerR(Logger _orig) : base(_orig)
    {
    }

    public Action<LogMessage> OnLogMessage
    {
        get => GetFieldStatic<Action<LogMessage>>();
        set => SetField(value);
    }

    public void LogInfo(string text)
    {
        Logger.LogInfo(text);
    }

    public void LogWarning(string text)
    {
        Logger.LogWarning(text);
    }

    public void LogError(string text)
    {
        Logger.LogError(text);
    }
}