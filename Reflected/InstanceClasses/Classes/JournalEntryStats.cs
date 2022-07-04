namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of JournalEntryStats allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class JournalEntryStatsR : InstanceClassWrapper<JournalEntryStats>
{
    public JournalEntryStatsR(JournalEntryStats _orig) : base(_orig)
    {
    }

    public GameObject frameObject
    {
        get => orig.frameObject;
        set => orig.frameObject = value;
    }

    public GameObject newDotObject
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

    public Sprite sprite
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

    public Vector3 scaleNormal
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 scaleSmall
    {
        get => GetField<Vector3>();
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

    public GameObject portrait
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject nameObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject frame
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject newDot
    {
        get => GetField<GameObject>();
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

    public Transform dotTransform
    {
        get => GetField<Transform>();
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

    public void OnDisable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public string GetNameConvo()
    {
        return orig.GetNameConvo();
    }

    public string GetDescConvo()
    {
        return orig.GetDescConvo();
    }

    public string GetNotesConvo()
    {
        return orig.GetNotesConvo();
    }

    public string GetPlayerDataBoolName()
    {
        return orig.GetPlayerDataBoolName();
    }

    public string GetPlayerDataKillsName()
    {
        return orig.GetPlayerDataKillsName();
    }

    public string GetPlayerDataNewDataName()
    {
        return orig.GetPlayerDataNewDataName();
    }

    public int GetItemNumber()
    {
        return orig.GetItemNumber();
    }

    public Sprite GetSprite()
    {
        return orig.GetSprite();
    }

    public bool GetWarriorGhost()
    {
        return orig.GetWarriorGhost();
    }

    public bool GetGrimm()
    {
        return orig.GetGrimm();
    }
}