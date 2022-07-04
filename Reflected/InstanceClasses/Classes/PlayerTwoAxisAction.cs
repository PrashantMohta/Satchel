namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerTwoAxisAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerTwoAxisActionR:InstanceClassWrapper<InControl.PlayerTwoAxisAction>
{
public PlayerTwoAxisActionR(InControl.PlayerTwoAxisAction _orig) : base(_orig) {}
public InControl.PlayerAction negativeXAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.PlayerAction positiveXAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.PlayerAction negativeYAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.PlayerAction positiveYAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public InControl.BindingSourceType LastInputType
{
get => orig.LastInputType;
set => orig.LastInputType = value;
}

public System.Action<InControl.BindingSourceType> OnLastInputTypeChanged
{
get => GetField<System.Action<InControl.BindingSourceType>>();
set => SetField(value);
}

public InControl.DeadZoneFunc DeadZoneFunc
{
get => orig.DeadZoneFunc;
set => orig.DeadZoneFunc = value;
}

public bool Raw
{
get => orig.Raw;
set => orig.Raw = value;
}

public bool InvertXAxis
{
get => orig.InvertXAxis;
set => orig.InvertXAxis = value;
}

public bool InvertYAxis
{
get => orig.InvertYAxis;
set => orig.InvertYAxis = value;
}

public System.Object UserData
{
get => orig.UserData;
set => orig.UserData = value;
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

public void Update (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void ProcessActionUpdate (InControl.PlayerAction action) =>
CallMethod(new object[] {action});

}
}
