namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SnapshotOnActivation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SnapshotOnActivationR:InstanceClassWrapper<SnapshotOnActivation>
{
public SnapshotOnActivationR(SnapshotOnActivation _orig) : base(_orig) {}
public UnityEngine.Audio.AudioMixerSnapshot activationSnapshot
{
get => orig.activationSnapshot;
set => orig.activationSnapshot = value;
}

public UnityEngine.Audio.AudioMixerSnapshot deactivationSnapshot
{
get => orig.deactivationSnapshot;
set => orig.deactivationSnapshot = value;
}

public float transitionTime
{
get => orig.transitionTime;
set => orig.transitionTime = value;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

}
}
