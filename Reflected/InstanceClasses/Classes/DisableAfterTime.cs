namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DisableAfterTime allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DisableAfterTimeR : InstanceClassWrapper<DisableAfterTime>
{
    public DisableAfterTimeR(DisableAfterTime _orig) : base(_orig)
    {
    }

    public float waitTime
    {
        get => orig.waitTime;
        set => orig.waitTime = value;
    }

    public float disableTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public string sendEvent
    {
        get => orig.sendEvent;
        set => orig.sendEvent = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}