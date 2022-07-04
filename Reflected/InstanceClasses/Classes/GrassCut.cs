namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrassCut allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassCutR:InstanceClassWrapper<GrassCut>
{
public GrassCutR(GrassCut _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer[] disable
{
get => orig.disable;
set => orig.disable = value;
}

public UnityEngine.SpriteRenderer[] enable
{
get => orig.enable;
set => orig.enable = value;
}

public UnityEngine.Collider2D[] disableColliders
{
get => orig.disableColliders;
set => orig.disableColliders = value;
}

public UnityEngine.Collider2D[] enableColliders
{
get => orig.enableColliders;
set => orig.enableColliders = value;
}

public UnityEngine.GameObject particles
{
get => orig.particles;
set => orig.particles = value;
}

public UnityEngine.GameObject cutEffectPrefab
{
get => orig.cutEffectPrefab;
set => orig.cutEffectPrefab = value;
}

public UnityEngine.Collider2D col
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public bool ShouldCut (UnityEngine.Collider2D collision) =>
GrassCut.ShouldCut(collision);

}
}
