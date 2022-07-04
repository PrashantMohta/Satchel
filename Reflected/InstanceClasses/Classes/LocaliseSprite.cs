namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LocaliseSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LocaliseSpriteR : InstanceClassWrapper<LocaliseSprite>
{
    public LocaliseSpriteR(LocaliseSprite _orig) : base(_orig)
    {
    }

    public LocaliseSprite.LangSpritePair[] sprites
    {
        get => orig.sprites;
        set => orig.sprites = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }
}