namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InfectedEnemyEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InfectedEnemyEffectsR : InstanceClassWrapper<InfectedEnemyEffects>
{
    public InfectedEnemyEffectsR(InfectedEnemyEffects _orig) : base(_orig)
    {
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public Vector3 effectOrigin
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public AudioEvent impactAudio
    {
        get => GetField<AudioEvent>();
        set => SetField(value);
    }

    public AudioSource audioSourcePrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public GameObject hitFlashOrangePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject spatterOrangePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject hitPuffPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool noBlood
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool didFireThisFrame
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void RecieveHitEffect(float attackDirection)
    {
        orig.RecieveHitEffect(attackDirection);
    }

    public void Update()
    {
        CallMethod();
    }
}