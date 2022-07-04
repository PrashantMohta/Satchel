namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BreakablePole allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakablePoleR : InstanceClassWrapper<BreakablePole>
{
    public BreakablePoleR(BreakablePole _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public Sprite brokenSprite
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public float inertBackgroundThreshold
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float inertForegroundThreshold
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public AudioSource audioSourcePrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public RandomAudioClipTable hitClip
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public GameObject slashImpactPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Rigidbody2D top
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Hit(HitInstance damageInstance)
    {
        orig.Hit(damageInstance);
    }
}