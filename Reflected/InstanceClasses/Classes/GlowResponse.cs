namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GlowResponse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GlowResponseR : InstanceClassWrapper<GlowResponse>
{
    public GlowResponseR(GlowResponse _orig) : base(_orig)
    {
    }

    public SpriteRenderer fadeSprite
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public List<SpriteRenderer> FadeSprites
    {
        get => orig.FadeSprites;
        set => orig.FadeSprites = value;
    }

    public float fadeTime
    {
        get => orig.fadeTime;
        set => orig.fadeTime = value;
    }

    public ParticleSystem particles
    {
        get => orig.particles;
        set => orig.particles = value;
    }

    public Light light
    {
        get => orig.light;
        set => orig.light = value;
    }

    public float lightStart
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public AudioEventRandom soundEffect
    {
        get => orig.soundEffect;
        set => orig.soundEffect = value;
    }

    public Dictionary<SpriteRenderer, Coroutine> fadeRoutines
    {
        get => GetField<Dictionary<SpriteRenderer, Coroutine>>();
        set => SetField(value);
    }


    public void OnValidate()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void HandleUpgrade()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void FadeTo(float alpha)
    {
        CallMethod(new object[] { alpha });
    }

    public IEnumerator Fade(float toAlpha, SpriteRenderer sprite)
    {
        return CallMethod<IEnumerator>(new object[] { toAlpha, sprite });
    }

    public void FadeEnd()
    {
        orig.FadeEnd();
    }
}