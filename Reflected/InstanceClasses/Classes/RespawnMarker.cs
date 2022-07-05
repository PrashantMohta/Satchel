namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RespawnMarker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RespawnMarkerR : InstanceClassWrapper<RespawnMarker>
{
    public RespawnMarkerR(RespawnMarker _orig) : base(_orig)
    {
    }

    public bool respawnFacingRight
    {
        get => orig.respawnFacingRight;
        set => orig.respawnFacingRight = value;
    }
}