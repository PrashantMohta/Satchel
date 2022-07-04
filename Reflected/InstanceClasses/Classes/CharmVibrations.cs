namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CharmVibrations allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmVibrationsR:InstanceClassWrapper<CharmVibrations>
{
public CharmVibrationsR(CharmVibrations _orig) : base(_orig) {}
public VibrationData regularPlace
{
get => GetField<VibrationData>();
set => SetField(value);
}

public VibrationData failedPlace
{
get => GetField<VibrationData>();
set => SetField(value);
}

public VibrationData overcharmPlace
{
get => GetField<VibrationData>();
set => SetField(value);
}

public VibrationData overcharmHit
{
get => GetField<VibrationData>();
set => SetField(value);
}

public VibrationData overcharmFinalHit
{
get => GetField<VibrationData>();
set => SetField(value);
}



public void PlayRegularPlace () =>
orig.PlayRegularPlace();

public void PlayFailedPlace () =>
orig.PlayFailedPlace();

public void PlayOvercharmPlace () =>
orig.PlayOvercharmPlace();

public void PlayOvercharmHit () =>
orig.PlayOvercharmHit();

public void PlayOvercharmFinalHit () =>
orig.PlayOvercharmFinalHit();

public void PlayDelayedVibration (VibrationData vibrationData) =>
CallMethod(new object[] {vibrationData});

public System.Collections.IEnumerator PlayDelayedVibrationRoutine (VibrationData vibrationData) =>
CallMethod<System.Collections.IEnumerator>(new object[] {vibrationData});

}
}
