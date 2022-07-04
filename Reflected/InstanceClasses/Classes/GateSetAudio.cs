namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GateSetAudio allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GateSetAudioR:InstanceClassWrapper<GateSetAudio>
{
public GateSetAudioR(GateSetAudio _orig) : base(_orig) {}
public UnityEngine.Audio.AudioMixerSnapshot atmosSnapshot
{
get => orig.atmosSnapshot;
set => orig.atmosSnapshot = value;
}

public UnityEngine.Audio.AudioMixerSnapshot enviroSnapshot
{
get => orig.enviroSnapshot;
set => orig.enviroSnapshot = value;
}

public float transitionTime
{
get => orig.transitionTime;
set => orig.transitionTime = value;
}



public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

}
}
