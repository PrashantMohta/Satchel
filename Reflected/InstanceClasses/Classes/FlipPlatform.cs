namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FlipPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FlipPlatformR:InstanceClassWrapper<FlipPlatform>
{
public FlipPlatformR(FlipPlatform _orig) : base(_orig) {}
public tk2dSpriteAnimator spriteAnimator
{
get => orig.spriteAnimator;
set => orig.spriteAnimator = value;
}

public UnityEngine.AudioClip flipSound
{
get => orig.flipSound;
set => orig.flipSound = value;
}

public UnityEngine.AudioClip flipBackSound
{
get => orig.flipBackSound;
set => orig.flipBackSound = value;
}

public UnityEngine.AudioClip hitSound
{
get => orig.hitSound;
set => orig.hitSound = value;
}

public UnityEngine.GameObject strikeEffect
{
get => orig.strikeEffect;
set => orig.strikeEffect = value;
}

public UnityEngine.GameObject nailStrikePrefab
{
get => orig.nailStrikePrefab;
set => orig.nailStrikePrefab = value;
}

public UnityEngine.ParticleSystem crystalParticles
{
get => orig.crystalParticles;
set => orig.crystalParticles = value;
}

public UnityEngine.ParticleSystem crystalHitParticles
{
get => orig.crystalHitParticles;
set => orig.crystalHitParticles = value;
}

public UnityEngine.GameObject topSpikes
{
get => orig.topSpikes;
set => orig.topSpikes = value;
}

public UnityEngine.GameObject bottomSpikes
{
get => orig.bottomSpikes;
set => orig.bottomSpikes = value;
}

public UnityEngine.Coroutine idleRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine flipRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public bool hitCancel
{
get => GetField<bool>();
set => SetField(value);
}

public TriggerEnterEvent triggerEnter
{
get => GetField<TriggerEnterEvent>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void PlaySound (UnityEngine.AudioClip clip) =>
CallMethod(new object[] {clip});

public System.Collections.IEnumerator Idle () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Flip () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Jitter (float duration) =>
CallMethod<System.Collections.IEnumerator>(new object[] {duration});

}
}
