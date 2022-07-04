namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of OpeningSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OpeningSequenceR : InstanceClassWrapper<OpeningSequence>
{
    public OpeningSequenceR(OpeningSequence _orig) : base(_orig)
    {
    }

    public ChainSequence chainSequence
    {
        get => GetField<ChainSequence>();
        set => SetField(value);
    }

    public ThreadPriority streamingLoadPriority
    {
        get => GetField<ThreadPriority>();
        set => SetField(value);
    }

    public ThreadPriority completedLoadPriority
    {
        get => GetField<ThreadPriority>();
        set => SetField(value);
    }

    public float skipChargeDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isAsync
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isLevelReady
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AsyncOperation asyncKnightLoad
    {
        get => GetField<AsyncOperation>();
        set => SetField(value);
    }

    public AsyncOperation asyncWorldLoad
    {
        get => GetField<AsyncOperation>();
        set => SetField(value);
    }

    public float skipChargeTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator StartAsync()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator StartSync()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public bool IsLevelReady(AsyncOperation operation)
    {
        return CallMethodStatic<bool>(new object[] { operation });
    }

    public IEnumerator Skip()
    {
        return orig.Skip();
    }

    public void OnChangingSequences()
    {
        CallMethod();
    }
}