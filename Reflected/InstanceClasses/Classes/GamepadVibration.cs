namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GamepadVibration allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GamepadVibrationR:InstanceClassWrapper<GamepadVibration>
{
public GamepadVibrationR(GamepadVibration _orig) : base(_orig) {}
public UnityEngine.AnimationCurve smallMotor
{
get => GetField<UnityEngine.AnimationCurve>();
set => SetField(value);
}

public UnityEngine.AnimationCurve largeMotor
{
get => GetField<UnityEngine.AnimationCurve>();
set => SetField(value);
}

public float playbackRate
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.AnimationCurve SmallMotor
{
get => orig.SmallMotor;
}

public UnityEngine.AnimationCurve LargeMotor
{
get => orig.LargeMotor;
}

public float PlaybackRate
{
get => orig.PlaybackRate;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public void Reset () =>
CallMethod();

public float GetDuration () =>
orig.GetDuration();

public float GetDuration (UnityEngine.AnimationCurve animationCurve) =>
CallMethodStatic<float>(new object[] {animationCurve});

}
}
