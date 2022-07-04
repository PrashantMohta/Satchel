namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AutoRecycleSelf allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoRecycleSelfR:InstanceClassWrapper<AutoRecycleSelf>
{
public AutoRecycleSelfR(AutoRecycleSelf _orig) : base(_orig) {}
public GlobalEnums.AfterEvent afterEvent
{
get => orig.afterEvent;
set => orig.afterEvent = value;
}

public float timeToWait
{
get => orig.timeToWait;
set => orig.timeToWait = value;
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public bool validAudioSource
{
get => GetField<bool>();
set => SetField(value);
}

public bool ApplicationIsQuitting
{
get => GetField<bool>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void Update20 () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnApplicationQuit () =>
CallMethod();

public System.Collections.IEnumerator StartTimer (float wait) =>
CallMethod<System.Collections.IEnumerator>(new object[] {wait});

public void RecycleSelf () =>
CallMethod();

}
}
