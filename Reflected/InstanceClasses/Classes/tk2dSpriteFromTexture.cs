namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteFromTexture allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteFromTextureR : InstanceClassWrapper<tk2dSpriteFromTexture>
{
    public tk2dSpriteFromTextureR(tk2dSpriteFromTexture _orig) : base(_orig)
    {
    }

    public Texture texture
    {
        get => orig.texture;
        set => orig.texture = value;
    }

    public tk2dSpriteCollectionSize spriteCollectionSize
    {
        get => orig.spriteCollectionSize;
        set => orig.spriteCollectionSize = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => GetField<tk2dSpriteCollectionData>();
        set => SetField(value);
    }

    public tk2dBaseSprite _sprite
    {
        get => GetField<tk2dBaseSprite>();
        set => SetField(value);
    }

    public tk2dBaseSprite Sprite => GetProperty<tk2dBaseSprite>();

    public bool HasSpriteCollection => orig.HasSpriteCollection;


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void Create(tk2dSpriteCollectionSize spriteCollectionSize, Texture texture, tk2dBaseSprite.Anchor anchor)
    {
        orig.Create(spriteCollectionSize, texture, anchor);
    }

    public void Clear()
    {
        orig.Clear();
    }

    public void ForceBuild()
    {
        orig.ForceBuild();
    }

    public void DestroyInternal()
    {
        CallMethod();
    }
}