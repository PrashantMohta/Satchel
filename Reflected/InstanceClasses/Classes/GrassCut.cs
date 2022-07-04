namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GrassCut allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassCutR : InstanceClassWrapper<GrassCut>
{
    public GrassCutR(GrassCut _orig) : base(_orig)
    {
    }

    public SpriteRenderer[] disable
    {
        get => orig.disable;
        set => orig.disable = value;
    }

    public SpriteRenderer[] enable
    {
        get => orig.enable;
        set => orig.enable = value;
    }

    public Collider2D[] disableColliders
    {
        get => orig.disableColliders;
        set => orig.disableColliders = value;
    }

    public Collider2D[] enableColliders
    {
        get => orig.enableColliders;
        set => orig.enableColliders = value;
    }

    public GameObject particles
    {
        get => orig.particles;
        set => orig.particles = value;
    }

    public GameObject cutEffectPrefab
    {
        get => orig.cutEffectPrefab;
        set => orig.cutEffectPrefab = value;
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public bool ShouldCut(Collider2D collision)
    {
        return GrassCut.ShouldCut(collision);
    }
}