namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EventRegister allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EventRegisterR : InstanceClassWrapper<EventRegister>
{
    public EventRegisterR(EventRegister _orig) : base(_orig)
    {
    }

    public Dictionary<string, List<EventRegister>> eventRegister
    {
        get => EventRegister.eventRegister;
        set => EventRegister.eventRegister = value;
    }

    public string subscribedEvent
    {
        get => GetField<string>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void ReceiveEvent()
    {
        orig.ReceiveEvent();
    }

    public void SwitchEvent(string eventName)
    {
        orig.SwitchEvent(eventName);
    }

    public void SendEvent(string eventName)
    {
        EventRegister.SendEvent(eventName);
    }

    public void SubscribeEvent(EventRegister register)
    {
        EventRegister.SubscribeEvent(register);
    }

    public void UnsubscribeEvent(EventRegister register)
    {
        EventRegister.UnsubscribeEvent(register);
    }
}