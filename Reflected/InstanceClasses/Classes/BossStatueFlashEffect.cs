namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossStatueFlashEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossStatueFlashEffectR : InstanceClassWrapper<BossStatueFlashEffect>
{
    public BossStatueFlashEffectR(BossStatueFlashEffect _orig) : base(_orig)
    {
    }

    public SpriteRenderer templateSprite
    {
        get => orig.templateSprite;
        set => orig.templateSprite = value;
    }

    public GameObject statueSpritesParent
    {
        get => orig.statueSpritesParent;
        set => orig.statueSpritesParent = value;
    }

    public SpriteRenderer[] statueSprites
    {
        get => GetField<SpriteRenderer[]>();
        set => SetField(value);
    }

    public GameObject inspect
    {
        get => orig.inspect;
        set => orig.inspect = value;
    }

    public TriggerEnterEvent triggerEvent
    {
        get => orig.triggerEvent;
        set => orig.triggerEvent = value;
    }

    public BossStatue parentStatue
    {
        get => GetField<BossStatue>();
        set => SetField(value);
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Material mat
    {
        get => GetField<Material>();
        set => SetField(value);
    }

    public MaterialPropertyBlock propBlock
    {
        get => GetField<MaterialPropertyBlock>();
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

    public IEnumerator FlashRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public void FlashApex()
    {
        orig.FlashApex();
    }
}