namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SoulOrb allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SoulOrbR:InstanceClassWrapper<SoulOrb>
{
public SoulOrbR(SoulOrb _orig) : base(_orig) {}
public RandomAudioClipTable soulOrbCollectSounds
{
get => orig.soulOrbCollectSounds;
set => orig.soulOrbCollectSounds = value;
}

public UnityEngine.ParticleSystem getParticles
{
get => orig.getParticles;
set => orig.getParticles = value;
}

public bool awardSoul
{
get => orig.awardSoul;
set => orig.awardSoul = value;
}

public bool dontRecycle
{
get => orig.dontRecycle;
set => orig.dontRecycle = value;
}

public UnityEngine.Transform target
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public float speed
{
get => GetField<float>();
set => SetField(value);
}

public float acceleration
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer sprite
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public UnityEngine.TrailRenderer trail
{
get => GetField<UnityEngine.TrailRenderer>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.AudioSource source
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Coroutine zoomRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public float stretchFactor
{
get => orig.stretchFactor;
set => orig.stretchFactor = value;
}

public float stretchMinY
{
get => orig.stretchMinY;
set => orig.stretchMinY = value;
}

public float stretchMaxX
{
get => orig.stretchMaxX;
set => orig.stretchMaxX = value;
}

public float scaleModifier
{
get => orig.scaleModifier;
set => orig.scaleModifier = value;
}

public float scaleModifierMin
{
get => orig.scaleModifierMin;
set => orig.scaleModifierMin = value;
}

public float scaleModifierMax
{
get => orig.scaleModifierMax;
set => orig.scaleModifierMax = value;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void SceneLoading () =>
CallMethod();

public System.Collections.IEnumerator Zoom (bool doZoom = true) =>
CallMethod<System.Collections.IEnumerator>(new object[] {doZoom});

public void FireAtTarget () =>
CallMethod();

public void FaceAngle () =>
CallMethod();

public void ProjectileSquash () =>
CallMethod();

}
}
