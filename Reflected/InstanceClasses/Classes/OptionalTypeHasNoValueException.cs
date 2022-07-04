namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OptionalTypeHasNoValueException allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OptionalTypeHasNoValueExceptionR:InstanceClassWrapper<InControl.OptionalTypeHasNoValueException>
{
public OptionalTypeHasNoValueExceptionR(InControl.OptionalTypeHasNoValueException _orig) : base(_orig) {}
public string _message
{
get => GetField<string>();
set => SetField(value);
}

public int _HResult
{
get => GetField<int>();
set => SetField(value);
}

public System.Diagnostics.StackTrace[] captured_traces
{
get => GetField<System.Diagnostics.StackTrace[]>();
set => SetField(value);
}

public string Message
{
get => orig.Message;
}

public System.Collections.IDictionary Data
{
get => orig.Data;
}

public System.Exception InnerException
{
get => orig.InnerException;
}

public System.Reflection.MethodBase TargetSite
{
get => orig.TargetSite;
}

public string StackTrace
{
get => orig.StackTrace;
}

public string HelpLink
{
get => orig.HelpLink;
set => orig.HelpLink = value;
}

public string Source
{
get => orig.Source;
set => orig.Source = value;
}

public string RemoteStackTrace
{
get => GetProperty<string>();
}

public int HResult
{
get => orig.HResult;
set => SetProperty(value);
}

public bool IsTransient
{
get => GetProperty<bool>();
}

}
}
