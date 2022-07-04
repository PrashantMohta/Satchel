namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GamePad allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GamePadR:InstanceClassWrapper<XInputDotNetPure.GamePad>
{
public GamePadR(XInputDotNetPure.GamePad _orig) : base(_orig) {}
public XInputDotNetPure.GamePadState GetState (XInputDotNetPure.PlayerIndex playerIndex) =>
XInputDotNetPure.GamePad.GetState(playerIndex);

public void SetVibration (XInputDotNetPure.PlayerIndex playerIndex, float leftMotor, float rightMotor) =>
XInputDotNetPure.GamePad.SetVibration(playerIndex, leftMotor, rightMotor);

}
}
