namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PositionShadeMarkerPerDoor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PositionShadeMarkerPerDoorR : InstanceClassWrapper<PositionShadeMarkerPerDoor>
{
    public PositionShadeMarkerPerDoorR(PositionShadeMarkerPerDoor _orig) : base(_orig)
    {
    }

    public GameObject shadeMarker
    {
        get => orig.shadeMarker;
        set => orig.shadeMarker = value;
    }

    public PositionShadeMarkerPerDoor.DoorShadePosition[] shadePositions
    {
        get => orig.shadePositions;
        set => orig.shadePositions = value;
    }


    public void Start()
    {
        orig.Start();
    }
}