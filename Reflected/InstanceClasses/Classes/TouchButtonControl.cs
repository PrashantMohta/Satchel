namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TouchButtonControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchButtonControlR:InstanceClassWrapper<InControl.TouchButtonControl>
{
public TouchButtonControlR(InControl.TouchButtonControl _orig) : base(_orig) {}
public InControl.TouchControlAnchor anchor
{
get => GetField<InControl.TouchControlAnchor>();
set => SetField(value);
}

public InControl.TouchUnitType offsetUnitType
{
get => GetField<InControl.TouchUnitType>();
set => SetField(value);
}

public UnityEngine.Vector2 offset
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool lockAspectRatio
{
get => GetField<bool>();
set => SetField(value);
}

public bool allowSlideToggle
{
get => orig.allowSlideToggle;
set => orig.allowSlideToggle = value;
}

public bool toggleOnLeave
{
get => orig.toggleOnLeave;
set => orig.toggleOnLeave = value;
}

public bool pressureSensitive
{
get => orig.pressureSensitive;
set => orig.pressureSensitive = value;
}

public InControl.TouchSprite button
{
get => orig.button;
set => orig.button = value;
}

public bool buttonState
{
get => GetField<bool>();
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

public bool ButtonState
{
get => GetProperty<bool>();
set => SetProperty(value);
}

public UnityEngine.Vector3 ButtonPosition
{
get => orig.ButtonPosition;
set => orig.ButtonPosition = value;
}

public InControl.TouchControlAnchor Anchor
{
get => orig.Anchor;
set => orig.Anchor = value;
}

public UnityEngine.Vector2 Offset
{
get => orig.Offset;
set => orig.Offset = value;
}

public InControl.TouchUnitType OffsetUnitType
{
get => orig.OffsetUnitType;
set => orig.OffsetUnitType = value;
}



public void CreateControl () =>
orig.CreateControl();

public void DestroyControl () =>
orig.DestroyControl();

public void ConfigureControl () =>
orig.ConfigureControl();

public void DrawGizmos () =>
orig.DrawGizmos();

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
