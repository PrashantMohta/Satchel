namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of VibrationEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VibrationEffectR:InstanceClassWrapper<VibrationEffect>
{
public VibrationEffectR(VibrationEffect _orig) : base(_orig) {}
public VibrationData vibrationData
{
get => GetField<VibrationData>();
set => SetField(value);
}

public VibrationTarget vibrationSource
{
get => GetField<VibrationTarget>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

}
}
