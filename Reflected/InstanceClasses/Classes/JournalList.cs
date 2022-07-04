namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of JournalList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JournalListR:InstanceClassWrapper<JournalList>
{
public JournalListR(JournalList _orig) : base(_orig) {}
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

public UnityEngine.GameObject[] currentList
{
get => GetField<UnityEngine.GameObject[]>();
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



public void BuildEnemyList () =>
orig.BuildEnemyList();

public void UpdateEnemyList () =>
orig.UpdateEnemyList();

public int GetItemCount () =>
orig.GetItemCount();

public string GetNameConvo (int itemNum) =>
orig.GetNameConvo(itemNum);

public string GetDescConvo (int itemNum) =>
orig.GetDescConvo(itemNum);

public bool GetWarriorGhost (int itemNum) =>
orig.GetWarriorGhost(itemNum);

public bool GetGrimm (int itemNum) =>
orig.GetGrimm(itemNum);

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
