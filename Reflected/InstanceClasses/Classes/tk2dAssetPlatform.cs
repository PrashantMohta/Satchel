namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dAssetPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dAssetPlatformR:InstanceClassWrapper<tk2dAssetPlatform>
{
public tk2dAssetPlatformR(tk2dAssetPlatform _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public float scale
{
get => orig.scale;
set => orig.scale = value;
}

}
}
