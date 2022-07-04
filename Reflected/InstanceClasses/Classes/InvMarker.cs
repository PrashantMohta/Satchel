namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InvMarker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvMarkerR:InstanceClassWrapper<InvMarker>
{
public InvMarkerR(InvMarker _orig) : base(_orig) {}
public MapMarkerMenu markerMenu
{
get => orig.markerMenu;
set => orig.markerMenu = value;
}

public int colour
{
get => orig.colour;
set => orig.colour = value;
}

public int id
{
get => orig.id;
set => orig.id = value;
}



public void OnDisable () =>
CallMethod();

}
}
