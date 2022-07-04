namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DreamPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DreamPlatformR : InstanceClassWrapper<DreamPlatform>
{
    public DreamPlatformR(DreamPlatform _orig) : base(_orig)
    {
    }

    public TriggerEnterEvent outerCollider
    {
        get => orig.outerCollider;
        set => orig.outerCollider = value;
    }

    public TriggerEnterEvent innerCollider
    {
        get => orig.innerCollider;
        set => orig.innerCollider = value;
    }

    public Animator animator
    {
        get => orig.animator;
        set => orig.animator = value;
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

    public bool visible
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showOnEnable
    {
        get => orig.showOnEnable;
        set => orig.showOnEnable = value;
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
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

    public void OnEnable()
    {
        CallMethod();
    }

    public void Show()
    {
        orig.Show();
    }

    public void Hide()
    {
        orig.Hide();
    }

    public void PlayAnimation(string animationName)
    {
        CallMethod(new object[] { animationName });
    }
}