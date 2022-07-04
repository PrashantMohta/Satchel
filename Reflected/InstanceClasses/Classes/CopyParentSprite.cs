namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CopyParentSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CopyParentSpriteR:InstanceClassWrapper<CopyParentSprite>
{
public CopyParentSpriteR(CopyParentSprite _orig) : base(_orig) {}


public void Start () =>
CallMethod();

}
}
