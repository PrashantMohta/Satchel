namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetSceneAudio allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetSceneAudioR:InstanceClassWrapper<SetSceneAudio>
{
public SetSceneAudioR(SetSceneAudio _orig) : base(_orig) {}
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

public UnityEngine.Audio.AudioMixerSnapshot actorSnapshot
{
get => orig.actorSnapshot;
set => orig.actorSnapshot = value;
}

public float transitionTime
{
get => orig.transitionTime;
set => orig.transitionTime = value;
}



public void Start () =>
CallMethod();

}
}
