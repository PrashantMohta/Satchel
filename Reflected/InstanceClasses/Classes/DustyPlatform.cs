namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DustyPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DustyPlatformR:InstanceClassWrapper<DustyPlatform>
{
public DustyPlatformR(DustyPlatform _orig) : base(_orig) {}
public UnityEngine.BoxCollider2D bodyCollider
{
get => GetField<UnityEngine.BoxCollider2D>();
set => SetField(value);
}

public float inset
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.LayerMask dustIgnoredLayers
{
get => GetField<UnityEngine.LayerMask>();
set => SetField(value);
}

public RandomAudioClipTable dustFallClips
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public UnityEngine.AudioSource dustFallSourcePrefab
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.ParticleSystem dustPrefab
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public UnityEngine.ParticleSystem rocksPrefab
{
get => GetField<UnityEngine.ParticleSystem>();
set => SetField(value);
}

public float dustRateAreaFactor
{
get => GetField<float>();
set => SetField(value);
}

public float dustRateConstant
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.GameObject streamPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Vector3 streamOffset
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public float streamEmissionMin
{
get => GetField<float>();
set => SetField(value);
}

public float streamEmissionMax
{
get => GetField<float>();
set => SetField(value);
}

public float rocksChance
{
get => GetField<float>();
set => SetField(value);
}

public float rocksDelay
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform rockPrefab
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public int rockCountMin
{
get => GetField<int>();
set => SetField(value);
}

public int rockCountMax
{
get => GetField<int>();
set => SetField(value);
}

public float rocksDelayTimer
{
get => GetField<float>();
set => SetField(value);
}

public float cooldownDuration
{
get => GetField<float>();
set => SetField(value);
}

public float cooldownTimer
{
get => GetField<float>();
set => SetField(value);
}

public bool isRunning
{
get => GetField<bool>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void SpawnRocks () =>
CallMethod();

public void SetRateOverTime (UnityEngine.ParticleSystem ps, float rateOverTime) =>
CallMethod(new object[] {ps, rateOverTime});

}
}
