namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PersistentBoolItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PersistentBoolItemR:InstanceClassWrapper<PersistentBoolItem>
{
public PersistentBoolItemR(PersistentBoolItem _orig) : base(_orig) {}
public bool semiPersistent
{
get => orig.semiPersistent;
set => orig.semiPersistent = value;
}

public PersistentBoolData persistentBoolData
{
get => orig.persistentBoolData;
set => orig.persistentBoolData = value;
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

public bool started
{
get => GetField<bool>();
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
orig.SaveState();

public void ResetState () =>
CallMethod();

public void SetMyID () =>
CallMethod();

public void PreSetup () =>
orig.PreSetup();

public void UpdateActivatedFromFSM () =>
CallMethod();

public void LookForMyFSM () =>
CallMethod();

}
}
