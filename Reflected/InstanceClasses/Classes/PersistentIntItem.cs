namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PersistentIntItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PersistentIntItemR:InstanceClassWrapper<PersistentIntItem>
{
public PersistentIntItemR(PersistentIntItem _orig) : base(_orig) {}
public bool semiPersistent
{
get => orig.semiPersistent;
set => orig.semiPersistent = value;
}

public PersistentIntData persistentIntData
{
get => orig.persistentIntData;
set => orig.persistentIntData = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public PlayMakerFSM myFSM
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Start () =>
CallMethod();

public void SaveState () =>
CallMethod();

public void ResetState () =>
CallMethod();

public void SetMyID () =>
CallMethod();

public void UpdateValueFromFSM () =>
CallMethod();

public void SetValueOnFSM (int newValue) =>
CallMethod(new object[] {newValue});

public void LookForMyFSM () =>
CallMethod();

}
}
