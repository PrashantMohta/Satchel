namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MapMarkerButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MapMarkerButtonR:InstanceClassWrapper<MapMarkerButton>
{
public MapMarkerButtonR(MapMarkerButton _orig) : base(_orig) {}
public int neededMarkerTypes
{
get => orig.neededMarkerTypes;
set => orig.neededMarkerTypes = value;
}

public bool keepDisabled
{
get => orig.keepDisabled;
set => orig.keepDisabled = value;
}

public bool shouldDisable
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer spriteRenderer
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void DoDisable () =>
CallMethod();

}
}
