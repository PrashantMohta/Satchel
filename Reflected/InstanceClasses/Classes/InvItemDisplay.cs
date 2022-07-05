namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvItemDisplay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvItemDisplayR : InstanceClassWrapper<InvItemDisplay>
{
    public InvItemDisplayR(InvItemDisplay _orig) : base(_orig)
    {
    }

    public string playerDataBool
    {
        get => orig.playerDataBool;
        set => orig.playerDataBool = value;
    }

    public Sprite activeSprite
    {
        get => orig.activeSprite;
        set => orig.activeSprite = value;
    }

    public Sprite inactiveSprite
    {
        get => orig.inactiveSprite;
        set => orig.inactiveSprite = value;
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
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

    public void OnEnable()
    {
        CallMethod();
    }
}