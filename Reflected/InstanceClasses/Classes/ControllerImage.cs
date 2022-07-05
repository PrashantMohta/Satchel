namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerImage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerImageR : InstanceClassWrapper<ControllerImage>
{
    public ControllerImageR(ControllerImage _orig) : base(_orig)
    {
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public GamepadType gamepadType
    {
        get => orig.gamepadType;
        set => orig.gamepadType = value;
    }

    public Sprite sprite
    {
        get => orig.sprite;
        set => orig.sprite = value;
    }

    public ControllerButtonPositions buttonPositions
    {
        get => orig.buttonPositions;
        set => orig.buttonPositions = value;
    }

    public float displayScale
    {
        get => orig.displayScale;
        set => orig.displayScale = value;
    }

    public float offsetY
    {
        get => orig.offsetY;
        set => orig.offsetY = value;
    }

    public bool canRemap
    {
        get => orig.canRemap;
        set => orig.canRemap = value;
    }
}