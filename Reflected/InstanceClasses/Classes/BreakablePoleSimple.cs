namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BreakablePoleSimple allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakablePoleSimpleR:InstanceClassWrapper<BreakablePoleSimple>
{
public BreakablePoleSimpleR(BreakablePoleSimple _orig) : base(_orig) {}
public UnityEngine.GameObject bottom
{
get => orig.bottom;
set => orig.bottom = value;
}

public UnityEngine.GameObject top
{
get => orig.top;
set => orig.top = value;
}

public float speed
{
get => orig.speed;
set => orig.speed = value;
}

public float angleMin
{
get => orig.angleMin;
set => orig.angleMin = value;
}

public float angleMax
{
get => orig.angleMax;
set => orig.angleMax = value;
}

public UnityEngine.GameObject slashEffectPrefab
{
get => orig.slashEffectPrefab;
set => orig.slashEffectPrefab = value;
}

public float slashAngleMin
{
get => orig.slashAngleMin;
set => orig.slashAngleMin = value;
}

public float slashAngleMax
{
get => orig.slashAngleMax;
set => orig.slashAngleMax = value;
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



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
