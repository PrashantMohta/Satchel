namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WaveEffectControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WaveEffectControlR:InstanceClassWrapper<WaveEffectControl>
{
public WaveEffectControlR(WaveEffectControl _orig) : base(_orig) {}
public float timer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Color colour
{
get => orig.colour;
set => orig.colour = value;
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => orig.spriteRenderer;
set => orig.spriteRenderer = value;
}

public float accel
{
get => orig.accel;
set => orig.accel = value;
}

public float accelStart
{
get => orig.accelStart;
set => orig.accelStart = value;
}

public bool doNotRecycle
{
get => orig.doNotRecycle;
set => orig.doNotRecycle = value;
}

public bool doNotPositionZ
{
get => orig.doNotPositionZ;
set => orig.doNotPositionZ = value;
}

public bool blackWave
{
get => orig.blackWave;
set => orig.blackWave = value;
}

public bool otherColour
{
get => orig.otherColour;
set => orig.otherColour = value;
}

public float scaleMultiplier
{
get => orig.scaleMultiplier;
set => orig.scaleMultiplier = value;
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

}
}
