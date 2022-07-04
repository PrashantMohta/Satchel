namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TwoAxisInputControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TwoAxisInputControlR:InstanceClassWrapper<InControl.TwoAxisInputControl>
{
public TwoAxisInputControlR(InControl.TwoAxisInputControl _orig) : base(_orig) {}
public InControl.TwoAxisInputControl Null
{
get => InControl.TwoAxisInputControl.Null;
set => SetField(value);
}

public InControl.DeadZoneFunc DeadZoneFunc
{
get => orig.DeadZoneFunc;
set => orig.DeadZoneFunc = value;
}

public float sensitivity
{
get => GetField<float>();
set => SetField(value);
}

public float lowerDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public float upperDeadZone
{
get => GetField<float>();
set => SetField(value);
}

public float stateThreshold
{
get => GetField<float>();
set => SetField(value);
}

public bool Raw
{
get => orig.Raw;
set => orig.Raw = value;
}

public bool thisState
{
get => GetField<bool>();
set => SetField(value);
}

public bool lastState
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector2 thisValue
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 lastValue
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public bool clearInputState
{
get => GetField<bool>();
set => SetField(value);
}

public float X
{
get => orig.X;
set => SetProperty(value);
}

public float Y
{
get => orig.Y;
set => SetProperty(value);
}

public InControl.OneAxisInputControl Left
{
get => orig.Left;
set => SetProperty(value);
}

public InControl.OneAxisInputControl Right
{
get => orig.Right;
set => SetProperty(value);
}

public InControl.OneAxisInputControl Up
{
get => orig.Up;
set => SetProperty(value);
}

public InControl.OneAxisInputControl Down
{
get => orig.Down;
set => SetProperty(value);
}

public System.UInt64 UpdateTick
{
get => orig.UpdateTick;
set => SetProperty(value);
}

public float Sensitivity
{
get => orig.Sensitivity;
set => orig.Sensitivity = value;
}

public float StateThreshold
{
get => orig.StateThreshold;
set => orig.StateThreshold = value;
}

public float LowerDeadZone
{
get => orig.LowerDeadZone;
set => orig.LowerDeadZone = value;
}

public float UpperDeadZone
{
get => orig.UpperDeadZone;
set => orig.UpperDeadZone = value;
}

public bool State
{
get => orig.State;
}

public bool LastState
{
get => orig.LastState;
}

public UnityEngine.Vector2 Value
{
get => orig.Value;
}

public UnityEngine.Vector2 LastValue
{
get => orig.LastValue;
}

public UnityEngine.Vector2 Vector
{
get => orig.Vector;
}

public bool HasChanged
{
get => orig.HasChanged;
set => SetProperty(value);
}

public bool IsPressed
{
get => orig.IsPressed;
}

public bool WasPressed
{
get => orig.WasPressed;
}

public bool WasReleased
{
get => orig.WasReleased;
}

public float Angle
{
get => orig.Angle;
}

public void ClearInputState () =>
orig.ClearInputState();

public void Filter (InControl.TwoAxisInputControl twoAxisInputControl, float deltaTime) =>
orig.Filter(twoAxisInputControl, deltaTime);

public void UpdateWithAxes (float x, float y, System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {x, y, updateTick, deltaTime});

}
}
