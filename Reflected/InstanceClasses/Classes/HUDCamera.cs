namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HUDCamera allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HUDCameraR:InstanceClassWrapper<HUDCamera>
{
public HUDCameraR(HUDCamera _orig) : base(_orig) {}
public GameCameras gc
{
get => GetField<GameCameras>();
set => SetField(value);
}

public InputHandler ih
{
get => GetField<InputHandler>();
set => SetField(value);
}

public bool shouldEnablePause
{
get => GetField<bool>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void MoveMenuToHUDCamera () =>
CallMethod();

}
}
