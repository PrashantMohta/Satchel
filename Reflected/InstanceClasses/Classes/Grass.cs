namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Grass allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassR:InstanceClassWrapper<Grass>
{
public GrassR(Grass _orig) : base(_orig) {}
public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.Collider2D bodyCollider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public bool isInfectable
{
get => GetField<bool>();
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

public UnityEngine.Color infectedColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool preventPushAnimation
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.GameObject slashImpactPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public float slashImpactRotationMin
{
get => GetField<float>();
set => SetField(value);
}

public float slashImpactRotationMax
{
get => GetField<float>();
set => SetField(value);
}

public float slashImpactScale
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.GameObject infectedCutPrefab0
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject infectedCutPrefab1
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject cutPrefab0
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject cutPrefab1
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.ParticleSystem childParticleSystem
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public float childParticleSystemDuration
{
get => GetField<float>();
set => SetField(value);
}

public RandomAudioClipTable pushAudioClipTable
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public RandomAudioClipTable cutAudioClipTable
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public int IdleStateId
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int PushStateId
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public int DeadStateId
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public bool isInfected
{
get => GetField<bool>();
set => SetField(value);
}

public bool isCut
{
get => GetField<bool>();
set => SetField(value);
}

public float childParticleSystemTimer
{
get => GetField<float>();
set => SetField(value);
}

public System.Collections.Generic.List<Grass> grasses
{
get => GetFieldStatic<System.Collections.Generic.List<Grass>>();
set => SetField(value);
}



public void Init () =>
CallMethodStatic();

public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D other) =>
CallMethod(new object[] {other});

public void Push (bool isAllGrass) =>
orig.Push(isAllGrass);

public void PushAll () =>
Grass.PushAll();

public void Hit (HitInstance damageInstance) =>
orig.Hit(damageInstance);

public void Update () =>
CallMethod();

}
}
