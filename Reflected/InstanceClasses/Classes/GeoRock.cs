namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GeoRock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GeoRockR:InstanceClassWrapper<GeoRock>
{
public GeoRockR(GeoRock _orig) : base(_orig) {}
public GeoRockData geoRockData
{
get => orig.geoRockData;
set => orig.geoRockData = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Start () =>
CallMethod();

public void LevelActivated (UnityEngine.SceneManagement.Scene sceneFrom, UnityEngine.SceneManagement.Scene sceneTo) =>
CallMethod(new object[] {sceneFrom, sceneTo});

public void SaveState () =>
CallMethod();

public void SetMyID () =>
CallMethod();

public void UpdateHitsLeftFromFSM () =>
CallMethod();

}
}
