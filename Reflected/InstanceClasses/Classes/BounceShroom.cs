namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BounceShroom allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BounceShroomR:InstanceClassWrapper<BounceShroom>
{
public BounceShroomR(BounceShroom _orig) : base(_orig) {}
public bool active
{
get => orig.active;
set => orig.active = value;
}

public UnityEngine.GameObject idleParticlePrefab
{
get => orig.idleParticlePrefab;
set => orig.idleParticlePrefab = value;
}

public UnityEngine.GameObject bounceSmallPrefab
{
get => orig.bounceSmallPrefab;
set => orig.bounceSmallPrefab = value;
}

public UnityEngine.GameObject bounceLargePrefab
{
get => orig.bounceLargePrefab;
set => orig.bounceLargePrefab = value;
}

public UnityEngine.GameObject heroParticlePrefab
{
get => orig.heroParticlePrefab;
set => orig.heroParticlePrefab = value;
}

public float bounceParticleDelay
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float nextBounceParticleTime
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public string idleAnim
{
get => orig.idleAnim;
set => orig.idleAnim = value;
}

public string bobAnim
{
get => orig.bobAnim;
set => orig.bobAnim = value;
}

public string bounceAnim
{
get => orig.bounceAnim;
set => orig.bounceAnim = value;
}

public UnityEngine.GameObject hitEffect
{
get => orig.hitEffect;
set => orig.hitEffect = value;
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => orig.audioSourcePrefab;
set => orig.audioSourcePrefab = value;
}

public RandomAudioClipTable hitSound
{
get => orig.hitSound;
set => orig.hitSound = value;
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.Coroutine idleRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine bounceRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.GameObject heroParticles
{
get => GetFieldStatic<UnityEngine.GameObject>();
set => SetField(value);
}

public float nextCamShakeTime
{
get => GetFieldStatic<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public System.Collections.IEnumerator Idle () =>
CallMethod<System.Collections.IEnumerator>();

public void BounceSmall () =>
CallMethod();

public System.Collections.IEnumerator Bounce () =>
CallMethod<System.Collections.IEnumerator>();

public void BounceLarge (bool useEffects = true) =>
orig.BounceLarge(useEffects);

}
}
