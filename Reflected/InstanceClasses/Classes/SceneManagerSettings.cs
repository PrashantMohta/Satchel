namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneManagerSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneManagerSettingsR:InstanceClassWrapper<SceneManagerSettings>
{
public SceneManagerSettingsR(SceneManagerSettings _orig) : base(_orig) {}
public GlobalEnums.MapZone mapZone
{
get => orig.mapZone;
set => orig.mapZone = value;
}

public UnityEngine.Color defaultColor
{
get => orig.defaultColor;
set => orig.defaultColor = value;
}

public float defaultIntensity
{
get => orig.defaultIntensity;
set => orig.defaultIntensity = value;
}

public float saturation
{
get => orig.saturation;
set => orig.saturation = value;
}

public UnityEngine.AnimationCurve redChannel
{
get => orig.redChannel;
set => orig.redChannel = value;
}

public UnityEngine.AnimationCurve greenChannel
{
get => orig.greenChannel;
set => orig.greenChannel = value;
}

public UnityEngine.AnimationCurve blueChannel
{
get => orig.blueChannel;
set => orig.blueChannel = value;
}

public UnityEngine.Color heroLightColor
{
get => orig.heroLightColor;
set => orig.heroLightColor = value;
}

}
}
