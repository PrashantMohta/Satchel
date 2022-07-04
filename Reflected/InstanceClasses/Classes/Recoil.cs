namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Recoil allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RecoilR : InstanceClassWrapper<Recoil>
{
    public RecoilR(Recoil _orig) : base(_orig)
    {
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public bool freezeInPlace
    {
        get => orig.freezeInPlace;
        set => orig.freezeInPlace = value;
    }

    public bool stopVelocityXWhenRecoilingUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool preventRecoilUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float recoilSpeedBase
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float recoilDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool skipFreezingByController
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float recoilTimeRemaining
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float recoilSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Sweep recoilSweep
    {
        get => GetField<Sweep>();
        set => SetField(value);
    }

    public bool isRecoilSweeping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int SweepLayerMask
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public bool SkipFreezingByController
    {
        get => orig.SkipFreezingByController;
        set => orig.SkipFreezingByController = value;
    }

    public bool IsRecoiling => orig.IsRecoiling;


    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void RecoilByHealthManagerFSMParameters()
    {
        orig.RecoilByHealthManagerFSMParameters();
    }

    public void RecoilByDamage(HitInstance damageInstance)
    {
        orig.RecoilByDamage(damageInstance);
    }

    public void RecoilByDirection(int attackDirection, float attackMagnitude)
    {
        orig.RecoilByDirection(attackDirection, attackMagnitude);
    }

    public void CancelRecoil()
    {
        orig.CancelRecoil();
    }

    public void Freeze()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void UpdatePhysics(float deltaTime)
    {
        CallMethod(new object[] { deltaTime });
    }

    public void SetRecoilSpeed(float newSpeed)
    {
        orig.SetRecoilSpeed(newSpeed);
    }
}