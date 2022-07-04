namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAnimation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAnimationR : InstanceClassWrapper<tk2dSpriteAnimation>
{
    public tk2dSpriteAnimationR(tk2dSpriteAnimation _orig) : base(_orig)
    {
    }

    public tk2dSpriteAnimationClip[] clips
    {
        get => orig.clips;
        set => orig.clips = value;
    }

    public tk2dSpriteAnimationClip FirstValidClip => orig.FirstValidClip;


    public tk2dSpriteAnimationClip GetClipByName(string name)
    {
        return orig.GetClipByName(name);
    }

    public tk2dSpriteAnimationClip GetClipById(int id)
    {
        return orig.GetClipById(id);
    }

    public int GetClipIdByName(string name)
    {
        return orig.GetClipIdByName(name);
    }

    public int GetClipIdByName(tk2dSpriteAnimationClip clip)
    {
        return orig.GetClipIdByName(clip);
    }
}