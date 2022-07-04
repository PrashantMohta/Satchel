namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SwipeGestureEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SwipeGestureEventR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SwipeGestureEvent>
{
public SwipeGestureEventR(HutongGames.PlayMaker.Actions.SwipeGestureEvent _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmFloat minSwipeDistance
{
get => orig.minSwipeDistance;
set => orig.minSwipeDistance = value;
}

public HutongGames.PlayMaker.FsmEvent swipeLeftEvent
{
get => orig.swipeLeftEvent;
set => orig.swipeLeftEvent = value;
}

public HutongGames.PlayMaker.FsmEvent swipeRightEvent
{
get => orig.swipeRightEvent;
set => orig.swipeRightEvent = value;
}

public HutongGames.PlayMaker.FsmEvent swipeUpEvent
{
get => orig.swipeUpEvent;
set => orig.swipeUpEvent = value;
}

public HutongGames.PlayMaker.FsmEvent swipeDownEvent
{
get => orig.swipeDownEvent;
set => orig.swipeDownEvent = value;
}

public float screenDiagonalSize
{
get => GetField<float>();
set => SetField(value);
}

public float minSwipeDistancePixels
{
get => GetField<float>();
set => SetField(value);
}

public bool touchStarted
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 touchStartPos
{
get => GetField<UnityEngine.Vector2>();
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

public void TestForSwipeGesture (UnityEngine.Touch touch) =>
CallMethod(new object[] {touch});

}
}
