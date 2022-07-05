namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HeroBox allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HeroBoxR : InstanceClassWrapper<HeroBox>
{
    public HeroBoxR(HeroBox _orig) : base(_orig)
    {
    }

    public bool inactive
    {
        get => HeroBox.inactive;
        set => HeroBox.inactive = value;
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public GameObject damagingObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool isHitBuffered
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int damageDealt
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int hazardType
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public CollisionSide collisionSide
    {
        get => GetField<CollisionSide>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void OnTriggerStay2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void CheckForDamage(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public bool IsHitTypeBuffered(int hazardType)
    {
        return CallMethodStatic<bool>(new object[] { hazardType });
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void ApplyBufferedHit()
    {
        CallMethod();
    }
}