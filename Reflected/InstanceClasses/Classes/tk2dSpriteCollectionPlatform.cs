namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionPlatform allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionPlatformR:InstanceClassWrapper<tk2dSpriteCollectionPlatform>
{
public tk2dSpriteCollectionPlatformR(tk2dSpriteCollectionPlatform _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public tk2dSpriteCollection spriteCollection
{
get => orig.spriteCollection;
set => orig.spriteCollection = value;
}

public bool Valid
{
get => orig.Valid;
}

public void CopyFrom (tk2dSpriteCollectionPlatform source) =>
orig.CopyFrom(source);

}
}
