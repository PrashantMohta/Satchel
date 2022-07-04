namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HazardRespawnMarker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HazardRespawnMarkerR:InstanceClassWrapper<HazardRespawnMarker>
{
public HazardRespawnMarkerR(HazardRespawnMarker _orig) : base(_orig) {}
public bool respawnFacingRight
{
get => orig.respawnFacingRight;
set => orig.respawnFacingRight = value;
}

public float groundSenseDistance
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 groundSenseRay
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 heroSpawnLocation
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool drawDebugRays
{
get => orig.drawDebugRays;
set => orig.drawDebugRays = value;
}



public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
