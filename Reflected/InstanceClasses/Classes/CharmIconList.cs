namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CharmIconList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmIconListR : InstanceClassWrapper<CharmIconList>
{
    public CharmIconListR(CharmIconList _orig) : base(_orig)
    {
    }

    public CharmIconList Instance
    {
        get => CharmIconList.Instance;
        set => CharmIconList.Instance = value;
    }

    public Sprite[] spriteList
    {
        get => orig.spriteList;
        set => orig.spriteList = value;
    }

    public Sprite unbreakableHeart
    {
        get => orig.unbreakableHeart;
        set => orig.unbreakableHeart = value;
    }

    public Sprite unbreakableGreed
    {
        get => orig.unbreakableGreed;
        set => orig.unbreakableGreed = value;
    }

    public Sprite unbreakableStrength
    {
        get => orig.unbreakableStrength;
        set => orig.unbreakableStrength = value;
    }

    public Sprite grimmchildLevel1
    {
        get => orig.grimmchildLevel1;
        set => orig.grimmchildLevel1 = value;
    }

    public Sprite grimmchildLevel2
    {
        get => orig.grimmchildLevel2;
        set => orig.grimmchildLevel2 = value;
    }

    public Sprite grimmchildLevel3
    {
        get => orig.grimmchildLevel3;
        set => orig.grimmchildLevel3 = value;
    }

    public Sprite grimmchildLevel4
    {
        get => orig.grimmchildLevel4;
        set => orig.grimmchildLevel4 = value;
    }

    public Sprite nymmCharm
    {
        get => orig.nymmCharm;
        set => orig.nymmCharm = value;
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

    public void Start()
    {
        CallMethod();
    }

    public Sprite GetSprite(int id)
    {
        return orig.GetSprite(id);
    }
}