namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableInfectedVine allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableInfectedVineR:InstanceClassWrapper<BreakableInfectedVine>
{
public BreakableInfectedVineR(BreakableInfectedVine _orig) : base(_orig) {}
public UnityEngine.GameObject[] blobs
{
get => orig.blobs;
set => orig.blobs = value;
}

public UnityEngine.GameObject[] effects
{
get => orig.effects;
set => orig.effects = value;
}

public int spatterAmount
{
get => orig.spatterAmount;
set => orig.spatterAmount = value;
}

public float spatterSpeedMin
{
get => orig.spatterSpeedMin;
set => orig.spatterSpeedMin = value;
}

public float spatterSpeedMax
{
get => orig.spatterSpeedMax;
set => orig.spatterSpeedMax = value;
}

public float spatterAngleMin
{
get => orig.spatterAngleMin;
set => orig.spatterAngleMin = value;
}

public float spatterAngleMax
{
get => orig.spatterAngleMax;
set => orig.spatterAngleMax = value;
}

public float audioPitchMin
{
get => orig.audioPitchMin;
set => orig.audioPitchMin = value;
}

public float audioPitchMax
{
get => orig.audioPitchMax;
set => orig.audioPitchMax = value;
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.AudioSource source
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public VibrationPlayer vibration
{
get => GetField<VibrationPlayer>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void SpawnSpatters (UnityEngine.Vector3 position) =>
CallMethod(new object[] {position});

}
}
