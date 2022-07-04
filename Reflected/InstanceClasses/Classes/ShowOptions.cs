namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShowOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShowOptionsR:InstanceClassWrapper<HutongGames.PlayMaker.Ecosystem.Utils.ShowOptions>
{
public ShowOptionsR(HutongGames.PlayMaker.Ecosystem.Utils.ShowOptions _orig) : base(_orig) {}
public System.Object TypeId
{
get => orig.TypeId;
}

}
}
