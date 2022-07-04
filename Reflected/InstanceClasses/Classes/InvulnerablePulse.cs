namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InvulnerablePulse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvulnerablePulseR:InstanceClassWrapper<InvulnerablePulse>
{
public InvulnerablePulseR(InvulnerablePulse _orig) : base(_orig) {}
public UnityEngine.Color invulColor
{
get => orig.invulColor;
set => orig.invulColor = value;
}

public float pulseDuration
{
get => orig.pulseDuration;
set => orig.pulseDuration = value;
}

public UnityEngine.Color normalColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public tk2dSprite sprite
{
get => GetField<tk2dSprite>();
set => SetField(value);
}

public bool pulsing
{
get => GetField<bool>();
set => SetField(value);
}

public bool reverse
{
get => GetField<bool>();
set => SetField(value);
}

public float currentLerpTime
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void startInvulnerablePulse () =>
orig.startInvulnerablePulse();

public void stopInvulnerablePulse () =>
orig.stopInvulnerablePulse();

public void updateSpriteColor (UnityEngine.Color color) =>
orig.updateSpriteColor(color);

}
}
