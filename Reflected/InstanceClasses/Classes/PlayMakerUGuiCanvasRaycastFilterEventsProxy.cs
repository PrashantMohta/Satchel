namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiCanvasRaycastFilterEventsProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiCanvasRaycastFilterEventsProxyR:InstanceClassWrapper<PlayMakerUGuiCanvasRaycastFilterEventsProxy>
{
public PlayMakerUGuiCanvasRaycastFilterEventsProxyR(PlayMakerUGuiCanvasRaycastFilterEventsProxy _orig) : base(_orig) {}
public bool RayCastingEnabled
{
get => orig.RayCastingEnabled;
set => orig.RayCastingEnabled = value;
}



public bool IsRaycastLocationValid (UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) =>
orig.IsRaycastLocationValid(sp, eventCamera);

}
}
