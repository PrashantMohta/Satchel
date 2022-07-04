namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CoroutineQueue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CoroutineQueueR : InstanceClassWrapper<CoroutineQueue>
{
    public CoroutineQueueR(CoroutineQueue _orig) : base(_orig)
    {
    }

    public List<IEnumerator> pendingCoroutines
    {
        get => GetField<List<IEnumerator>>();
        set => SetField(value);
    }

    public MonoBehaviour runner
    {
        get => GetField<MonoBehaviour>();
        set => SetField(value);
    }

    public bool isRunning
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public void Enqueue(IEnumerator coroutine)
    {
        orig.Enqueue(coroutine);
    }

    public IEnumerator Run()
    {
        return orig.Run();
    }
}