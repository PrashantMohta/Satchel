namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvNailSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvNailSpriteR : InstanceClassWrapper<InvNailSprite>
{
    public InvNailSpriteR(InvNailSprite _orig) : base(_orig)
    {
    }

    public Sprite level1
    {
        get => orig.level1;
        set => orig.level1 = value;
    }

    public Sprite level2
    {
        get => orig.level2;
        set => orig.level2 = value;
    }

    public Sprite level3
    {
        get => orig.level3;
        set => orig.level3 = value;
    }

    public Sprite level4
    {
        get => orig.level4;
        set => orig.level4 = value;
    }

    public Sprite level5
    {
        get => orig.level5;
        set => orig.level5 = value;
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
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