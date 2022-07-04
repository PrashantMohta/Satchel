namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CameraControlAnimationEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraControlAnimationEventsR:InstanceClassWrapper<CameraControlAnimationEvents>
{
public CameraControlAnimationEventsR(CameraControlAnimationEvents _orig) : base(_orig) {}


public void BigShake () =>
orig.BigShake();

public void SmallShake () =>
orig.SmallShake();

public void AverageShake () =>
orig.AverageShake();

public void EnemyKillShake () =>
orig.EnemyKillShake();

public void SmallRumble () =>
orig.SmallRumble();

public void MedRumble () =>
orig.MedRumble();

public void BigRumble () =>
orig.BigRumble();

public void StopRumble () =>
orig.StopRumble();

public void SendCameraEvent (string eventName) =>
CallMethod(new object[] {eventName});

public void SetCameraBool (string boolName, bool value) =>
CallMethod(new object[] {boolName, value});

}
}
