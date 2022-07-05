namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BuildEquippedCharms allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BuildEquippedCharmsR : InstanceClassWrapper<BuildEquippedCharms>
{
    public BuildEquippedCharmsR(BuildEquippedCharms _orig) : base(_orig)
    {
    }

    public Color notchFullColor
    {
        get => orig.notchFullColor;
        set => orig.notchFullColor = value;
    }

    public Color notchOverColor
    {
        get => orig.notchOverColor;
        set => orig.notchOverColor = value;
    }

    public List<int> equippedCharms
    {
        get => orig.equippedCharms;
        set => orig.equippedCharms = value;
    }

    public List<GameObject> gameObjectList
    {
        get => orig.gameObjectList;
        set => orig.gameObjectList = value;
    }

    public List<GameObject> instanceList
    {
        get => orig.instanceList;
        set => orig.instanceList = value;
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public GameObject textNotches
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject nextDot
    {
        get => orig.nextDot;
        set => orig.nextDot = value;
    }

    public GameObject charmsFolder
    {
        get => orig.charmsFolder;
        set => orig.charmsFolder = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public int charmSlots
    {
        get => orig.charmSlots;
        set => orig.charmSlots = value;
    }

    public int charmSlotsFilled
    {
        get => orig.charmSlotsFilled;
        set => orig.charmSlotsFilled = value;
    }

    public int equippedAmount
    {
        get => orig.equippedAmount;
        set => orig.equippedAmount = value;
    }

    public int uiItems
    {
        get => orig.uiItems;
        set => orig.uiItems = value;
    }

    public float START_X
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float START_Y
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float CHARM_SCALE
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float CHARM_DISTANCE_X
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void BuildCharmList()
    {
        CallMethod();
    }

    public void UpdateNotches()
    {
        orig.UpdateNotches();
    }

    public GameObject GetObjectAt(int listNumber)
    {
        return orig.GetObjectAt(listNumber);
    }

    public int GetUICount()
    {
        return orig.GetUICount();
    }

    public string GetItemName(int itemNum)
    {
        return orig.GetItemName(itemNum);
    }
}