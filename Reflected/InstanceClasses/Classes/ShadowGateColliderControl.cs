namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShadowGateColliderControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShadowGateColliderControlR : InstanceClassWrapper<ShadowGateColliderControl>
{
    public ShadowGateColliderControlR(ShadowGateColliderControl _orig) : base(_orig)
    {
    }

    public Collider2D disableCollider
    {
        get => orig.disableCollider;
        set => orig.disableCollider = value;
    }

    public bool unlocked
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public EventRegister eventRegister
    {
        get => GetField<EventRegister>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Setup()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }
}