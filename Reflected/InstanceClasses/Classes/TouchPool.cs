using System.Collections.ObjectModel;
using InControl;
using Touch = InControl.Touch;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchPoolR : InstanceClassWrapper<TouchPool>
{
    public TouchPoolR(TouchPool _orig) : base(_orig)
    {
    }

    public ReadOnlyCollection<Touch> Touches
    {
        get => orig.Touches;
        set => SetField(value);
    }

    public List<Touch> usedTouches
    {
        get => GetField<List<Touch>>();
        set => SetField(value);
    }

    public List<Touch> freeTouches
    {
        get => GetField<List<Touch>>();
        set => SetField(value);
    }

    public Touch FindOrCreateTouch(int fingerId)
    {
        return orig.FindOrCreateTouch(fingerId);
    }

    public Touch FindTouch(int fingerId)
    {
        return orig.FindTouch(fingerId);
    }

    public Touch NewTouch()
    {
        return CallMethod<Touch>();
    }

    public void FreeTouch(Touch touch)
    {
        orig.FreeTouch(touch);
    }

    public void FreeEndedTouches()
    {
        orig.FreeEndedTouches();
    }
}