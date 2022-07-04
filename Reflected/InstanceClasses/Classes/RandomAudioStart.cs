namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RandomAudioStart allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomAudioStartR : InstanceClassWrapper<RandomAudioStart>
{
    public RandomAudioStartR(RandomAudioStart _orig) : base(_orig)
    {
    }

    public AudioSource audioSource
    {
        get => orig.audioSource;
        set => orig.audioSource = value;
    }

    public float timeMin
    {
        get => orig.timeMin;
        set => orig.timeMin = value;
    }

    public float timeMax
    {
        get => orig.timeMax;
        set => orig.timeMax = value;
    }

    public float time
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool started
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}