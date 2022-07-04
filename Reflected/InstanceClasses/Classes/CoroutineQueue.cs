namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CoroutineQueue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CoroutineQueueR:InstanceClassWrapper<CoroutineQueue>
{
public CoroutineQueueR(CoroutineQueue _orig) : base(_orig) {}
public System.Collections.Generic.List<System.Collections.IEnumerator> pendingCoroutines
{
get => GetField<System.Collections.Generic.List<System.Collections.IEnumerator>>();
set => SetField(value);
}

public UnityEngine.MonoBehaviour runner
{
get => GetField<UnityEngine.MonoBehaviour>();
set => SetField(value);
}

public bool isRunning
{
get => GetField<bool>();
set => SetField(value);
}

public void Enqueue (System.Collections.IEnumerator coroutine) =>
orig.Enqueue(coroutine);

public System.Collections.IEnumerator Run () =>
orig.Run();

}
}
