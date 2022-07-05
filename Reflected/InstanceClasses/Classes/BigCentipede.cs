namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BigCentipede allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BigCentipedeR : InstanceClassWrapper<BigCentipede>
{
    public BigCentipedeR(BigCentipede _orig) : base(_orig)
    {
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public BigCentipedeSection[] sections
    {
        get => GetField<BigCentipedeSection[]>();
        set => SetField(value);
    }

    public ParticleSystem entryDust
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public ParticleSystem exitDust
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public Vector2 entryPoint
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 exitPoint
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float burrowTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float moveSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector2 direction
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public bool fadingAudio
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isBurrowing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float burrowTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Transform entry
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Transform exit
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Vector2 EntryPoint => orig.EntryPoint;

    public Vector2 ExitPoint => orig.ExitPoint;

    public Vector2 Direction => orig.Direction;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void UnBurrow(bool changePosition)
    {
        CallMethod(new object[] { changePosition });
    }

    public void Burrow()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}