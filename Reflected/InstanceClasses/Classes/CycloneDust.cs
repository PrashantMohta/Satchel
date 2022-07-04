namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CycloneDust allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CycloneDustR:InstanceClassWrapper<CycloneDust>
{
public CycloneDustR(CycloneDust _orig) : base(_orig) {}
public float dustY
{
get => orig.dustY;
set => orig.dustY = value;
}

public UnityEngine.ParticleSystem particle
{
get => orig.particle;
set => orig.particle = value;
}

public UnityEngine.Transform parent
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public bool playing
{
get => GetField<bool>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
