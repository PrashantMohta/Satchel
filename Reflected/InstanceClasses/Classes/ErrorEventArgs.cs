namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ErrorEventArgs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ErrorEventArgsR:InstanceClassWrapper<Microsoft.Xbox.ErrorEventArgs>
{
public ErrorEventArgsR(Microsoft.Xbox.ErrorEventArgs _orig) : base(_orig) {}
public string ErrorCode
{
get => orig.ErrorCode;
set => SetProperty(value);
}

public string ErrorMessage
{
get => orig.ErrorMessage;
set => SetProperty(value);
}

}
}
