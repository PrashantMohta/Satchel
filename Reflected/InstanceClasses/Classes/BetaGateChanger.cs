namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BetaGateChanger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BetaGateChangerR:InstanceClassWrapper<BetaGateChanger>
{
public BetaGateChangerR(BetaGateChanger _orig) : base(_orig) {}
public TransitionPoint[] gates
{
get => orig.gates;
set => orig.gates = value;
}



public void SwitchToBetaExit () =>
orig.SwitchToBetaExit();

}
}
