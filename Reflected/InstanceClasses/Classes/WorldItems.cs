namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WorldItems allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldItemsR:InstanceClassWrapper<TeamCherry.WorldItems>
{
public WorldItemsR(TeamCherry.WorldItems _orig) : base(_orig) {}
public System.Collections.Generic.List<GeoRock> geoRocks
{
get => orig.geoRocks;
set => orig.geoRocks = value;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public void OnEnable () =>
orig.OnEnable();

public void RegisterGeoRock () =>
orig.RegisterGeoRock();

}
}
