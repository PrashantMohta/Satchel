namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyDeathEffects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyDeathEffectsR:InstanceClassWrapper<EnemyDeathEffects>
{
public EnemyDeathEffectsR(EnemyDeathEffects _orig) : base(_orig) {}
public UnityEngine.GameObject corpsePrefab
{
get => GetField<UnityEngine.GameObject>();
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

public UnityEngine.Vector3 corpseSpawnPoint
{
get => orig.corpseSpawnPoint;
set => orig.corpseSpawnPoint = value;
}

public string deathBroadcastEvent
{
get => GetField<string>();
set => SetField(value);
}

public UnityEngine.Vector3 effectOrigin
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

public UnityEngine.Audio.AudioMixerSnapshot audioSnapshotOnDeath
{
get => GetField<UnityEngine.Audio.AudioMixerSnapshot>();
set => SetField(value);
}

public UnityEngine.GameObject journalUpdateMessagePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject journalUpdateMessageSpawned
{
get => GetFieldStatic<UnityEngine.GameObject>();
set => SetField(value);
}

public EnemyDeathTypes enemyDeathType
{
get => GetField<EnemyDeathTypes>();
set => SetField(value);
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => GetField<UnityEngine.AudioSource>();
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

public UnityEngine.AudioClip enemyDeathSwordClip
{
get => GetField<UnityEngine.AudioClip>();
set => SetField(value);
}

public UnityEngine.AudioClip enemyDamageClip
{
get => GetField<UnityEngine.AudioClip>();
set => SetField(value);
}

public UnityEngine.GameObject deathWaveInfectedPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject deathWaveInfectedSmallPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject spatterOrangePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject deathPuffMedPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject deathPuffLargePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject dreamEssenceCorpseGetPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject corpse
{
get => GetField<UnityEngine.GameObject>();
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



public void Start () =>
CallMethod();

public void PreInstantiate () =>
orig.PreInstantiate();

public void RecieveDeathEvent (System.Single? attackDirection, bool resetDeathEvent = false, bool spellBurn = false, bool isWatery = false) =>
orig.RecieveDeathEvent(attackDirection, resetDeathEvent, spellBurn, isWatery);

public void RecordKillForJournal () =>
CallMethod();

public void EmitCorpse (System.Single? attackDirection, bool isWatery, bool spellBurn = false) =>
CallMethod(new object[] {attackDirection, isWatery, spellBurn});

public void EmitEffects () =>
CallMethod();

public void EmitSound () =>
orig.EmitSound();

public void EmitInfectedEffects () =>
CallMethod();

public void EmitSmallInfectedEffects () =>
CallMethod();

public void EmitLargeInfectedEffects () =>
CallMethod();

public void ShakeCameraIfVisible (string eventName) =>
CallMethod(new object[] {eventName});

public void EmitEssence () =>
CallMethod();

public void orig_RecieveDeathEvent (System.Single? attackDirection, bool resetDeathEvent = false, bool spellBurn = false, bool isWatery = false) =>
orig.orig_RecieveDeathEvent(attackDirection, resetDeathEvent, spellBurn, isWatery);

public void orig_RecordKillForJournal () =>
CallMethod();

}
}
