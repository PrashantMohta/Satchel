namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InvMarkerCollide allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvMarkerCollideR:InstanceClassWrapper<InvMarkerCollide>
{
public InvMarkerCollideR(InvMarkerCollide _orig) : base(_orig) {}
public MapMarkerMenu markerMenu
{
get => orig.markerMenu;
set => orig.markerMenu = value;
}



public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

}
}
