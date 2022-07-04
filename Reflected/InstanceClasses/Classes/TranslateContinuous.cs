namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TranslateContinuous allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TranslateContinuousR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.TranslateContinuous>
{
public TranslateContinuousR(HutongGames.PlayMaker.Actions.TranslateContinuous _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmFloat x
{
get => orig.x;
set => orig.x = value;
}

public HutongGames.PlayMaker.FsmFloat y
{
get => orig.y;
set => orig.y = value;
}

public HutongGames.PlayMaker.FsmInt[] layerMask
{
get => orig.layerMask;
set => orig.layerMask = value;
}

public UnityEngine.GameObject go
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public int moveDirection
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.BoxCollider2D collider
{
get => GetField<UnityEngine.BoxCollider2D>();
set => SetField(value);
}

public UnityEngine.Vector2 point1Offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 point2Offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 point3Offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 rayOrigin1
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 rayOrigin2
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 rayOrigin3
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 rayCastDirection
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 debugDirection
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public float moveDistance
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector2 translate
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool hitWall
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

public void Awake () =>
orig.Awake();

public void OnPreprocess () =>
orig.OnPreprocess();

public void OnEnter () =>
orig.OnEnter();

public void OnFixedUpdate () =>
orig.OnFixedUpdate();

public void DoTranslate () =>
CallMethod();

}
}
