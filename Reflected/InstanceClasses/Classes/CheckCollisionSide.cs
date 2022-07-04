namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CheckCollisionSide allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckCollisionSideR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CheckCollisionSide>
{
public CheckCollisionSideR(HutongGames.PlayMaker.Actions.CheckCollisionSide _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmBool topHit
{
get => orig.topHit;
set => orig.topHit = value;
}

public HutongGames.PlayMaker.FsmBool rightHit
{
get => orig.rightHit;
set => orig.rightHit = value;
}

public HutongGames.PlayMaker.FsmBool bottomHit
{
get => orig.bottomHit;
set => orig.bottomHit = value;
}

public HutongGames.PlayMaker.FsmBool leftHit
{
get => orig.leftHit;
set => orig.leftHit = value;
}

public HutongGames.PlayMaker.FsmEvent topHitEvent
{
get => orig.topHitEvent;
set => orig.topHitEvent = value;
}

public HutongGames.PlayMaker.FsmEvent rightHitEvent
{
get => orig.rightHitEvent;
set => orig.rightHitEvent = value;
}

public HutongGames.PlayMaker.FsmEvent bottomHitEvent
{
get => orig.bottomHitEvent;
set => orig.bottomHitEvent = value;
}

public HutongGames.PlayMaker.FsmEvent leftHitEvent
{
get => orig.leftHitEvent;
set => orig.leftHitEvent = value;
}

public bool otherLayer
{
get => orig.otherLayer;
set => orig.otherLayer = value;
}

public int otherLayerNumber
{
get => orig.otherLayerNumber;
set => orig.otherLayerNumber = value;
}

public HutongGames.PlayMaker.FsmBool ignoreTriggers
{
get => orig.ignoreTriggers;
set => orig.ignoreTriggers = value;
}

public PlayMakerUnity2DProxy _proxy
{
get => GetField<PlayMakerUnity2DProxy>();
set => SetField(value);
}

public UnityEngine.Collider2D col2d
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public float RAYCAST_LENGTH
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> topRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> rightRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> bottomRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> leftRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public bool checkUp
{
get => GetField<bool>();
set => SetField(value);
}

public bool checkDown
{
get => GetField<bool>();
set => SetField(value);
}

public bool checkLeft
{
get => GetField<bool>();
set => SetField(value);
}

public bool checkRight
{
get => GetField<bool>();
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

public void OnExit () =>
orig.OnExit();

public void OnUpdate () =>
orig.OnUpdate();

public void DoCollisionStay2D (UnityEngine.Collision2D collision) =>
orig.DoCollisionStay2D(collision);

public void DoCollisionExit2D (UnityEngine.Collision2D collision) =>
orig.DoCollisionExit2D(collision);

public void CheckTouching (UnityEngine.LayerMask layer) =>
CallMethod(new object[] {layer});

}
}
