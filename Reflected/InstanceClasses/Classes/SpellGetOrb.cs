namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpellGetOrb allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpellGetOrbR:InstanceClassWrapper<SpellGetOrb>
{
public SpellGetOrbR(SpellGetOrb _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer spriteRenderer
{
get => orig.spriteRenderer;
set => orig.spriteRenderer = value;
}

public UnityEngine.Rigidbody2D rb2d
{
get => orig.rb2d;
set => orig.rb2d = value;
}

public UnityEngine.GameObject trailObject
{
get => orig.trailObject;
set => orig.trailObject = value;
}

public UnityEngine.TrailRenderer trailRenderer
{
get => orig.trailRenderer;
set => orig.trailRenderer = value;
}

public UnityEngine.GameObject orbGetObject
{
get => orig.orbGetObject;
set => orig.orbGetObject = value;
}

public UnityEngine.ParticleSystem ptIdle
{
get => orig.ptIdle;
set => orig.ptIdle = value;
}

public UnityEngine.ParticleSystem ptZoom
{
get => orig.ptZoom;
set => orig.ptZoom = value;
}

public bool trackToHero
{
get => orig.trackToHero;
set => orig.trackToHero = value;
}

public float accel
{
get => GetField<float>();
set => SetField(value);
}

public float accelMultiplier
{
get => GetField<float>();
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

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public float idleTime
{
get => GetField<float>();
set => SetField(value);
}

public float lerpTimer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 startPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 zoomPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.GameObject hero
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public int state
{
get => GetField<int>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void FaceAngle () =>
CallMethod();

public void ProjectileSquash () =>
CallMethod();

public void Collect () =>
CallMethod();

}
}
