namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LimitSendEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LimitSendEventsR : InstanceClassWrapper<LimitSendEvents>
{
    public LimitSendEventsR(LimitSendEvents _orig) : base(_orig)
    {
    }

    public Collider2D monitorCollider
    {
        get => orig.monitorCollider;
        set => orig.monitorCollider = value;
    }

    public bool? previousColliderState
    {
        get => GetField<bool?>();
        set => SetField(value);
    }

    public List<GameObject> sentList
    {
        get => GetField<List<GameObject>>();
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

    public bool Add(GameObject obj)
    {
        return orig.Add(obj);
    }
}