namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyHitEffectsUninfected allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyHitEffectsUninfectedR : InstanceClassWrapper<EnemyHitEffectsUninfected>
{
    public EnemyHitEffectsUninfectedR(EnemyHitEffectsUninfected _orig) : base(_orig)
    {
    }

    public Vector3 effectOrigin
    {
        get => orig.effectOrigin;
        set => orig.effectOrigin = value;
    }

    public AudioSource audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public AudioEvent enemyDamage
    {
        get => orig.enemyDamage;
        set => orig.enemyDamage = value;
    }

    public GameObject uninfectedHitPt
    {
        get => orig.uninfectedHitPt;
        set => orig.uninfectedHitPt = value;
    }

    public GameObject slashEffectGhost1
    {
        get => orig.slashEffectGhost1;
        set => orig.slashEffectGhost1 = value;
    }

    public GameObject slashEffectGhost2
    {
        get => orig.slashEffectGhost2;
        set => orig.slashEffectGhost2 = value;
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public bool sendDamageFlashEvent
    {
        get => orig.sendDamageFlashEvent;
        set => orig.sendDamageFlashEvent = value;
    }

    public bool didFireThisFrame
    {
        get => GetField<bool>();
        set => SetField(value);
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