namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneParticles allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneParticlesR : InstanceClassWrapper<SceneParticles>
{
    public SceneParticlesR(SceneParticles _orig) : base(_orig)
    {
    }

    public GameObject particleObject
    {
        get => orig.particleObject;
        set => orig.particleObject = value;
    }

    public MapZone mapZone
    {
        get => orig.mapZone;
        set => orig.mapZone = value;
    }
}