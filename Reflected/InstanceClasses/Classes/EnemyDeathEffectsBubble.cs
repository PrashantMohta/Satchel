namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyDeathEffectsBubble allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyDeathEffectsBubbleR:InstanceClassWrapper<EnemyDeathEffectsBubble>
{
public EnemyDeathEffectsBubbleR(EnemyDeathEffectsBubble _orig) : base(_orig) {}
public UnityEngine.GameObject bubblePopPrefab
{
get => orig.bubblePopPrefab;
set => orig.bubblePopPrefab = value;
}

public UnityEngine.Vector3 corpseSpawnPoint
{
get => orig.corpseSpawnPoint;
set => orig.corpseSpawnPoint = value;
}

public UnityEngine.Vector3 effectOrigin
{
get => orig.effectOrigin;
set => orig.effectOrigin = value;
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

public bool doKillFreeze
{
get => orig.doKillFreeze;
set => orig.doKillFreeze = value;
}



public void EmitEffects () =>
CallMethod();

}
}
