namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIAudioManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIAudioManagerR:InstanceClassWrapper<tk2dUIAudioManager>
{
public tk2dUIAudioManagerR(tk2dUIAudioManager _orig) : base(_orig) {}
public tk2dUIAudioManager instance
{
get => GetFieldStatic<tk2dUIAudioManager>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSrc
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public tk2dUIAudioManager Instance
{
get => tk2dUIAudioManager.Instance;
}



public void Awake () =>
CallMethod();

public void Setup () =>
CallMethod();

public void Play (UnityEngine.AudioClip clip) =>
orig.Play(clip);

}
}
