namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BrokenVesselGlob allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BrokenVesselGlobR:InstanceClassWrapper<BrokenVesselGlob>
{
public BrokenVesselGlobR(BrokenVesselGlob _orig) : base(_orig) {}
public UnityEngine.ParticleSystem gasParticle
{
get => orig.gasParticle;
set => orig.gasParticle = value;
}

public UnityEngine.Rigidbody2D rb
{
get => orig.rb;
set => orig.rb = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 force
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float stretchFactor
{
get => GetField<float>();
set => SetField(value);
}

public float stretchMinX
{
get => GetField<float>();
set => SetField(value);
}

public float stretchMaxY
{
get => GetField<float>();
set => SetField(value);
}

public float scaleModifier
{
get => GetField<float>();
set => SetField(value);
}

public float scaleModifierMin
{
get => GetField<float>();
set => SetField(value);
}

public float scaleModifierMax
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void FaceAngle () =>
CallMethod();

public void ProjectileSquash () =>
CallMethod();

}
}
