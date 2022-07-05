namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayFromRandomFrame allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayFromRandomFrameR : InstanceClassWrapper<PlayFromRandomFrame>
{
    public PlayFromRandomFrameR(PlayFromRandomFrame _orig) : base(_orig)
    {
    }

    public int frameCount
    {
        get => orig.frameCount;
        set => orig.frameCount = value;
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }
}