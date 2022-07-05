namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAnimationClip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAnimationClipR : InstanceClassWrapper<tk2dSpriteAnimationClip>
{
    public tk2dSpriteAnimationClipR(tk2dSpriteAnimationClip _orig) : base(_orig)
    {
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public tk2dSpriteAnimationFrame[] frames
    {
        get => orig.frames;
        set => orig.frames = value;
    }

    public float fps
    {
        get => orig.fps;
        set => orig.fps = value;
    }

    public int loopStart
    {
        get => orig.loopStart;
        set => orig.loopStart = value;
    }

    public float Duration => orig.Duration;

    public bool Empty => orig.Empty;

    public void CopyFrom(tk2dSpriteAnimationClip source)
    {
        orig.CopyFrom(source);
    }

    public void Clear()
    {
        orig.Clear();
    }

    public tk2dSpriteAnimationFrame GetFrame(int frame)
    {
        return orig.GetFrame(frame);
    }
}