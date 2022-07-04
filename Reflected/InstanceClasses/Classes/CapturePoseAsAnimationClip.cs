namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CapturePoseAsAnimationClip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CapturePoseAsAnimationClipR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.CapturePoseAsAnimationClip>
{
public CapturePoseAsAnimationClipR(HutongGames.PlayMaker.Actions.CapturePoseAsAnimationClip _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmOwnerDefault gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public HutongGames.PlayMaker.FsmBool position
{
get => orig.position;
set => orig.position = value;
}

public HutongGames.PlayMaker.FsmBool rotation
{
get => orig.rotation;
set => orig.rotation = value;
}

public HutongGames.PlayMaker.FsmBool scale
{
get => orig.scale;
set => orig.scale = value;
}

public HutongGames.PlayMaker.FsmObject storeAnimationClip
{
get => orig.storeAnimationClip;
set => orig.storeAnimationClip = value;
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

public void DoCaptureAnimationClip () =>
CallMethod();

public void CaptureTransform (UnityEngine.Transform transform, string path, UnityEngine.AnimationClip clip) =>
CallMethod(new object[] {transform, path, clip});

public void CapturePosition (UnityEngine.Transform transform, string path, UnityEngine.AnimationClip clip) =>
CallMethod(new object[] {transform, path, clip});

public void CaptureRotation (UnityEngine.Transform transform, string path, UnityEngine.AnimationClip clip) =>
CallMethod(new object[] {transform, path, clip});

public void CaptureScale (UnityEngine.Transform transform, string path, UnityEngine.AnimationClip clip) =>
CallMethod(new object[] {transform, path, clip});

public void SetConstantCurve (UnityEngine.AnimationClip clip, string childPath, string propertyPath, float value) =>
CallMethod(new object[] {clip, childPath, propertyPath, value});

}
}
