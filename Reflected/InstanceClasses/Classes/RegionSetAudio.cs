namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RegionSetAudio allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RegionSetAudioR:InstanceClassWrapper<RegionSetAudio>
{
public RegionSetAudioR(RegionSetAudio _orig) : base(_orig) {}
public UnityEngine.Audio.AudioMixerSnapshot atmosSnapshotEnter
{
get => orig.atmosSnapshotEnter;
set => orig.atmosSnapshotEnter = value;
}

public UnityEngine.Audio.AudioMixerSnapshot enviroSnapshotEnter
{
get => orig.enviroSnapshotEnter;
set => orig.enviroSnapshotEnter = value;
}

public UnityEngine.Audio.AudioMixerSnapshot atmosSnapshotExit
{
get => orig.atmosSnapshotExit;
set => orig.atmosSnapshotExit = value;
}

public UnityEngine.Audio.AudioMixerSnapshot enviroSnapshotExit
{
get => orig.enviroSnapshotExit;
set => orig.enviroSnapshotExit = value;
}

public float transitionTime
{
get => orig.transitionTime;
set => orig.transitionTime = value;
}

public bool entered
{
get => GetField<bool>();
set => SetField(value);
}



public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerStay2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

public void OnTriggerExit2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

}
}
