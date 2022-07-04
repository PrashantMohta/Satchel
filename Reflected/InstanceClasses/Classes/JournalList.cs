namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of JournalList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JournalListR : InstanceClassWrapper<JournalList>
{
    public JournalListR(JournalList _orig) : base(_orig)
    {
    }

    public GameObject[] list
    {
        get => orig.list;
        set => orig.list = value;
    }

    public GameObject[] listInv
    {
        get => orig.listInv;
        set => orig.listInv = value;
    }

    public GameObject[] currentList
    {
        get => GetField<GameObject[]>();
        set => SetField(value);
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public float yDistance
    {
        get => orig.yDistance;
        set => orig.yDistance = value;
    }

    public Vector3 selfPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public int itemCount
    {
        get => orig.itemCount;
        set => orig.itemCount = value;
    }

    public int firstNewItem
    {
        get => orig.firstNewItem;
        set => orig.firstNewItem = value;
    }


    public void BuildEnemyList()
    {
        orig.BuildEnemyList();
    }

    public void UpdateEnemyList()
    {
        orig.UpdateEnemyList();
    }

    public int GetItemCount()
    {
        return orig.GetItemCount();
    }

    public string GetNameConvo(int itemNum)
    {
        return orig.GetNameConvo(itemNum);
    }

    public string GetDescConvo(int itemNum)
    {
        return orig.GetDescConvo(itemNum);
    }

    public bool GetWarriorGhost(int itemNum)
    {
        return orig.GetWarriorGhost(itemNum);
    }

    public bool GetGrimm(int itemNum)
    {
        return orig.GetGrimm(itemNum);
    }

    public string GetNotesConvo(int itemNum)
    {
        return orig.GetNotesConvo(itemNum);
    }

    public string GetPlayerDataBoolName(int itemNum)
    {
        return orig.GetPlayerDataBoolName(itemNum);
    }

    public string GetPlayerDataKillsName(int itemNum)
    {
        return orig.GetPlayerDataKillsName(itemNum);
    }

    public string GetPlayerDataNewDataName(int itemNum)
    {
        return orig.GetPlayerDataNewDataName(itemNum);
    }

    public Sprite GetSprite(int itemNum)
    {
        return orig.GetSprite(itemNum);
    }

    public float GetYDistance()
    {
        return orig.GetYDistance();
    }

    public int GetFirstNewItem()
    {
        return orig.GetFirstNewItem();
    }
}