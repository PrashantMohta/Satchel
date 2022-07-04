namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DisplayOnWorldMapOnly allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DisplayOnWorldMapOnlyR:InstanceClassWrapper<DisplayOnWorldMapOnly>
{
public DisplayOnWorldMapOnlyR(DisplayOnWorldMapOnly _orig) : base(_orig) {}
public GameMap gameMap
{
get => orig.gameMap;
set => orig.gameMap = value;
}

public UnityEngine.MeshRenderer meshRenderer
{
get => GetField<UnityEngine.MeshRenderer>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

}
}
