namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of JumpEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JumpEffectsR : InstanceClassWrapper<JumpEffects>
{
    public JumpEffectsR(JumpEffects _orig) : base(_orig)
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

    public GameObject jumpPuff
    {
        get => orig.jumpPuff;
        set => orig.jumpPuff = value;
    }

    public GameObject dustTrail
    {
        get => orig.dustTrail;
        set => orig.dustTrail = value;
    }

    public GameObject spatterWhitePrefab
    {
        get => orig.spatterWhitePrefab;
        set => orig.spatterWhitePrefab = value;
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

    public float fallTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float dripTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float dripEndTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool dripping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool checkForFall
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool trailAttached
    {
        get => GetField<bool>();
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

    public void GetHero()
    {
        CallMethod();
    }

    public void CheckForFall()
    {
        CallMethod();
    }

    public void PlayTrail()
    {
        CallMethod();
    }

    public void PlayJumpPuff()
    {
        CallMethod();
    }

    public void SplashOut()
    {
        CallMethod();
    }
}