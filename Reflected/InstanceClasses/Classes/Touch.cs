using Touch = InControl.Touch;
using TouchType = InControl.TouchType;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Touch allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchR : InstanceClassWrapper<Touch>
{
    public TouchR(Touch _orig) : base(_orig)
    {
    }

    public int FingerID_None
    {
        get => Touch.FingerID_None;
        set => SetField(value);
    }

    public int FingerID_Mouse
    {
        get => Touch.FingerID_Mouse;
        set => SetField(value);
    }

    public int fingerId
    {
        get => orig.fingerId;
        set => orig.fingerId = value;
    }

    public int mouseButton
    {
        get => orig.mouseButton;
        set => orig.mouseButton = value;
    }

    public TouchPhase phase
    {
        get => orig.phase;
        set => orig.phase = value;
    }

    public int tapCount
    {
        get => orig.tapCount;
        set => orig.tapCount = value;
    }

    public Vector2 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public Vector2 startPosition
    {
        get => orig.startPosition;
        set => orig.startPosition = value;
    }

    public Vector2 deltaPosition
    {
        get => orig.deltaPosition;
        set => orig.deltaPosition = value;
    }

    public Vector2 lastPosition
    {
        get => orig.lastPosition;
        set => orig.lastPosition = value;
    }

    public float deltaTime
    {
        get => orig.deltaTime;
        set => orig.deltaTime = value;
    }

    public ulong updateTick
    {
        get => orig.updateTick;
        set => orig.updateTick = value;
    }

    public TouchType type
    {
        get => orig.type;
        set => orig.type = value;
    }

    public float altitudeAngle
    {
        get => orig.altitudeAngle;
        set => orig.altitudeAngle = value;
    }

    public float azimuthAngle
    {
        get => orig.azimuthAngle;
        set => orig.azimuthAngle = value;
    }

    public float maximumPossiblePressure
    {
        get => orig.maximumPossiblePressure;
        set => orig.maximumPossiblePressure = value;
    }

    public float pressure
    {
        get => orig.pressure;
        set => orig.pressure = value;
    }

    public float radius
    {
        get => orig.radius;
        set => orig.radius = value;
    }

    public float radiusVariance
    {
        get => orig.radiusVariance;
        set => orig.radiusVariance = value;
    }

    public float normalizedPressure => orig.normalizedPressure;

    public float NormalizedPressure => orig.NormalizedPressure;

    public bool IsMouse => orig.IsMouse;

    public void Reset()
    {
        CallMethod();
    }

    public void SetWithTouchData(UnityEngine.Touch touch, ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { touch, updateTick, deltaTime });
    }

    public bool SetWithMouseData(int button, ulong updateTick, float deltaTime)
    {
        return CallMethod<bool>(new object[] { button, updateTick, deltaTime });
    }
}