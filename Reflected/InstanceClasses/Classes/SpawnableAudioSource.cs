namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpawnableAudioSource allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpawnableAudioSourceR:InstanceClassWrapper<SpawnableAudioSource>
{
public SpawnableAudioSourceR(SpawnableAudioSource _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public int MinimumFrames
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int framesPassed
{
get => GetField<int>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void Stop () =>
orig.Stop();

}
}
