namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchPoolR:InstanceClassWrapper<InControl.TouchPool>
{
public TouchPoolR(InControl.TouchPool _orig) : base(_orig) {}
public System.Collections.ObjectModel.ReadOnlyCollection<InControl.Touch> Touches
{
get => orig.Touches;
set => SetField(value);
}

public System.Collections.Generic.List<InControl.Touch> usedTouches
{
get => GetField<System.Collections.Generic.List<InControl.Touch>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.Touch> freeTouches
{
get => GetField<System.Collections.Generic.List<InControl.Touch>>();
set => SetField(value);
}

public InControl.Touch FindOrCreateTouch (int fingerId) =>
orig.FindOrCreateTouch(fingerId);

public InControl.Touch FindTouch (int fingerId) =>
orig.FindTouch(fingerId);

public InControl.Touch NewTouch () =>
CallMethod<InControl.Touch>();

public void FreeTouch (InControl.Touch touch) =>
orig.FreeTouch(touch);

public void FreeEndedTouches () =>
orig.FreeEndedTouches();

}
}
