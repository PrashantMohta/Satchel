namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WaterDrip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WaterDripR:InstanceClassWrapper<WaterDrip>
{
public WaterDripR(WaterDrip _orig) : base(_orig) {}
public float idleTimeMin
{
get => orig.idleTimeMin;
set => orig.idleTimeMin = value;
}

public float idleTimeMax
{
get => orig.idleTimeMax;
set => orig.idleTimeMax = value;
}

public float fallVelocity
{
get => orig.fallVelocity;
set => orig.fallVelocity = value;
}

public RandomAudioClipTable impactAudioClipTable
{
get => orig.impactAudioClipTable;
set => orig.impactAudioClipTable = value;
}

public float impactTranslation
{
get => orig.impactTranslation;
set => orig.impactTranslation = value;
}

public bool impacted
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 startPos
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Collider2D col
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public tk2dSpriteAnimator anim
{
get => GetField<tk2dSpriteAnimator>();
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

public System.Collections.IEnumerator Drip () =>
CallMethod<System.Collections.IEnumerator>();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

}
}
