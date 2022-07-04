namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of WalkLeftRight allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WalkLeftRightR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.WalkLeftRight>
{
public WalkLeftRightR(HutongGames.PlayMaker.Actions.WalkLeftRight _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public float walkSpeed
{
get => orig.walkSpeed;
set => orig.walkSpeed = value;
}

public bool spriteFacesLeft
{
get => orig.spriteFacesLeft;
set => orig.spriteFacesLeft = value;
}

public HutongGames.PlayMaker.FsmString groundLayer
{
get => orig.groundLayer;
set => orig.groundLayer = value;
}

public float turnDelay
{
get => orig.turnDelay;
set => orig.turnDelay = value;
}

public float nextTurnTime
{
get => GetField<float>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmString walkAnimName
{
get => orig.walkAnimName;
set => orig.walkAnimName = value;
}

public HutongGames.PlayMaker.FsmString turnAnimName
{
get => orig.turnAnimName;
set => orig.turnAnimName = value;
}

public HutongGames.PlayMaker.FsmBool startLeft
{
get => orig.startLeft;
set => orig.startLeft = value;
}

public HutongGames.PlayMaker.FsmBool startRight
{
get => orig.startRight;
set => orig.startRight = value;
}

public HutongGames.PlayMaker.FsmBool keepDirection
{
get => orig.keepDirection;
set => orig.keepDirection = value;
}

public float scaleX_pos
{
get => GetField<float>();
set => SetField(value);
}

public float scaleX_neg
{
get => GetField<float>();
set => SetField(value);
}

public float wallRayHeight
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float wallRayLength
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float groundRayLength
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public UnityEngine.GameObject target
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D body
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public tk2dSpriteAnimator spriteAnimator
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public UnityEngine.Collider2D collider
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public UnityEngine.Coroutine walkRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public UnityEngine.Coroutine turnRoutine
{
get => GetField<UnityEngine.Coroutine>();
set => SetField(value);
}

public bool shouldTurn
{
get => GetField<bool>();
set => SetField(value);
}

public float Direction
{
get => GetProperty<float>();
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

public void OnEnter () =>
orig.OnEnter();

public void OnExit () =>
orig.OnExit();

public void UpdateIfTargetChanged () =>
CallMethod();

public System.Collections.IEnumerator Walk () =>
CallMethod<System.Collections.IEnumerator>();

public System.Collections.IEnumerator Turn () =>
CallMethod<System.Collections.IEnumerator>();

public bool CheckWall () =>
CallMethod<bool>();

public bool CheckFloor () =>
CallMethod<bool>();

public bool CheckIsGrounded () =>
CallMethod<bool>();

public void SetupStartingDirection () =>
CallMethod();

}
}
