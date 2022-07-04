namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyHitEffectsBlackKnight allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyHitEffectsBlackKnightR:InstanceClassWrapper<EnemyHitEffectsBlackKnight>
{
public EnemyHitEffectsBlackKnightR(EnemyHitEffectsBlackKnight _orig) : base(_orig) {}
public UnityEngine.Vector3 effectOrigin
{
get => orig.effectOrigin;
set => orig.effectOrigin = value;
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => orig.audioPlayerPrefab;
set => orig.audioPlayerPrefab = value;
}

public AudioEvent enemyDamage
{
get => orig.enemyDamage;
set => orig.enemyDamage = value;
}

public UnityEngine.GameObject hitFlashOrange
{
get => orig.hitFlashOrange;
set => orig.hitFlashOrange = value;
}

public UnityEngine.GameObject hitPuffLarge
{
get => orig.hitPuffLarge;
set => orig.hitPuffLarge = value;
}

public SpriteFlash spriteFlash
{
get => GetField<SpriteFlash>();
set => SetField(value);
}

public bool didFireThisFrame
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void RecieveHitEffect (float attackDirection) =>
orig.RecieveHitEffect(attackDirection);

public void Update () =>
CallMethod();

}
}
