namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteColliderIsland allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteColliderIslandR:InstanceClassWrapper<tk2dSpriteColliderIsland>
{
public tk2dSpriteColliderIslandR(tk2dSpriteColliderIsland _orig) : base(_orig) {}
public bool connected
{
get => orig.connected;
set => orig.connected = value;
}

public UnityEngine.Vector2[] points
{
get => orig.points;
set => orig.points = value;
}

public bool IsValid () =>
orig.IsValid();

public void CopyFrom (tk2dSpriteColliderIsland src) =>
orig.CopyFrom(src);

public bool CompareTo (tk2dSpriteColliderIsland src) =>
orig.CompareTo(src);

}
}
