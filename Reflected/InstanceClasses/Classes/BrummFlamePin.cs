namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BrummFlamePin allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BrummFlamePinR:InstanceClassWrapper<BrummFlamePin>
{
public BrummFlamePinR(BrummFlamePin _orig) : base(_orig) {}
public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

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
