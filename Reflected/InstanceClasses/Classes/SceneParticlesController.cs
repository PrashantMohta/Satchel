namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneParticlesController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneParticlesControllerR:InstanceClassWrapper<SceneParticlesController>
{
public SceneParticlesControllerR(SceneParticlesController _orig) : base(_orig) {}
public SceneParticles defaultParticles
{
get => orig.defaultParticles;
set => orig.defaultParticles = value;
}

public SceneParticles[] sceneParticles
{
get => orig.sceneParticles;
set => orig.sceneParticles = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public SceneManager sm
{
get => GetField<SceneManager>();
set => SetField(value);
}

public GameCameras gc
{
get => GetField<GameCameras>();
set => SetField(value);
}

public bool foundMatch
{
get => GetField<bool>();
set => SetField(value);
}

public GlobalEnums.MapZone sceneParticleZoneType
{
get => GetField<GlobalEnums.MapZone>();
set => SetField(value);
}



public void SceneInit () =>
orig.SceneInit();

public void EnableParticles () =>
orig.EnableParticles();

public void DisableParticles () =>
orig.DisableParticles();

public void BeginScene () =>
CallMethod();

}
}
