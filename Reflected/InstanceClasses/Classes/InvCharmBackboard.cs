namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvCharmBackboard allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvCharmBackboardR : InstanceClassWrapper<InvCharmBackboard>
{
    public InvCharmBackboardR(InvCharmBackboard _orig) : base(_orig)
    {
    }

    public GameObject charmObject
    {
        get => orig.charmObject;
        set => orig.charmObject = value;
    }

    public GameObject newOrb
    {
        get => orig.newOrb;
        set => orig.newOrb = value;
    }

    public int charmNum
    {
        get => orig.charmNum;
        set => orig.charmNum = value;
    }

    public string charmNumString
    {
        get => orig.charmNumString;
        set => orig.charmNumString = value;
    }

    public string gotCharmString
    {
        get => orig.gotCharmString;
        set => orig.gotCharmString = value;
    }

    public string newCharmString
    {
        get => orig.newCharmString;
        set => orig.newCharmString = value;
    }

    public Sprite blankSprite
    {
        get => orig.blankSprite;
        set => orig.blankSprite = value;
    }

    public Sprite activeSprite
    {
        get => orig.activeSprite;
        set => orig.activeSprite = value;
    }

    public bool positionedCharm
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public GameObject orb
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public bool blanked
    {
        get => GetField<bool>();
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

    public void SelectCharm()
    {
        orig.SelectCharm();
    }

    public int GetCharmNum()
    {
        return orig.GetCharmNum();
    }

    public string GetCharmString()
    {
        return orig.GetCharmString();
    }

    public string GetCharmNumString()
    {
        return orig.GetCharmNumString();
    }
}