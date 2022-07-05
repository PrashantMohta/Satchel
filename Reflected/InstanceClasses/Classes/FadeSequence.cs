namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FadeSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FadeSequenceR : InstanceClassWrapper<FadeSequence>
{
    public FadeSequenceR(FadeSequence _orig) : base(_orig)
    {
    }

    public SkippableSequence childSequence
    {
        get => GetField<SkippableSequence>();
        set => SetField(value);
    }

    public float fade
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeByController
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeDelay
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool IsSkipped => orig.IsSkipped;

    public float FadeRate => orig.FadeRate;

    public float FadeByController
    {
        get => orig.FadeByController;
        set => orig.FadeByController = value;
    }

    public bool IsPlaying => orig.IsPlaying;


    public void Awake()
    {
        CallMethod();
    }

    public void Begin()
    {
        orig.Begin();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Skip()
    {
        orig.Skip();
    }

    public void UpdateFade()
    {
        CallMethod();
    }
}