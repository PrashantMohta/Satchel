namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MegaJellyZap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MegaJellyZapR : InstanceClassWrapper<MegaJellyZap>
{
    public MegaJellyZapR(MegaJellyZap _orig) : base(_orig)
    {
    }

    public ParticleSystem ptAttack
    {
        get => orig.ptAttack;
        set => orig.ptAttack = value;
    }

    public ParticleSystem ptAntic
    {
        get => orig.ptAntic;
        set => orig.ptAntic = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent zapBugPt1
    {
        get => orig.zapBugPt1;
        set => orig.zapBugPt1 = value;
    }

    public AudioEvent zapBugPt2
    {
        get => orig.zapBugPt2;
        set => orig.zapBugPt2 = value;
    }

    public tk2dSpriteAnimator anim
    {
        get => orig.anim;
        set => orig.anim = value;
    }

    public MeshRenderer animMesh
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public CircleCollider2D col
    {
        get => GetField<CircleCollider2D>();
        set => SetField(value);
    }

    public ColorFader fade
    {
        get => GetField<ColorFader>();
        set => SetField(value);
    }

    public Coroutine routine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
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

    public IEnumerator ZapSequence()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator MultiZapSequence()
    {
        return CallMethod<IEnumerator>();
    }
}