namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Owner allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OwnerR:InstanceClassWrapper<HutongGames.PlayMaker.Ecosystem.Utils.Owner>
{
public OwnerR(HutongGames.PlayMaker.Ecosystem.Utils.Owner _orig) : base(_orig) {}
public HutongGames.PlayMaker.Ecosystem.Utils.OwnerSelectionOptions selection
{
get => orig.selection;
set => orig.selection = value;
}

public UnityEngine.GameObject gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

}
}
