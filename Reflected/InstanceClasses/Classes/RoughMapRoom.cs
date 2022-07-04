namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RoughMapRoom allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RoughMapRoomR : InstanceClassWrapper<RoughMapRoom>
{
    public RoughMapRoomR(RoughMapRoom _orig) : base(_orig)
    {
    }

    public Sprite fullSprite
    {
        get => orig.fullSprite;
        set => orig.fullSprite = value;
    }

    public PlayerData pd
    {
        get => orig.pd;
        set => orig.pd = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public SpriteRenderer sr
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public bool fullSpriteDisplayed
    {
        get => orig.fullSpriteDisplayed;
        set => orig.fullSpriteDisplayed = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }
}