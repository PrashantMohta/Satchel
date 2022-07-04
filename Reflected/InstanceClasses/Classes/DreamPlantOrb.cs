namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DreamPlantOrb allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DreamPlantOrbR:InstanceClassWrapper<DreamPlantOrb>
{
public DreamPlantOrbR(DreamPlantOrb _orig) : base(_orig) {}
public DreamPlant plant
{
get => DreamPlantOrb.plant;
set => DreamPlantOrb.plant = value;
}

public BasicSpriteAnimator pickupAnim
{
get => orig.pickupAnim;
set => orig.pickupAnim = value;
}

public UnityEngine.Renderer rend
{
get => GetField<UnityEngine.Renderer>();
set => SetField(value);
}

public UnityEngine.Vector3 initialScale
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.AudioSource loopSource
{
get => orig.loopSource;
set => orig.loopSource = value;
}

public UnityEngine.AudioSource soundSource
{
get => orig.soundSource;
set => orig.soundSource = value;
}

public UnityEngine.AudioClip collectSound
{
get => orig.collectSound;
set => orig.collectSound = value;
}

public float basePitch
{
get => orig.basePitch;
set => orig.basePitch = value;
}

public float increasePitch
{
get => orig.increasePitch;
set => orig.increasePitch = value;
}

public float maxPitch
{
get => orig.maxPitch;
set => orig.maxPitch = value;
}

public float pitchReturnDelay
{
get => orig.pitchReturnDelay;
set => orig.pitchReturnDelay = value;
}

public float currentPitch
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float pitchReturnTime
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public UnityEngine.GameObject whiteFlash
{
get => orig.whiteFlash;
set => orig.whiteFlash = value;
}

public UnityEngine.ParticleSystem pickupParticles
{
get => orig.pickupParticles;
set => orig.pickupParticles = value;
}

public UnityEngine.ParticleSystem trailParticles
{
get => orig.trailParticles;
set => orig.trailParticles = value;
}

public UnityEngine.ParticleSystem activateParticles
{
get => orig.activateParticles;
set => orig.activateParticles = value;
}

public UnityEngine.AnimationCurve spread1Curve
{
get => orig.spread1Curve;
set => orig.spread1Curve = value;
}

public UnityEngine.AnimationCurve spread2Curve
{
get => orig.spread2Curve;
set => orig.spread2Curve = value;
}

public bool pickedUp
{
get => GetField<bool>();
set => SetField(value);
}

public bool canPickup
{
get => GetField<bool>();
set => SetField(value);
}

public bool isActive
{
get => GetField<bool>();
set => SetField(value);
}

public bool didEverSetSaveState
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Coroutine spreadRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void Show () =>
orig.Show();

public void SetActive (bool value) =>
CallMethod(new object[] {value});

public System.Collections.IEnumerator Spread () =>
CallMethod<System.Collections.IEnumerator>();

public void Disable () =>
CallMethod();

public System.Collections.IEnumerator DisableAfterTime (UnityEngine.GameObject obj, float time) =>
CallMethod<System.Collections.IEnumerator>(new object[] {obj, time});

public System.Collections.IEnumerator TweenPosition (UnityEngine.Vector3 position, float time, UnityEngine.AnimationCurve curve) =>
CallMethod<System.Collections.IEnumerator>(new object[] {position, time, curve});

}
}
