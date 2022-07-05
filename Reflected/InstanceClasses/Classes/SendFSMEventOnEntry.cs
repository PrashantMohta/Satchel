namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SendFSMEventOnEntry allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendFSMEventOnEntryR : InstanceClassWrapper<SendFSMEventOnEntry>
{
    public SendFSMEventOnEntryR(SendFSMEventOnEntry _orig) : base(_orig)
    {
    }

    public PlayMakerFSM fsm
    {
        get => orig.fsm;
        set => orig.fsm = value;
    }

    public string fsmEvent
    {
        get => orig.fsmEvent;
        set => orig.fsmEvent = value;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}