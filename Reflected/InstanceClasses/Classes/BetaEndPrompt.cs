namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BetaEndPrompt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BetaEndPromptR : InstanceClassWrapper<BetaEndPrompt>
{
    public BetaEndPromptR(BetaEndPrompt _orig) : base(_orig)
    {
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public float delayDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public SimpleSpriteFade blackFade
    {
        get => GetField<SimpleSpriteFade>();
        set => SetField(value);
    }

    public bool canEnd
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public IEnumerator BeginEnd()
    {
        return CallMethod<IEnumerator>();
    }
}