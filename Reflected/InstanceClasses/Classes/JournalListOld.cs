namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of JournalListOld allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JournalListOldR:InstanceClassWrapper<JournalListOld>
{
public JournalListOldR(JournalListOld _orig) : base(_orig) {}
public UnityEngine.GameObject[] list
{
get => orig.list;
set => orig.list = value;
}

public UnityEngine.GameObject[] listInv
{
get => orig.listInv;
set => orig.listInv = value;
}

public PlayerData pd
{
get => orig.pd;
set => orig.pd = value;
}

public float yDistance
{
get => orig.yDistance;
set => orig.yDistance = value;
}

public UnityEngine.Vector3 selfPos
{
get => GetField<UnityEngine.Vector3>();
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



public void Start () =>
CallMethod();

public void BuildItemList () =>
CallMethod();

public int GetItemCount () =>
orig.GetItemCount();

public string GetNameConvo (int itemNum) =>
orig.GetNameConvo(itemNum);

public string GetDescConvo (int itemNum) =>
orig.GetDescConvo(itemNum);

public bool GetWarriorGhost (int itemNum) =>
orig.GetWarriorGhost(itemNum);

public string GetNotesConvo (int itemNum) =>
orig.GetNotesConvo(itemNum);

public string GetPlayerDataBoolName (int itemNum) =>
orig.GetPlayerDataBoolName(itemNum);

public string GetPlayerDataKillsName (int itemNum) =>
orig.GetPlayerDataKillsName(itemNum);

public string GetPlayerDataNewDataName (int itemNum) =>
orig.GetPlayerDataNewDataName(itemNum);

public UnityEngine.Sprite GetSprite (int itemNum) =>
orig.GetSprite(itemNum);

public float GetYDistance () =>
orig.GetYDistance();

public int GetFirstNewItem () =>
orig.GetFirstNewItem();

}
}
