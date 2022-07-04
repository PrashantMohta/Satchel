namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteFadeMaterial allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteFadeMaterialR : InstanceClassWrapper<SpriteFadeMaterial>
{
    public SpriteFadeMaterialR(SpriteFadeMaterial _orig) : base(_orig)
    {
    }

    public Material initialMaterial
    {
        get => orig.initialMaterial;
        set => orig.initialMaterial = value;
    }

    public float fadeBackDuration
    {
        get => orig.fadeBackDuration;
        set => orig.fadeBackDuration = value;
    }

    public SpriteRenderer[] sprites
    {
        get => GetField<SpriteRenderer[]>();
        set => SetField(value);
    }

    public Coroutine fadeRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public Action onFadeEnd
    {
        get => GetField<Action>();
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

    public void FadeBack()
    {
        orig.FadeBack();
    }

    public IEnumerator FadeBackRoutine()
    {
        return CallMethod<IEnumerator>();
    }
}