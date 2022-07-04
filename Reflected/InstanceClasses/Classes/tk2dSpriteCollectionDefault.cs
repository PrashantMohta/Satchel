namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionDefault allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionDefaultR:InstanceClassWrapper<tk2dSpriteCollectionDefault>
{
public tk2dSpriteCollectionDefaultR(tk2dSpriteCollectionDefault _orig) : base(_orig) {}
public bool additive
{
get => orig.additive;
set => orig.additive = value;
}

public UnityEngine.Vector3 scale
{
get => orig.scale;
set => orig.scale = value;
}

}
}
