namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dLinkedSpriteCollection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dLinkedSpriteCollectionR : InstanceClassWrapper<tk2dLinkedSpriteCollection>
{
    public tk2dLinkedSpriteCollectionR(tk2dLinkedSpriteCollection _orig) : base(_orig)
    {
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public tk2dSpriteCollection spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }
}