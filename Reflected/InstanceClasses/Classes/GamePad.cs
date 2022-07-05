using XInputDotNetPure;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GamePad allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GamePadR : InstanceClassWrapper<GamePad>
{
    public GamePadR(GamePad _orig) : base(_orig)
    {
    }

    public GamePadState GetState(PlayerIndex playerIndex)
    {
        return GamePad.GetState(playerIndex);
    }

    public void SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
    {
        GamePad.SetVibration(playerIndex, leftMotor, rightMotor);
    }
}