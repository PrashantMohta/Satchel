namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayAudioAndRecycle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayAudioAndRecycleR:InstanceClassWrapper<PlayAudioAndRecycle>
{
public PlayAudioAndRecycleR(PlayAudioAndRecycle _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => orig.audioSource;
set => orig.audioSource = value;
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
