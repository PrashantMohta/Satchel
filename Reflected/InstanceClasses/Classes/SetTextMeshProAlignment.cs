namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetTextMeshProAlignment allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetTextMeshProAlignmentR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.SetTextMeshProAlignment>
{
public SetTextMeshProAlignmentR(HutongGames.PlayMaker.Actions.SetTextMeshProAlignment _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool topLeft
{
get => orig.topLeft;
set => orig.topLeft = value;
}

public HutongGames.PlayMaker.FsmBool topRight
{
get => orig.topRight;
set => orig.topRight = value;
}

public HutongGames.PlayMaker.FsmBool topCentre
{
get => orig.topCentre;
set => orig.topCentre = value;
}

public HutongGames.PlayMaker.FsmBool topJustified
{
get => orig.topJustified;
set => orig.topJustified = value;
}

public HutongGames.PlayMaker.FsmBool centreLeft
{
get => orig.centreLeft;
set => orig.centreLeft = value;
}

public HutongGames.PlayMaker.FsmBool centreRight
{
get => orig.centreRight;
set => orig.centreRight = value;
}

public HutongGames.PlayMaker.FsmBool centreCentre
{
get => orig.centreCentre;
set => orig.centreCentre = value;
}

public HutongGames.PlayMaker.FsmBool centreJustified
{
get => orig.centreJustified;
set => orig.centreJustified = value;
}

public HutongGames.PlayMaker.FsmBool bottomLeft
{
get => orig.bottomLeft;
set => orig.bottomLeft = value;
}

public HutongGames.PlayMaker.FsmBool bottomRight
{
get => orig.bottomRight;
set => orig.bottomRight = value;
}

public HutongGames.PlayMaker.FsmBool bottomCentre
{
get => orig.bottomCentre;
set => orig.bottomCentre = value;
}

public HutongGames.PlayMaker.FsmBool bottomJustified
{
get => orig.bottomJustified;
set => orig.bottomJustified = value;
}

public UnityEngine.GameObject go
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public TMPro.TextMeshPro textMesh
{
get => GetField<TMPro.TextMeshPro>();
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

}
}
