namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ScaleTo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScaleToR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ScaleTo>
{
public ScaleToR(HutongGames.PlayMaker.Actions.ScaleTo _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmVector3 target
{
get => orig.target;
set => orig.target = value;
}

public HutongGames.PlayMaker.FsmFloat duration
{
get => orig.duration;
set => orig.duration = value;
}

public HutongGames.PlayMaker.FsmFloat delay
{
get => orig.delay;
set => orig.delay = value;
}

public HutongGames.PlayMaker.Actions.ScaleToCurves curve
{
get => orig.curve;
set => orig.curve = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Transform transform
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector3 startScale
{
get => GetField<UnityEngine.Vector3>();
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

public void UpdateScaling () =>
CallMethod();

public float GetCurved (float val, HutongGames.PlayMaker.Actions.ScaleToCurves curve) =>
CallMethodStatic<float>(new object[] {val, curve});

public float Linear (float val) =>
CallMethodStatic<float>(new object[] {val});

public float QuadraticOut (float val) =>
CallMethodStatic<float>(new object[] {val});

public float SinusoidalOut (float val) =>
CallMethodStatic<float>(new object[] {val});

}
}
