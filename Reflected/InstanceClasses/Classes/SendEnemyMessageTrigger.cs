namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SendEnemyMessageTrigger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SendEnemyMessageTriggerR : InstanceClassWrapper<SendEnemyMessageTrigger>
{
    public SendEnemyMessageTriggerR(SendEnemyMessageTrigger _orig) : base(_orig)
    {
    }

    public string eventName
    {
        get => orig.eventName;
        set => orig.eventName = value;
    }

    public List<GameObject> enteredEnemies
    {
        get => GetField<List<GameObject>>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void SendEvent(GameObject obj)
    {
        CallMethod(new object[] { obj });
    }

    public void SendWalkerGoInDirection(GameObject target, int facing)
    {
        CallMethodStatic(new object[] { target, facing });
    }
}