namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseFungusExplode allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseFungusExplodeR:InstanceClassWrapper<CorpseFungusExplode>
{
public CorpseFungusExplodeR(CorpseFungusExplode _orig) : base(_orig) {}
public UnityEngine.ParticleSystem anticSteam
{
get => orig.anticSteam;
set => orig.anticSteam = value;
}

public UnityEngine.ParticleSystem gasAttack
{
get => orig.gasAttack;
set => orig.gasAttack = value;
}

public AudioEvent gushSound
{
get => orig.gushSound;
set => orig.gushSound = value;
}

public AudioEvent explodeSound
{
get => orig.explodeSound;
set => orig.explodeSound = value;
}

public UnityEngine.GameObject gasHitBox
{
get => orig.gasHitBox;
set => orig.gasHitBox = value;
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

public System.Collections.IEnumerator DoLandEffects () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Jitter (float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {duration});

}
}
