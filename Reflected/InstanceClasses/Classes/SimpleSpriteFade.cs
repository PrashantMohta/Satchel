namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SimpleSpriteFade allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SimpleSpriteFadeR:InstanceClassWrapper<SimpleSpriteFade>
{
public SimpleSpriteFadeR(SimpleSpriteFade _orig) : base(_orig) {}
public UnityEngine.Color fadeInColor
{
get => orig.fadeInColor;
set => orig.fadeInColor = value;
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public UnityEngine.Color normalColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public float fadeDuration
{
get => orig.fadeDuration;
set => orig.fadeDuration = value;
}

public bool fadingIn
{
get => GetField<bool>();
set => SetField(value);
}

public bool fadingOut
{
get => GetField<bool>();
set => SetField(value);
}

public float currentLerpTime
{
get => GetField<float>();
set => SetField(value);
}

public bool fadeInOnStart
{
get => orig.fadeInOnStart;
set => orig.fadeInOnStart = value;
}

public bool deactivateOnFadeIn
{
get => orig.deactivateOnFadeIn;
set => orig.deactivateOnFadeIn = value;
}

public bool recycleOnFadeIn
{
get => orig.recycleOnFadeIn;
set => orig.recycleOnFadeIn = value;
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
