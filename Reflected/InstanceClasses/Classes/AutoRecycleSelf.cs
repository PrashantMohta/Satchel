namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AutoRecycleSelf allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AutoRecycleSelfR : InstanceClassWrapper<AutoRecycleSelf>
{
    public AutoRecycleSelfR(AutoRecycleSelf _orig) : base(_orig)
    {
    }

    public AfterEvent afterEvent
    {
        get => orig.afterEvent;
        set => orig.afterEvent = value;
    }

    public float timeToWait
    {
        get => orig.timeToWait;
        set => orig.timeToWait = value;
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
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


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Update20()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnApplicationQuit()
    {
        CallMethod();
    }

    public IEnumerator StartTimer(float wait)
    {
        return CallMethod<IEnumerator>(new object[] { wait });
    }

    public void RecycleSelf()
    {
        CallMethod();
    }
}