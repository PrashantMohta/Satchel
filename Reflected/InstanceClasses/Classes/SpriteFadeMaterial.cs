namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteFadeMaterial allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteFadeMaterialR:InstanceClassWrapper<SpriteFadeMaterial>
{
public SpriteFadeMaterialR(SpriteFadeMaterial _orig) : base(_orig) {}
public UnityEngine.Material initialMaterial
{
get => orig.initialMaterial;
set => orig.initialMaterial = value;
}

public float fadeBackDuration
{
get => orig.fadeBackDuration;
set => orig.fadeBackDuration = value;
}

public UnityEngine.SpriteRenderer[] sprites
{
get => GetField<UnityEngine.SpriteRenderer[]>();
set => SetField(value);
}

public UnityEngine.Coroutine fadeRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public System.Action onFadeEnd
{
get => GetField<System.Action>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void FadeBack () =>
orig.FadeBack();

public System.Collections.IEnumerator FadeBackRoutine () =>
CallMethod<System.Collections.IEnumerator>();

}
}
