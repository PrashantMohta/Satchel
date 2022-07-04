namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PaintSplat allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PaintSplatR:InstanceClassWrapper<PaintSplat>
{
public PaintSplatR(PaintSplat _orig) : base(_orig) {}


public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
