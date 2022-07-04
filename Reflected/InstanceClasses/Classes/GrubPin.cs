namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrubPin allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrubPinR:InstanceClassWrapper<GrubPin>
{
public GrubPinR(GrubPin _orig) : base(_orig) {}
public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

}
}
