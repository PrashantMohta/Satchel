namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseSpineBurst allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseSpineBurstR:InstanceClassWrapper<CorpseSpineBurst>
{
public CorpseSpineBurstR(CorpseSpineBurst _orig) : base(_orig) {}
public AudioEvent shakerExplode
{
get => orig.shakerExplode;
set => orig.shakerExplode = value;
}

public AudioEvent zombiePrep
{
get => orig.zombiePrep;
set => orig.zombiePrep = value;
}

public AudioEvent zombieShoot
{
get => orig.zombieShoot;
set => orig.zombieShoot = value;
}

public UnityEngine.GameObject spineHit
{
get => orig.spineHit;
set => orig.spineHit = value;
}

public UnityEngine.GameObject lines
{
get => orig.lines;
set => orig.lines = value;
}

public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}

public tk2dSprite sprite
{
get => GetField<tk2dSprite>();
set => SetField(value);
}

public tk2dSpriteAnimator spriteAnimator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public SpriteFlash spriteFlash
{
get => GetField<SpriteFlash>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Collider2D bodyCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.ParticleSystem corpseFlame
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public UnityEngine.ParticleSystem corpseSteam
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public UnityEngine.GameObject landEffects
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.AudioSource audioPlayerPrefab
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.GameObject deathWaveInfectedPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject spatterOrangePrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public RandomAudioClipTable splatAudioClipTable
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public bool spellBurn
{
get => GetField<bool>();
set => SetField(value);
}

public bool hitAcid
{
get => GetField<bool>();
set => SetField(value);
}



public void LandEffects () =>
CallMethod();

public System.Collections.IEnumerator DoLandEffects (bool burst = true) =>
CallMethod<System.Collections.IEnumerator>(new object[] {burst});

}
}
