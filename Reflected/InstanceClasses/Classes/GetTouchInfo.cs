namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetTouchInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetTouchInfoR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetTouchInfo>
{
public GetTouchInfoR(HutongGames.PlayMaker.Actions.GetTouchInfo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmInt fingerId
{
get => orig.fingerId;
set => orig.fingerId = value;
}

public HutongGames.PlayMaker.FsmBool normalize
{
get => orig.normalize;
set => orig.normalize = value;
}

public HutongGames.PlayMaker.FsmVector3 storePosition
{
get => orig.storePosition;
set => orig.storePosition = value;
}

public HutongGames.PlayMaker.FsmFloat storeX
{
get => orig.storeX;
set => orig.storeX = value;
}

public HutongGames.PlayMaker.FsmFloat storeY
{
get => orig.storeY;
set => orig.storeY = value;
}

public HutongGames.PlayMaker.FsmVector3 storeDeltaPosition
{
get => orig.storeDeltaPosition;
set => orig.storeDeltaPosition = value;
}

public HutongGames.PlayMaker.FsmFloat storeDeltaX
{
get => orig.storeDeltaX;
set => orig.storeDeltaX = value;
}

public HutongGames.PlayMaker.FsmFloat storeDeltaY
{
get => orig.storeDeltaY;
set => orig.storeDeltaY = value;
}

public HutongGames.PlayMaker.FsmFloat storeDeltaTime
{
get => orig.storeDeltaTime;
set => orig.storeDeltaTime = value;
}

public HutongGames.PlayMaker.FsmInt storeTapCount
{
get => orig.storeTapCount;
set => orig.storeTapCount = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public float screenWidth
{
get => GetField<float>();
set => SetField(value);
}

public float screenHeight
{
get => GetField<float>();
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

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void DoGetTouchInfo () =>
CallMethod();

}
}
