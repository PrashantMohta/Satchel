namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Throbber allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ThrobberR:InstanceClassWrapper<Throbber>
{
public ThrobberR(Throbber _orig) : base(_orig) {}
public UnityEngine.UI.Image image
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public UnityEngine.Sprite[] sprites
{
get => GetField<UnityEngine.Sprite[]>();
set => SetField(value);
}

public float frameRate
{
get => GetField<float>();
set => SetField(value);
}

public float frameTimer
{
get => GetField<float>();
set => SetField(value);
}

public int frameIndex
{
get => GetField<int>();
set => SetField(value);
}



public void Update () =>
CallMethod();

}
}
