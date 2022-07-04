namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Breakable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableR:InstanceClassWrapper<Breakable>
{
public BreakableR(Breakable _orig) : base(_orig) {}
public UnityEngine.Collider2D bodyCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.Renderer wholeRenderer
{
get => GetField<UnityEngine.Renderer>();
set => SetField(value);
}

public UnityEngine.GameObject[] wholeParts
{
get => GetField<UnityEngine.GameObject[]>();
set => SetField(value);
}

public UnityEngine.GameObject[] remnantParts
{
get => GetField<UnityEngine.GameObject[]>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.GameObject> debrisParts
{
get => GetField<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}

public float angleOffset
{
get => GetField<float>();
set => SetField(value);
}

public float inertBackgroundThreshold
{
get => GetField<float>();
set => SetField(value);
}

public float inertForegroundThreshold
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 effectOffset
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSourcePrefab
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public AudioEvent breakAudioEvent
{
get => GetField<AudioEvent>();
set => SetField(value);
}

public RandomAudioClipTable breakAudioClipTable
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public UnityEngine.Transform dustHitRegularPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Transform dustHitDownPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public float flingSpeedMin
{
get => GetField<float>();
set => SetField(value);
}

public float flingSpeedMax
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform strikeEffectPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Transform nailHitEffectPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Transform spellHitEffectPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public bool preventParticleRotation
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.GameObject hitEventReciever
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool forwardBreakEvent
{
get => GetField<bool>();
set => SetField(value);
}

public Probability.ProbabilityGameObject[] containingParticles
{
get => orig.containingParticles;
set => orig.containingParticles = value;
}

public Breakable.FlingObject[] flingObjectRegister
{
get => orig.flingObjectRegister;
set => orig.flingObjectRegister = value;
}

public bool isBroken
{
get => GetField<bool>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void CreateAdditionalDebrisParts (System.Collections.Generic.List<UnityEngine.GameObject> debrisParts) =>
CallMethod(new object[] {debrisParts});

public void BreakSelf () =>
orig.BreakSelf();

public void Hit (HitInstance damageInstance) =>
orig.Hit(damageInstance);

public UnityEngine.Transform SpawnNailHitEffect (UnityEngine.Transform nailHitEffectPrefab, UnityEngine.Vector3 position, float impactAngle) =>
CallMethodStatic<UnityEngine.Transform>(new object[] {nailHitEffectPrefab, position, impactAngle});

public void SetStaticPartsActivation (bool broken) =>
CallMethod(new object[] {broken});

public void Break (float flingAngleMin, float flingAngleMax, float impactMultiplier) =>
orig.Break(flingAngleMin, flingAngleMax, impactMultiplier);

}
}
