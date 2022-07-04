namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAnimationFrame allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAnimationFrameR : InstanceClassWrapper<tk2dSpriteAnimationFrame>
{
    public tk2dSpriteAnimationFrameR(tk2dSpriteAnimationFrame _orig) : base(_orig)
    {
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }

    public int spriteId
    {
        get => orig.spriteId;
        set => orig.spriteId = value;
    }

    public bool triggerEvent
    {
        get => orig.triggerEvent;
        set => orig.triggerEvent = value;
    }

    public string eventInfo
    {
        get => orig.eventInfo;
        set => orig.eventInfo = value;
    }

    public int eventInt
    {
        get => orig.eventInt;
        set => orig.eventInt = value;
    }

    public float eventFloat
    {
        get => orig.eventFloat;
        set => orig.eventFloat = value;
    }

    public void CopyFrom(tk2dSpriteAnimationFrame source)
    {
        orig.CopyFrom(source);
    }

    public void CopyTriggerFrom(tk2dSpriteAnimationFrame source)
    {
        orig.CopyTriggerFrom(source);
    }

    public void ClearTrigger()
    {
        orig.ClearTrigger();
    }

    public void CopyFrom(tk2dSpriteAnimationFrame source, bool full)
    {
        orig.CopyFrom(source, full);
    }
}