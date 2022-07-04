namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GeoRockData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GeoRockDataR:InstanceClassWrapper<GeoRockData>
{
public GeoRockDataR(GeoRockData _orig) : base(_orig) {}
public string id
{
get => orig.id;
set => orig.id = value;
}

public string sceneName
{
get => orig.sceneName;
set => orig.sceneName = value;
}

public int hitsLeft
{
get => orig.hitsLeft;
set => orig.hitsLeft = value;
}

}
}
