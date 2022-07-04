namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneryTriggerCircle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneryTriggerCircleR : InstanceClassWrapper<SceneryTriggerCircle>
{
    public SceneryTriggerCircleR(SceneryTriggerCircle _orig) : base(_orig)
    {
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public CircleCollider2D[] col2ds
    {
        get => GetField<CircleCollider2D[]>();
        set => SetField(value);
    }

    public int enterCount
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => orig.audioSource;
        set => orig.audioSource = value;
    }

    public AudioClip activateSound
    {
        get => orig.activateSound;
        set => orig.activateSound = value;
    }

    public AudioClip deactivateSound
    {
        get => orig.deactivateSound;
        set => orig.deactivateSound = value;
    }

    public bool active
    {
        get => orig.active;
        set => SetProperty(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public void RandomizePitch(AudioSource src, float minPitch, float maxPitch)
    {
        CallMethod(new object[] { src, minPitch, maxPitch });
    }

    public void ResetPitch(AudioSource src)
    {
        CallMethod(new object[] { src });
    }
}