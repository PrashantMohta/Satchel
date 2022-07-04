namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of JournalEntryStats allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JournalEntryStatsR:InstanceClassWrapper<JournalEntryStats>
{
public JournalEntryStatsR(JournalEntryStats _orig) : base(_orig) {}
public UnityEngine.GameObject frameObject
{
get => orig.frameObject;
set => orig.frameObject = value;
}

public UnityEngine.GameObject newDotObject
{
get => orig.newDotObject;
set => orig.newDotObject = value;
}

public string playerDataName
{
get => orig.playerDataName;
set => orig.playerDataName = value;
}

public string convoName
{
get => orig.convoName;
set => orig.convoName = value;
}

public UnityEngine.Sprite sprite
{
get => orig.sprite;
set => orig.sprite = value;
}

public bool warriorGhost
{
get => orig.warriorGhost;
set => orig.warriorGhost = value;
}

public bool grimmEntry
{
get => orig.grimmEntry;
set => orig.grimmEntry = value;
}

public string nameConvo
{
get => orig.nameConvo;
set => orig.nameConvo = value;
}

public string descConvo
{
get => orig.descConvo;
set => orig.descConvo = value;
}

public string notesConvo
{
get => orig.notesConvo;
set => orig.notesConvo = value;
}

public string playerDataKillsName
{
get => orig.playerDataKillsName;
set => orig.playerDataKillsName = value;
}

public string playerDataBoolName
{
get => orig.playerDataBoolName;
set => orig.playerDataBoolName = value;
}

public string playerDataNewDataName
{
get => orig.playerDataNewDataName;
set => orig.playerDataNewDataName = value;
}

public int itemNumber
{
get => orig.itemNumber;
set => orig.itemNumber = value;
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public float topY
{
get => GetField<float>();
set => SetField(value);
}

public float botY
{
get => GetField<float>();
set => SetField(value);
}

public bool hidden
{
get => GetField<bool>();
set => SetField(value);
}

public float posOriginalY
{
get => GetField<float>();
set => SetField(value);
}

public float posUpY
{
get => GetField<float>();
set => SetField(value);
}

public float posDownY
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 scaleNormal
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 scaleSmall
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public float centreTopY
{
get => GetField<float>();
set => SetField(value);
}

public float centreBotY
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.GameObject portrait
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject nameObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject frame
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject newDot
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool frameVisible
{
get => GetField<bool>();
set => SetField(value);
}

public bool dotVisible
{
get => GetField<bool>();
set => SetField(value);
}

public bool shrinkingDot
{
get => GetField<bool>();
set => SetField(value);
}

public float dotScale
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform dotTransform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Update () =>
CallMethod();

public string GetNameConvo () =>
orig.GetNameConvo();

public string GetDescConvo () =>
orig.GetDescConvo();

public string GetNotesConvo () =>
orig.GetNotesConvo();

public string GetPlayerDataBoolName () =>
orig.GetPlayerDataBoolName();

public string GetPlayerDataKillsName () =>
orig.GetPlayerDataKillsName();

public string GetPlayerDataNewDataName () =>
orig.GetPlayerDataNewDataName();

public int GetItemNumber () =>
orig.GetItemNumber();

public UnityEngine.Sprite GetSprite () =>
orig.GetSprite();

public bool GetWarriorGhost () =>
orig.GetWarriorGhost();

public bool GetGrimm () =>
orig.GetGrimm();

}
}
