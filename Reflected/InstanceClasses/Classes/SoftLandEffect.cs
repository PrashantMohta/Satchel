namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SoftLandEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoftLandEffectR : InstanceClassWrapper<SoftLandEffect>
{
    public SoftLandEffectR(SoftLandEffect _orig) : base(_orig)
    {
    }

    public GameObject dustEffects
    {
        get => orig.dustEffects;
        set => orig.dustEffects = value;
    }

    public GameObject grassEffects
    {
        get => orig.grassEffects;
        set => orig.grassEffects = value;
    }

    public GameObject boneEffects
    {
        get => orig.boneEffects;
        set => orig.boneEffects = value;
    }

    public GameObject splash
    {
        get => orig.splash;
        set => orig.splash = value;
    }

    public AudioClip softLandClip
    {
        get => orig.softLandClip;
        set => orig.softLandClip = value;
    }

    public AudioClip wetLandClip
    {
        get => orig.wetLandClip;
        set => orig.wetLandClip = value;
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public GameObject heroObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public Rigidbody2D heroRigidBody
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator jumpPuffAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public float recycleTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}