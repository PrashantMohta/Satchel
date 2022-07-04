namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LoadingPulse allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LoadingPulseR:InstanceClassWrapper<LoadingPulse>
{
public LoadingPulseR(LoadingPulse _orig) : base(_orig) {}
public UnityEngine.Color pulseColor
{
get => orig.pulseColor;
set => orig.pulseColor = value;
}

public float pulseDuration
{
get => orig.pulseDuration;
set => orig.pulseDuration = value;
}

public UnityEngine.UI.Image sprite
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public UnityEngine.Color normalColor
{
get => GetField<UnityEngine.Color>();
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

}
}
