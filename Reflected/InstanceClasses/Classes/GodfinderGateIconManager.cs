namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GodfinderGateIconManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GodfinderGateIconManagerR:InstanceClassWrapper<GodfinderGateIconManager>
{
public GodfinderGateIconManagerR(GodfinderGateIconManager _orig) : base(_orig) {}
public GodfinderGateIcon[] gateIcons
{
get => orig.gateIcons;
set => orig.gateIcons = value;
}

public float offsetX
{
get => orig.offsetX;
set => orig.offsetX = value;
}



public void OnValidate () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void DoLayout () =>
CallMethod();

}
}
