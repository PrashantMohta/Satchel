namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneManagerSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneManagerSettingsR : InstanceClassWrapper<SceneManagerSettings>
{
    public SceneManagerSettingsR(SceneManagerSettings _orig) : base(_orig)
    {
    }

    public MapZone mapZone
    {
        get => orig.mapZone;
        set => orig.mapZone = value;
    }

    public Color defaultColor
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

    public AnimationCurve redChannel
    {
        get => orig.redChannel;
        set => orig.redChannel = value;
    }

    public AnimationCurve greenChannel
    {
        get => orig.greenChannel;
        set => orig.greenChannel = value;
    }

    public AnimationCurve blueChannel
    {
        get => orig.blueChannel;
        set => orig.blueChannel = value;
    }

    public Color heroLightColor
    {
        get => orig.heroLightColor;
        set => orig.heroLightColor = value;
    }
}