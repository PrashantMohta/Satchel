namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetLocationInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetLocationInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetLocationInfo>
{
public GetLocationInfoR(HutongGames.PlayMaker.Actions.GetLocationInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 vectorPosition
{
get => orig.vectorPosition;
set => orig.vectorPosition = value;
}

public HutongGames.PlayMaker.FsmFloat longitude
{
get => orig.longitude;
set => orig.longitude = value;
}

public HutongGames.PlayMaker.FsmFloat latitude
{
get => orig.latitude;
set => orig.latitude = value;
}

public HutongGames.PlayMaker.FsmFloat altitude
{
get => orig.altitude;
set => orig.altitude = value;
}

public HutongGames.PlayMaker.FsmFloat horizontalAccuracy
{
get => orig.horizontalAccuracy;
set => orig.horizontalAccuracy = value;
}

public HutongGames.PlayMaker.FsmFloat verticalAccuracy
{
get => orig.verticalAccuracy;
set => orig.verticalAccuracy = value;
}

public HutongGames.PlayMaker.FsmEvent errorEvent
{
get => orig.errorEvent;
set => orig.errorEvent = value;
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

public void OnEnter () =>
orig.OnEnter();

public void DoGetLocationInfo () =>
CallMethod();

}
}
