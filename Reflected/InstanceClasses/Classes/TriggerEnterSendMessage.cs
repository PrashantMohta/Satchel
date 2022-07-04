namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TriggerEnterSendMessage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TriggerEnterSendMessageR : InstanceClassWrapper<TriggerEnterSendMessage>
{
    public TriggerEnterSendMessageR(TriggerEnterSendMessage _orig) : base(_orig)
    {
    }

    public string message
    {
        get => orig.message;
        set => orig.message = value;
    }

    public SendMessageOptions options
    {
        get => orig.options;
        set => orig.options = value;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}