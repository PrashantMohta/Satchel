namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyDeathEffectsBubble allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyDeathEffectsBubbleR : InstanceClassWrapper<EnemyDeathEffectsBubble>
{
    public EnemyDeathEffectsBubbleR(EnemyDeathEffectsBubble _orig) : base(_orig)
    {
    }

    public GameObject bubblePopPrefab
    {
        get => orig.bubblePopPrefab;
        set => orig.bubblePopPrefab = value;
    }

    public Vector3 corpseSpawnPoint
    {
        get => orig.corpseSpawnPoint;
        set => orig.corpseSpawnPoint = value;
    }

    public Vector3 effectOrigin
    {
        get => orig.effectOrigin;
        set => orig.effectOrigin = value;
    }

    public AudioSource audioPlayerPrefab
    {
        get => GetField<AudioSource>();
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

    public AudioClip enemyDeathSwordClip
    {
        get => GetField<AudioClip>();
        set => SetField(value);
    }

    public AudioClip enemyDamageClip
    {
        get => GetField<AudioClip>();
        set => SetField(value);
    }

    public GameObject deathWaveInfectedPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject deathWaveInfectedSmallPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject spatterOrangePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject deathPuffMedPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject deathPuffLargePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject dreamEssenceCorpseGetPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject corpse
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool doKillFreeze
    {
        get => orig.doKillFreeze;
        set => orig.doKillFreeze = value;
    }


    public void EmitEffects()
    {
        CallMethod();
    }
}