namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetInControlDeviceInputAxisVector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetInControlDeviceInputAxisVectorR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetInControlDeviceInputAxisVector>
{
public GetInControlDeviceInputAxisVectorR(HutongGames.PlayMaker.Actions.GetInControlDeviceInputAxisVector _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmInt deviceIndex
{
get => orig.deviceIndex;
set => orig.deviceIndex = value;
}

public InControl.InputControlType horizontalAxis
{
get => orig.horizontalAxis;
set => orig.horizontalAxis = value;
}

public InControl.InputControlType verticalAxis
{
get => orig.verticalAxis;
set => orig.verticalAxis = value;
}

public HutongGames.PlayMaker.FsmFloat multiplier
{
get => orig.multiplier;
set => orig.multiplier = value;
}

public HutongGames.PlayMaker.FsmGameObject relativeTo
{
get => orig.relativeTo;
set => orig.relativeTo = value;
}

public HutongGames.PlayMaker.FsmVector3 storeVector
{
get => orig.storeVector;
set => orig.storeVector = value;
}

public HutongGames.PlayMaker.FsmFloat storeMagnitude
{
get => orig.storeMagnitude;
set => orig.storeMagnitude = value;
}

public InControl.InputDevice _inputDevice
{
get => GetField<InControl.InputDevice>();
set => SetField(value);
}

public InControl.InputControl _inputControl
{
get => GetField<InControl.InputControl>();
set => SetField(value);
}

public string Name
{
get => orig.Name;
set => orig.Name = value;
}

public string DisplayName
{
get => orig.DisplayName;
set => orig.DisplayName = value;
}

public HutongGames.PlayMaker.Fsm Fsm
{
get => orig.Fsm;
set => orig.Fsm = value;
}

public UnityEngine.GameObject Owner
{
get => orig.Owner;
set => orig.Owner = value;
}

public HutongGames.PlayMaker.FsmState State
{
get => orig.State;
set => orig.State = value;
}

public bool Enabled
{
get => orig.Enabled;
set => orig.Enabled = value;
}

public bool IsOpen
{
get => orig.IsOpen;
set => orig.IsOpen = value;
}

public bool IsAutoNamed
{
get => orig.IsAutoNamed;
set => orig.IsAutoNamed = value;
}

public bool Entered
{
get => orig.Entered;
set => orig.Entered = value;
}

public bool Finished
{
get => orig.Finished;
set => orig.Finished = value;
}

public bool Active
{
get => orig.Active;
set => orig.Active = value;
}

public void Reset () =>
orig.Reset();

public void OnUpdate () =>
orig.OnUpdate();

}
}
