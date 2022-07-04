namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EndBossSceneTimer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EndBossSceneTimerR:InstanceClassWrapper<EndBossSceneTimer>
{
public EndBossSceneTimerR(EndBossSceneTimer _orig) : base(_orig) {}
public float delay
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator Delayed () =>
CallMethod<System.Collections.IEnumerator>();

}
}
