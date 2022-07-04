namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dTextMeshGetColors allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dTextMeshGetColorsR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Tk2dTextMeshGetColors>
{
public Tk2dTextMeshGetColorsR(HutongGames.PlayMaker.Actions.Tk2dTextMeshGetColors _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmColor mainColor
{
get => orig.mainColor;
set => orig.mainColor = value;
}

public HutongGames.PlayMaker.FsmColor gradientColor
{
get => orig.gradientColor;
set => orig.gradientColor = value;
}

public HutongGames.PlayMaker.FsmBool useGradient
{
get => orig.useGradient;
set => orig.useGradient = value;
}

public bool everyframe
{
get => orig.everyframe;
set => orig.everyframe = value;
}

public tk2dTextMesh _textMesh
{
get => GetField<tk2dTextMesh>();
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

public void _getTextMesh () =>
CallMethod();

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void DoGetColors () =>
CallMethod();

}
}
