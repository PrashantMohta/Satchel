namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyHitEffectsArmoured allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyHitEffectsArmouredR:InstanceClassWrapper<EnemyHitEffectsArmoured>
{
public EnemyHitEffectsArmouredR(EnemyHitEffectsArmoured _orig) : base(_orig) {}
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

public UnityEngine.GameObject dustHit
{
get => orig.dustHit;
set => orig.dustHit = value;
}

public UnityEngine.GameObject armourHit
{
get => orig.armourHit;
set => orig.armourHit = value;
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
