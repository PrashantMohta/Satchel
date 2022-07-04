namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyHitEffectsShade allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyHitEffectsShadeR : InstanceClassWrapper<EnemyHitEffectsShade>
{
    public EnemyHitEffectsShadeR(EnemyHitEffectsShade _orig) : base(_orig)
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

    public AudioEvent hollowShadeStartled
    {
        get => orig.hollowShadeStartled;
        set => orig.hollowShadeStartled = value;
    }

    public AudioEvent heroDamage
    {
        get => orig.heroDamage;
        set => orig.heroDamage = value;
    }

    public GameObject hitFlashBlack
    {
        get => orig.hitFlashBlack;
        set => orig.hitFlashBlack = value;
    }

    public GameObject hitShade
    {
        get => orig.hitShade;
        set => orig.hitShade = value;
    }

    public GameObject slashEffectGhostDark1
    {
        get => orig.slashEffectGhostDark1;
        set => orig.slashEffectGhostDark1 = value;
    }

    public GameObject slashEffectGhostDark2
    {
        get => orig.slashEffectGhostDark2;
        set => orig.slashEffectGhostDark2 = value;
    }

    public GameObject slashEffectShade
    {
        get => orig.slashEffectShade;
        set => orig.slashEffectShade = value;
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
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