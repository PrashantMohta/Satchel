using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HealthManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HealthManagerR : InstanceClassWrapper<HealthManager>
{
    public HealthManagerR(HealthManager _orig) : base(_orig)
    {
    }

    public BoxCollider2D boxCollider
    {
        get => GetField<BoxCollider2D>();
        set => SetField(value);
    }

    public Recoil recoil
    {
        get => GetField<Recoil>();
        set => SetField(value);
    }

    public IHitEffectReciever hitEffectReceiver
    {
        get => GetField<IHitEffectReciever>();
        set => SetField(value);
    }

    public EnemyDeathEffects enemyDeathEffects
    {
        get => GetField<EnemyDeathEffects>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }

    public DamageHero damageHero
    {
        get => GetField<DamageHero>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public AudioEvent regularInvincibleAudio
    {
        get => GetField<AudioEvent>();
        set => SetField(value);
    }

    public GameObject blockHitPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject strikeNailPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject slashImpactPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject fireballHitPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject sharpShadowImpactPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject corpseSplatPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public AudioEvent enemyDeathSwordAudio
    {
        get => GetField<AudioEvent>();
        set => SetField(value);
    }

    public AudioEvent enemyDamageAudio
    {
        get => GetField<AudioEvent>();
        set => SetField(value);
    }

    public GameObject smallGeoPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject mediumGeoPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject largeGeoPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public int hp
    {
        get => orig.hp;
        set => orig.hp = value;
    }

    public int enemyType
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Vector3 effectOrigin
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool ignoreKillAll
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject battleScene
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject sendHitTo
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject sendKilledToObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public string sendKilledToName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int smallGeoDrops
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int mediumGeoDrops
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int largeGeoDrops
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool megaFlingGeo
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasAlternateHitAnimation
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string alternateHitAnimation
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool invincible
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int invincibleFromDirection
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool preventInvincibleEffect
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hasAlternateInvincibleSound
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AudioClip alternateInvincibleSound
    {
        get => GetField<AudioClip>();
        set => SetField(value);
    }

    public AudioMixerSnapshot deathAudioSnapshot
    {
        get => GetField<AudioMixerSnapshot>();
        set => SetField(value);
    }

    public bool hasSpecialDeath
    {
        get => orig.hasSpecialDeath;
        set => orig.hasSpecialDeath = value;
    }

    public bool deathReset
    {
        get => orig.deathReset;
        set => orig.deathReset = value;
    }

    public bool damageOverride
    {
        get => orig.damageOverride;
        set => orig.damageOverride = value;
    }

    public bool ignoreAcid
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showGodfinderIcon
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float showGodFinderDelay
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public BossScene unlockBossScene
    {
        get => GetField<BossScene>();
        set => SetField(value);
    }

    public bool ignoreHazards
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool ignoreWater
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float invulnerableTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool semiPersistent
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isDead
    {
        get => orig.isDead;
        set => orig.isDead = value;
    }

    public GameObject sendKilledTo
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public float evasionByHitRemaining
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int directionOfLastAttack
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public PlayMakerFSM stunControlFSM
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public bool notifiedBattleScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string CheckPersistenceKey
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public bool IsInvincible
    {
        get => orig.IsInvincible;
        set => orig.IsInvincible = value;
    }

    public int InvincibleFromDirection
    {
        get => orig.InvincibleFromDirection;
        set => orig.InvincibleFromDirection = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public IEnumerator CheckPersistence()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Hit(HitInstance hitInstance)
    {
        orig.Hit(hitInstance);
    }

    public void Invincible(HitInstance hitInstance)
    {
        CallMethod(new object[] { hitInstance });
    }

    public void TakeDamage(HitInstance hitInstance)
    {
        CallMethod(new object[] { hitInstance });
    }

    public void NonFatalHit(bool ignoreEvasion)
    {
        CallMethod(new object[] { ignoreEvasion });
    }

    public void ApplyExtraDamage(int damageAmount)
    {
        orig.ApplyExtraDamage(damageAmount);
    }

    public void Die(float? attackDirection, AttackTypes attackType, bool ignoreEvasion)
    {
        orig.Die(attackDirection, attackType, ignoreEvasion);
    }

    public void SendDeathEvent()
    {
        orig.SendDeathEvent();
    }

    public void SetGeoFlashing(GameObject[] gameObjects, int originalAmount)
    {
        CallMethod(new object[] { gameObjects, originalAmount });
    }

    public bool IsBlockingByDirection(int cardinalDirection, AttackTypes attackType)
    {
        return orig.IsBlockingByDirection(cardinalDirection, attackType);
    }

    public void SetBattleScene(GameObject newBattleScene)
    {
        orig.SetBattleScene(newBattleScene);
    }

    public int GetAttackDirection()
    {
        return orig.GetAttackDirection();
    }

    public void SetPreventInvincibleEffect(bool set)
    {
        orig.SetPreventInvincibleEffect(set);
    }

    public void SetGeoSmall(int amount)
    {
        orig.SetGeoSmall(amount);
    }

    public void SetGeoMedium(int amount)
    {
        orig.SetGeoMedium(amount);
    }

    public void SetGeoLarge(int amount)
    {
        orig.SetGeoLarge(amount);
    }

    public bool GetIsDead()
    {
        return orig.GetIsDead();
    }

    public void SetIsDead(bool set)
    {
        orig.SetIsDead(set);
    }

    public void SetDamageOverride(bool set)
    {
        orig.SetDamageOverride(set);
    }

    public void SetSendKilledToObject(GameObject killedObject)
    {
        orig.SetSendKilledToObject(killedObject);
    }

    public bool CheckInvincible()
    {
        return orig.CheckInvincible();
    }
}