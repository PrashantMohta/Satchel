namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerActivateComponent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerActivateComponentR:InstanceClassWrapper<TriggerActivateComponent>
{
public TriggerActivateComponentR(TriggerActivateComponent _orig) : base(_orig) {}
public UnityEngine.MonoBehaviour component
{
get => orig.component;
set => orig.component = value;
}

public float disableTime
{
get => orig.disableTime;
set => orig.disableTime = value;
}

public UnityEngine.Coroutine disableTimer
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public System.Collections.IEnumerator DisableTimer () =>
CallMethod<System.Collections.IEnumerator>();

}
}
