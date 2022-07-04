using UnityEngine.Audio;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyDeathEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyDeathEffectsR : InstanceClassWrapper<EnemyDeathEffects>
{
    public EnemyDeathEffectsR(EnemyDeathEffects _orig) : base(_orig)
    {
    }

    public GameObject corpsePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public bool corpseFacesRight
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float corpseFlingSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 corpseSpawnPoint
    {
        get => orig.corpseSpawnPoint;
        set => orig.corpseSpawnPoint = value;
    }

    public string deathBroadcastEvent
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Vector3 effectOrigin
    {
        get => orig.effectOrigin;
        set => orig.effectOrigin = value;
    }

    public bool lowCorpseArc
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string playerDataName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool recycle
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool rotateCorpse
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public AudioMixerSnapshot audioSnapshotOnDeath
    {
        get => GetField<AudioMixerSnapshot>();
        set => SetField(value);
    }

    public GameObject journalUpdateMessagePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject journalUpdateMessageSpawned
    {
        get => GetFieldStatic<GameObject>();
        set => SetField(value);
    }

    public EnemyDeathTypes enemyDeathType
    {
        get => GetField<EnemyDeathTypes>();
        set => SetField(value);
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

    public bool didFire
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool doKillFreeze
    {
        get => orig.doKillFreeze;
        set => orig.doKillFreeze = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void PreInstantiate()
    {
        orig.PreInstantiate();
    }

    public void RecieveDeathEvent(float? attackDirection, bool resetDeathEvent = false, bool spellBurn = false,
        bool isWatery = false)
    {
        orig.RecieveDeathEvent(attackDirection, resetDeathEvent, spellBurn, isWatery);
    }

    public void RecordKillForJournal()
    {
        CallMethod();
    }

    public void EmitCorpse(float? attackDirection, bool isWatery, bool spellBurn = false)
    {
        CallMethod(new object[] { attackDirection, isWatery, spellBurn });
    }

    public void EmitEffects()
    {
        CallMethod();
    }

    public void EmitSound()
    {
        orig.EmitSound();
    }

    public void EmitInfectedEffects()
    {
        CallMethod();
    }

    public void EmitSmallInfectedEffects()
    {
        CallMethod();
    }

    public void EmitLargeInfectedEffects()
    {
        CallMethod();
    }

    public void ShakeCameraIfVisible(string eventName)
    {
        CallMethod(new object[] { eventName });
    }

    public void EmitEssence()
    {
        CallMethod();
    }

    public void orig_RecieveDeathEvent(float? attackDirection, bool resetDeathEvent = false, bool spellBurn = false,
        bool isWatery = false)
    {
        orig.orig_RecieveDeathEvent(attackDirection, resetDeathEvent, spellBurn, isWatery);
    }

    public void orig_RecordKillForJournal()
    {
        CallMethod();
    }
}