namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HazardRespawnTrigger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HazardRespawnTriggerR:InstanceClassWrapper<HazardRespawnTrigger>
{
public HazardRespawnTriggerR(HazardRespawnTrigger _orig) : base(_orig) {}
public HazardRespawnMarker respawnMarker
{
get => orig.respawnMarker;
set => orig.respawnMarker = value;
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}

public bool fireOnce
{
get => orig.fireOnce;
set => orig.fireOnce = value;
}

public bool inactive
{
get => GetField<bool>();
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
