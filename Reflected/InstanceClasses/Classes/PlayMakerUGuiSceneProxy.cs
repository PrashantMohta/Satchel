namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiSceneProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiSceneProxyR:InstanceClassWrapper<PlayMakerUGuiSceneProxy>
{
public PlayMakerUGuiSceneProxyR(PlayMakerUGuiSceneProxy _orig) : base(_orig) {}
public PlayMakerFSM fsm
{
get => PlayMakerUGuiSceneProxy.fsm;
set => PlayMakerUGuiSceneProxy.fsm = value;
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
