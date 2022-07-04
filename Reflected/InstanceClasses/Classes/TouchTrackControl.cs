namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchTrackControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchTrackControlR:InstanceClassWrapper<InControl.TouchTrackControl>
{
public TouchTrackControlR(InControl.TouchTrackControl _orig) : base(_orig) {}
public InControl.TouchUnitType areaUnitType
{
get => GetField<InControl.TouchUnitType>();
set => SetField(value);
}

public UnityEngine.Rect activeArea
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public float scale
{
get => orig.scale;
set => orig.scale = value;
}

public float maxTapDuration
{
get => orig.maxTapDuration;
set => orig.maxTapDuration = value;
}

public float maxTapMovement
{
get => orig.maxTapMovement;
set => orig.maxTapMovement = value;
}

public UnityEngine.Rect worldActiveArea
{
get => GetField<UnityEngine.Rect>();
set => SetField(value);
}

public UnityEngine.Vector3 lastPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 thisPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public InControl.Touch currentTouch
{
get => GetField<InControl.Touch>();
set => SetField(value);
}

public bool dirty
{
get => GetField<bool>();
set => SetField(value);
}

public bool fireButtonTarget
{
get => GetField<bool>();
set => SetField(value);
}

public float beganTime
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 beganPosition
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Rect ActiveArea
{
get => orig.ActiveArea;
set => orig.ActiveArea = value;
}

public InControl.TouchUnitType AreaUnitType
{
get => orig.AreaUnitType;
set => orig.AreaUnitType = value;
}



public void CreateControl () =>
orig.CreateControl();

public void DestroyControl () =>
orig.DestroyControl();

public void ConfigureControl () =>
orig.ConfigureControl();

public void DrawGizmos () =>
orig.DrawGizmos();

public void OnValidate () =>
CallMethod();

public void Update () =>
CallMethod();

public void SubmitControlState (System.UInt64 updateTick, float deltaTime) =>
orig.SubmitControlState(updateTick, deltaTime);

public void CommitControlState (System.UInt64 updateTick, float deltaTime) =>
orig.CommitControlState(updateTick, deltaTime);

public void TouchBegan (InControl.Touch touch) =>
orig.TouchBegan(touch);

public void TouchMoved (InControl.Touch touch) =>
orig.TouchMoved(touch);

public void TouchEnded (InControl.Touch touch) =>
orig.TouchEnded(touch);

}
}
