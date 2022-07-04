namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BreakablePole allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakablePoleR:InstanceClassWrapper<BreakablePole>
{
public BreakablePoleR(BreakablePole _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer spriteRenderer
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public UnityEngine.Sprite brokenSprite
{
get => GetField<UnityEngine.Sprite>();
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

public UnityEngine.AudioSource audioSourcePrefab
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public RandomAudioClipTable hitClip
{
get => GetField<RandomAudioClipTable>();
set => SetField(value);
}

public UnityEngine.GameObject slashImpactPrefab
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D top
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Start () =>
CallMethod();

public void Hit (HitInstance damageInstance) =>
orig.Hit(damageInstance);

}
}
