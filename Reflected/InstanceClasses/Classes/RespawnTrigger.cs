namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RespawnTrigger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RespawnTriggerR:InstanceClassWrapper<RespawnTrigger>
{
public RespawnTriggerR(RespawnTrigger _orig) : base(_orig) {}
public RespawnMarker respawnMarker
{
get => orig.respawnMarker;
set => orig.respawnMarker = value;
}

public bool singleUse
{
get => orig.singleUse;
set => orig.singleUse = value;
}

public int respawnType
{
get => orig.respawnType;
set => orig.respawnType = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}

public PlayMakerFSM myFsm
{
get => GetField<PlayMakerFSM>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D otherCollider) =>
CallMethod(new object[] {otherCollider});

}
}
