namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UpdateHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UpdateHelperR:InstanceClassWrapper<HutongGames.PlayMaker.UpdateHelper>
{
public UpdateHelperR(HutongGames.PlayMaker.UpdateHelper _orig) : base(_orig) {}
public void SetDirty (HutongGames.PlayMaker.Fsm fsm) =>
HutongGames.PlayMaker.UpdateHelper.SetDirty(fsm);

}
}
