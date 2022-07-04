namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MaskByYPos allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MaskByYPosR : InstanceClassWrapper<MaskByYPos>
{
    public MaskByYPosR(MaskByYPos _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
    {
        get => orig.spriteRenderer;
        set => orig.spriteRenderer = value;
    }

    public float yPos
    {
        get => orig.yPos;
        set => orig.yPos = value;
    }

    public bool maskIfAboveY
    {
        get => orig.maskIfAboveY;
        set => orig.maskIfAboveY = value;
    }

    public bool maskIfBelowY
    {
        get => orig.maskIfBelowY;
        set => orig.maskIfBelowY = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}