namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dTextMeshSetPixelPerfect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dTextMeshSetPixelPerfectR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.Tk2dTextMeshSetPixelPerfect>
{
public Tk2dTextMeshSetPixelPerfectR(HutongGames.PlayMaker.Actions.Tk2dTextMeshSetPixelPerfect _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool pixelPerfect
{
get => orig.pixelPerfect;
set => orig.pixelPerfect = value;
}

public HutongGames.PlayMaker.FsmBool commit
{
get => orig.commit;
set => orig.commit = value;
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

public void DoSetPixelPerfect () =>
CallMethod();

}
}
