using InControl;
using Touch = InControl.Touch;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchSwipeControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchSwipeControlR : InstanceClassWrapper<TouchSwipeControl>
{
    public TouchSwipeControlR(TouchSwipeControl _orig) : base(_orig)
    {
    }

    public TouchUnitType areaUnitType
    {
        get => GetField<TouchUnitType>();
        set => SetField(value);
    }

    public Rect activeArea
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public float sensitivity
    {
        get => orig.sensitivity;
        set => orig.sensitivity = value;
    }

    public bool oneSwipePerTouch
    {
        get => orig.oneSwipePerTouch;
        set => orig.oneSwipePerTouch = value;
    }

    public Rect worldActiveArea
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Vector3 currentVector
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool currentVectorIsSet
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3 beganPosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 lastPosition
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Touch currentTouch
    {
        get => GetField<Touch>();
        set => SetField(value);
    }

    public bool fireButtonTarget
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool dirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Rect ActiveArea
    {
        get => orig.ActiveArea;
        set => orig.ActiveArea = value;
    }

    public TouchUnitType AreaUnitType
    {
        get => orig.AreaUnitType;
        set => orig.AreaUnitType = value;
    }


    public void CreateControl()
    {
        orig.CreateControl();
    }

    public void DestroyControl()
    {
        orig.DestroyControl();
    }

    public void ConfigureControl()
    {
        orig.ConfigureControl();
    }

    public void DrawGizmos()
    {
        orig.DrawGizmos();
    }

    public void Update()
    {
        CallMethod();
    }

    public void SubmitControlState(ulong updateTick, float deltaTime)
    {
        orig.SubmitControlState(updateTick, deltaTime);
    }

    public void CommitControlState(ulong updateTick, float deltaTime)
    {
        orig.CommitControlState(updateTick, deltaTime);
    }

    public void TouchBegan(Touch touch)
    {
        orig.TouchBegan(touch);
    }

    public void TouchMoved(Touch touch)
    {
        orig.TouchMoved(touch);
    }

    public void TouchEnded(Touch touch)
    {
        orig.TouchEnded(touch);
    }
}