namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Corpse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseR:InstanceClassWrapper<Corpse>
{
public CorpseR(Corpse _orig) : base(_orig) {}
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

public int smashBounces
{
get => GetField<int>();
set => SetField(value);
}

public bool breaker
{
get => GetField<bool>();
set => SetField(value);
}

public bool bigBreaker
{
get => GetField<bool>();
set => SetField(value);
}

public bool chunker
{
get => GetField<bool>();
set => SetField(value);
}

public bool deathStun
{
get => GetField<bool>();
set => SetField(value);
}

public bool fungusExplode
{
get => GetField<bool>();
set => SetField(value);
}

public bool goopExplode
{
get => GetField<bool>();
set => SetField(value);
}

public bool hatcher
{
get => GetField<bool>();
set => SetField(value);
}

public bool instantChunker
{
get => GetField<bool>();
set => SetField(value);
}

public bool massless
{
get => GetField<bool>();
set => SetField(value);
}

public bool resetRotation
{
get => GetField<bool>();
set => SetField(value);
}

public AudioEvent startAudio
{
get => GetField<AudioEvent>();
set => SetField(value);
}

public bool spineBurst
{
get => GetField<bool>();
set => SetField(value);
}

public bool zomHive
{
get => GetField<bool>();
set => SetField(value);
}

public bool noSteam
{
get => GetField<bool>();
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

public bool bouncedThisFrame
{
get => GetField<bool>();
set => SetField(value);
}

public int bounceCount
{
get => GetField<int>();
set => SetField(value);
}

public float landEffectsDelayRemaining
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Setup (bool noSteam, bool spellBurn) =>
orig.Setup(noSteam, spellBurn);

public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void Complete (bool detachChildren, bool destroyMe) =>
CallMethod(new object[] {detachChildren, destroyMe});

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnCollisionStay2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnCollision (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void Land () =>
CallMethod();

public void LandEffects () =>
CallMethod();

public void Smash () =>
CallMethod();

public void Acid () =>
orig.Acid();

public System.Collections.IEnumerator DropThroughFloor () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator DisableFlame () =>
CallMethod<System.Collections.IEnumerator>();

}
}
