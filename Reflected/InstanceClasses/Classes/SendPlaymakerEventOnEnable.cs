namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SendPlaymakerEventOnEnable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendPlaymakerEventOnEnableR : InstanceClassWrapper<SendPlaymakerEventOnEnable>
{
    public SendPlaymakerEventOnEnableR(SendPlaymakerEventOnEnable _orig) : base(_orig)
    {
    }

    public string eventName
    {
        get => orig.eventName;
        set => orig.eventName = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }
}