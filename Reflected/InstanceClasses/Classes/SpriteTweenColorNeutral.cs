namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteTweenColorNeutral allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteTweenColorNeutralR:InstanceClassWrapper<SpriteTweenColorNeutral>
{
public SpriteTweenColorNeutralR(SpriteTweenColorNeutral _orig) : base(_orig) {}
public UnityEngine.Color Color
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public float Duration
{
get => GetField<float>();
set => SetField(value);
}



public void ColorReturnNeutral () =>
CallMethod();

public void updateSpriteColor (UnityEngine.Color color) =>
CallMethod(new object[] {color});

public void onEnable () =>
CallMethod();

}
}
