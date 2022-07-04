namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ColorFader allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColorFaderR:InstanceClassWrapper<ColorFader>
{
public ColorFaderR(ColorFader _orig) : base(_orig) {}
public UnityEngine.Color downColour
{
get => orig.downColour;
set => orig.downColour = value;
}

public float downTime
{
get => orig.downTime;
set => orig.downTime = value;
}

public UnityEngine.Color upColour
{
get => orig.upColour;
set => orig.upColour = value;
}

public float upDelay
{
get => orig.upDelay;
set => orig.upDelay = value;
}

public float upTime
{
get => orig.upTime;
set => orig.upTime = value;
}

public UnityEngine.Color initialColour
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool useInitialColour
{
get => orig.useInitialColour;
set => orig.useInitialColour = value;
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public TMPro.TextMeshPro textRenderer
{
get => GetField<TMPro.TextMeshPro>();
set => SetField(value);
}

public tk2dSprite tk2dSprite
{
get => GetField<tk2dSprite>();
set => SetField(value);
}

public bool setup
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Coroutine fadeRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}



public void Reset () =>
CallMethod();

public void Start () =>
CallMethod();

public void Setup () =>
CallMethod();

public void Fade (bool up) =>
orig.Fade(up);

public System.Collections.IEnumerator Fade (UnityEngine.Color to, float time, float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {to, time, delay});

}
}
