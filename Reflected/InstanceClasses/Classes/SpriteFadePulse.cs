namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteFadePulse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteFadePulseR:InstanceClassWrapper<SpriteFadePulse>
{
public SpriteFadePulseR(SpriteFadePulse _orig) : base(_orig) {}
public float lowAlpha
{
get => orig.lowAlpha;
set => orig.lowAlpha = value;
}

public float highAlpha
{
get => orig.highAlpha;
set => orig.highAlpha = value;
}

public float fadeDuration
{
get => orig.fadeDuration;
set => orig.fadeDuration = value;
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public int state
{
get => GetField<int>();
set => SetField(value);
}

public float currentLerpTime
{
get => GetField<float>();
set => SetField(value);
}

public float currentAlpha
{
get => GetField<float>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void FadeIn () =>
orig.FadeIn();

public void FadeOut () =>
orig.FadeOut();

}
}
