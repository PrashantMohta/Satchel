namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GamepadVibration allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GamepadVibrationR : InstanceClassWrapper<GamepadVibration>
{
    public GamepadVibrationR(GamepadVibration _orig) : base(_orig)
    {
    }

    public AnimationCurve smallMotor
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public AnimationCurve largeMotor
    {
        get => GetField<AnimationCurve>();
        set => SetField(value);
    }

    public float playbackRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public AnimationCurve SmallMotor => orig.SmallMotor;

    public AnimationCurve LargeMotor => orig.LargeMotor;

    public float PlaybackRate => orig.PlaybackRate;

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public void Reset()
    {
        CallMethod();
    }

    public float GetDuration()
    {
        return orig.GetDuration();
    }

    public float GetDuration(AnimationCurve animationCurve)
    {
        return CallMethodStatic<float>(new object[] { animationCurve });
    }
}