namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerButtonPositions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerButtonPositionsR : InstanceClassWrapper<ControllerButtonPositions>
{
    public ControllerButtonPositionsR(ControllerButtonPositions _orig) : base(_orig)
    {
    }

    public ControllerButtonLabel action1
    {
        get => orig.action1;
        set => orig.action1 = value;
    }

    public ControllerButtonLabel action2
    {
        get => orig.action2;
        set => orig.action2 = value;
    }

    public ControllerButtonLabel action3
    {
        get => orig.action3;
        set => orig.action3 = value;
    }

    public ControllerButtonLabel action4
    {
        get => orig.action4;
        set => orig.action4 = value;
    }

    public ControllerButtonLabel dPad
    {
        get => orig.dPad;
        set => orig.dPad = value;
    }

    public ControllerButtonLabel leftBumper
    {
        get => orig.leftBumper;
        set => orig.leftBumper = value;
    }

    public ControllerButtonLabel leftStick
    {
        get => orig.leftStick;
        set => orig.leftStick = value;
    }

    public ControllerButtonLabel leftTrigger
    {
        get => orig.leftTrigger;
        set => orig.leftTrigger = value;
    }

    public ControllerButtonLabel rightBumper
    {
        get => orig.rightBumper;
        set => orig.rightBumper = value;
    }

    public ControllerButtonLabel rightStick
    {
        get => orig.rightStick;
        set => orig.rightStick = value;
    }

    public ControllerButtonLabel rightTrigger
    {
        get => orig.rightTrigger;
        set => orig.rightTrigger = value;
    }

    public ControllerButtonLabel select
    {
        get => orig.select;
        set => orig.select = value;
    }

    public ControllerButtonLabel start
    {
        get => orig.start;
        set => orig.start = value;
    }
}