namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GrimmballControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrimmballControlR : InstanceClassWrapper<GrimmballControl>
{
    public GrimmballControlR(GrimmballControl _orig) : base(_orig)
    {
    }

    public ParticleSystem ptFlame
    {
        get => orig.ptFlame;
        set => orig.ptFlame = value;
    }

    public ParticleSystem ptSmoke
    {
        get => orig.ptSmoke;
        set => orig.ptSmoke = value;
    }

    public float maxLifeTime
    {
        get => orig.maxLifeTime;
        set => orig.maxLifeTime = value;
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Coroutine fireRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Coroutine shrinkRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float force
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float tweenY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool hit
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool addForce
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float Force
    {
        get => orig.Force;
        set => orig.Force = value;
    }

    public float TweenY
    {
        get => orig.TweenY;
        set => orig.TweenY = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void DoHit()
    {
        orig.DoHit();
    }

    public void Fire()
    {
        orig.Fire();
    }

    public IEnumerator DoFire()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator Shrink()
    {
        return CallMethod<IEnumerator>();
    }
}