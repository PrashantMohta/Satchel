using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ColorFader allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColorFaderR : InstanceClassWrapper<ColorFader>
{
    public ColorFaderR(ColorFader _orig) : base(_orig)
    {
    }

    public Color downColour
    {
        get => orig.downColour;
        set => orig.downColour = value;
    }

    public float downTime
    {
        get => orig.downTime;
        set => orig.downTime = value;
    }

    public Color upColour
    {
        get => orig.upColour;
        set => orig.upColour = value;
    }

    public float upDelay
    {
        get => orig.upDelay;
        set => orig.upDelay = value;
    }

    public float upTime
    {
        get => orig.upTime;
        set => orig.upTime = value;
    }

    public Color initialColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool useInitialColour
    {
        get => orig.useInitialColour;
        set => orig.useInitialColour = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public TextMeshPro textRenderer
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public tk2dSprite tk2dSprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }

    public bool setup
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Coroutine fadeRoutine
    {
        get => GetField<Coroutine>();
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

    public void Setup()
    {
        CallMethod();
    }

    public void Fade(bool up)
    {
        orig.Fade(up);
    }

    public IEnumerator Fade(Color to, float time, float delay)
    {
        return CallMethod<IEnumerator>(new object[] { to, time, delay });
    }
}