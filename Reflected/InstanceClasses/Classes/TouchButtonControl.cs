using InControl;
using Touch = InControl.Touch;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchButtonControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchButtonControlR : InstanceClassWrapper<TouchButtonControl>
{
    public TouchButtonControlR(TouchButtonControl _orig) : base(_orig)
    {
    }

    public TouchControlAnchor anchor
    {
        get => GetField<TouchControlAnchor>();
        set => SetField(value);
    }

    public TouchUnitType offsetUnitType
    {
        get => GetField<TouchUnitType>();
        set => SetField(value);
    }

    public Vector2 offset
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public bool lockAspectRatio
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool allowSlideToggle
    {
        get => orig.allowSlideToggle;
        set => orig.allowSlideToggle = value;
    }

    public bool toggleOnLeave
    {
        get => orig.toggleOnLeave;
        set => orig.toggleOnLeave = value;
    }

    public bool pressureSensitive
    {
        get => orig.pressureSensitive;
        set => orig.pressureSensitive = value;
    }

    public TouchSprite button
    {
        get => orig.button;
        set => orig.button = value;
    }

    public bool buttonState
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Touch currentTouch
    {
        get => GetField<Touch>();
        set => SetField(value);
    }

    public bool dirty
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool ButtonState
    {
        get => GetProperty<bool>();
        set => SetProperty(value);
    }

    public Vector3 ButtonPosition
    {
        get => orig.ButtonPosition;
        set => orig.ButtonPosition = value;
    }

    public TouchControlAnchor Anchor
    {
        get => orig.Anchor;
        set => orig.Anchor = value;
    }

    public Vector2 Offset
    {
        get => orig.Offset;
        set => orig.Offset = value;
    }

    public TouchUnitType OffsetUnitType
    {
        get => orig.OffsetUnitType;
        set => orig.OffsetUnitType = value;
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