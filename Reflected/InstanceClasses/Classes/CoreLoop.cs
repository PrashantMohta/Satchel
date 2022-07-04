namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CoreLoop allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CoreLoopR:InstanceClassWrapper<CoreLoop>
{
public CoreLoopR(CoreLoop _orig) : base(_orig) {}
public CoreLoop instance
{
get => GetFieldStatic<CoreLoop>();
set => SetField(value);
}

public System.Collections.Generic.List<System.Action> invokeNextActions
{
get => GetFieldStatic<System.Collections.Generic.List<System.Action>>();
set => SetField(value);
}

public System.Collections.Generic.List<System.Action> invokeNextActionsBuffer
{
get => GetFieldStatic<System.Collections.Generic.List<System.Action>>();
set => SetField(value);
}

public bool isFiringInvokeNext
{
    get => GetFieldStatic<bool>();
    set => SetField(value);
}

public void Init () =>
CallMethodStatic();

public void InvokeNext (System.Action action) =>
CoreLoop.InvokeNext(action);

public void EnqueueInvokeNext () =>
CallMethodStatic();

public void FireInvokeNext () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
