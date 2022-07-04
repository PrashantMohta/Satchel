namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GetControllerCollisionFlags allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetControllerCollisionFlagsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.GetControllerCollisionFlags>
{
public GetControllerCollisionFlagsR(HutongGames.PlayMaker.Actions.GetControllerCollisionFlags _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool isGrounded
{
get => orig.isGrounded;
set => orig.isGrounded = value;
}

public HutongGames.PlayMaker.FsmBool none
{
get => orig.none;
set => orig.none = value;
}

public HutongGames.PlayMaker.FsmBool sides
{
get => orig.sides;
set => orig.sides = value;
}

public HutongGames.PlayMaker.FsmBool above
{
get => orig.above;
set => orig.above = value;
}

public HutongGames.PlayMaker.FsmBool below
{
get => orig.below;
set => orig.below = value;
}

public UnityEngine.GameObject previousGo
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.CharacterController controller
{
get => GetField<UnityEngine.CharacterController>();
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
