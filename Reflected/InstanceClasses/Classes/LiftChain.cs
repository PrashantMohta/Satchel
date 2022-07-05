namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LiftChain allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LiftChainR : InstanceClassWrapper<LiftChain>
{
    public LiftChainR(LiftChain _orig) : base(_orig)
    {
    }

    public tk2dSpriteAnimator[] spriteAnimators
    {
        get => GetField<tk2dSpriteAnimator[]>();
        set => SetField(value);
    }

    public int currentDirection
    {
        get => GetField<int>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void GoDown()
    {
        orig.GoDown();
    }

    public void GoUp()
    {
        orig.GoUp();
    }

    public void Stop()
    {
        orig.Stop();
    }
}