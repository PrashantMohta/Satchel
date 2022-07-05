namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SimpleFadeOut allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SimpleFadeOutR : InstanceClassWrapper<SimpleFadeOut>
{
    public SimpleFadeOutR(SimpleFadeOut _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public float fadeDuration
    {
        get => orig.fadeDuration;
        set => orig.fadeDuration = value;
    }

    public bool waitForCall
    {
        get => orig.waitForCall;
        set => orig.waitForCall = value;
    }

    public Color startColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color fadeColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public float currentLerpTime
    {
        get => GetField<float>();
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

    public void Update()
    {
        CallMethod();
    }

    public void FadeOut()
    {
        orig.FadeOut();
    }
}