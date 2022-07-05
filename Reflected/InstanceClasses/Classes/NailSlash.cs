namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of NailSlash allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NailSlashR : InstanceClassWrapper<NailSlash>
{
    public NailSlashR(NailSlash _orig) : base(_orig)
    {
    }

    public string animName
    {
        get => orig.animName;
        set => orig.animName = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public PlayMakerFSM slashFsm
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public MeshRenderer mesh
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public float slashAngle
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool struck
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool longnail
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool mantis
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool fury
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool slashing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int stepCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public PolygonCollider2D poly
    {
        get => GetField<PolygonCollider2D>();
        set => SetField(value);
    }

    public int polyCounter
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool animCompleted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AudioSource audio
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public PolygonCollider2D clashTinkPoly
    {
        get => GetField<PolygonCollider2D>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void StartSlash()
    {
        orig.StartSlash();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void Bounce(Collider2D otherCollider, bool useEffects)
    {
        CallMethod(new object[] { otherCollider, useEffects });
    }

    public void OnTriggerStay2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }

    public void Disable(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip)
    {
        CallMethod(new object[] { sprite, clip });
    }

    public void SetLongnail(bool set)
    {
        orig.SetLongnail(set);
    }

    public void SetMantis(bool set)
    {
        orig.SetMantis(set);
    }

    public void SetFury(bool set)
    {
        orig.SetFury(set);
    }

    public void CancelAttack()
    {
        orig.CancelAttack();
    }

    public void orig_OnTriggerEnter2D(Collider2D otherCollider)
    {
        CallMethod(new object[] { otherCollider });
    }
}