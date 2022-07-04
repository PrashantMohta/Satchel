namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerActionR:InstanceClassWrapper<InControl.PlayerAction>
{
public PlayerActionR(InControl.PlayerAction _orig) : base(_orig) {}
public InControl.BindingListenOptions ListenOptions
{
get => orig.ListenOptions;
set => orig.ListenOptions = value;
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

public System.UInt64 LastInputTypeChangedTick
{
get => orig.LastInputTypeChangedTick;
set => orig.LastInputTypeChangedTick = value;
}

public InControl.InputDeviceClass LastDeviceClass
{
get => orig.LastDeviceClass;
set => orig.LastDeviceClass = value;
}

public InControl.InputDeviceStyle LastDeviceStyle
{
get => orig.LastDeviceStyle;
set => orig.LastDeviceStyle = value;
}

public System.Action OnBindingsChanged
{
get => GetField<System.Action>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.BindingSource> defaultBindings
{
get => GetField<System.Collections.Generic.List<InControl.BindingSource>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.BindingSource> regularBindings
{
get => GetField<System.Collections.Generic.List<InControl.BindingSource>>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.BindingSource> visibleBindings
{
get => GetField<System.Collections.Generic.List<InControl.BindingSource>>();
set => SetField(value);
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource> bindings
{
get => GetField<System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource>>();
set => SetField(value);
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource> unfilteredBindings
{
get => GetField<System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource>>();
set => SetField(value);
}

public InControl.BindingSourceListener[] bindingSourceListeners
{
get => GetField<InControl.BindingSourceListener[]>();
set => SetField(value);
}

public bool triggerBindingEnded
{
get => GetField<bool>();
set => SetField(value);
}

public bool triggerBindingChanged
{
get => GetField<bool>();
set => SetField(value);
}

public InControl.InputDevice device
{
get => GetField<InControl.InputDevice>();
set => SetField(value);
}

public InControl.InputDevice activeDevice
{
get => GetField<InControl.InputDevice>();
set => SetField(value);
}

public bool isNullControl
{
get => GetField<bool>();
set => SetField(value);
}

public float FirstRepeatDelay
{
get => orig.FirstRepeatDelay;
set => orig.FirstRepeatDelay = value;
}

public float RepeatDelay
{
get => orig.RepeatDelay;
set => orig.RepeatDelay = value;
}

public bool Raw
{
get => orig.Raw;
set => orig.Raw = value;
}

public bool ownerEnabled
{
get => GetField<bool>();
set => SetField(value);
}

public string Name
{
get => orig.Name;
set => SetProperty(value);
}

public InControl.PlayerActionSet Owner
{
get => orig.Owner;
set => SetProperty(value);
}

public System.Object UserData
{
get => orig.UserData;
set => orig.UserData = value;
}

public bool IsListeningForBinding
{
get => orig.IsListeningForBinding;
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource> Bindings
{
get => orig.Bindings;
}

public System.Collections.ObjectModel.ReadOnlyCollection<InControl.BindingSource> UnfilteredBindings
{
get => orig.UnfilteredBindings;
}

public InControl.InputDevice Device
{
get => GetProperty<InControl.InputDevice>();
set => SetProperty(value);
}

public InControl.InputDevice ActiveDevice
{
get => orig.ActiveDevice;
}

public bool LastInputTypeIsDevice
{
get => GetProperty<bool>();
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

public System.UInt64 UpdateTick
{
get => orig.UpdateTick;
set => SetProperty(value);
}

public bool State
{
get => orig.State;
}

public bool LastState
{
get => orig.LastState;
}

public float Value
{
get => orig.Value;
}

public float LastValue
{
get => orig.LastValue;
}

public float RawValue
{
get => orig.RawValue;
}

public float NextRawValue
{
get => GetProperty<float>();
}

public bool HasInput
{
get => GetProperty<bool>();
}

public bool HasChanged
{
get => orig.HasChanged;
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

public bool WasRepeated
{
get => orig.WasRepeated;
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

public bool IsNullControl
{
get => orig.IsNullControl;
}

public bool Enabled
{
get => orig.Enabled;
set => orig.Enabled = value;
}

public bool EnabledInHierarchy
{
get => orig.EnabledInHierarchy;
}

public void AddDefaultBinding (InControl.BindingSource binding) =>
orig.AddDefaultBinding(binding);

public void AddDefaultBinding (InControl.Key[] keys) =>
orig.AddDefaultBinding(keys);

public void AddDefaultBinding (InControl.KeyCombo keyCombo) =>
orig.AddDefaultBinding(keyCombo);

public void AddDefaultBinding (InControl.Mouse control) =>
orig.AddDefaultBinding(control);

public void AddDefaultBinding (InControl.InputControlType control) =>
orig.AddDefaultBinding(control);

public bool AddBinding (InControl.BindingSource binding) =>
orig.AddBinding(binding);

public bool InsertBindingAt (int index, InControl.BindingSource binding) =>
orig.InsertBindingAt(index, binding);

public bool ReplaceBinding (InControl.BindingSource findBinding, InControl.BindingSource withBinding) =>
orig.ReplaceBinding(findBinding, withBinding);

public bool HasBinding (InControl.BindingSource binding) =>
orig.HasBinding(binding);

public InControl.BindingSource FindBinding (InControl.BindingSource binding) =>
orig.FindBinding(binding);

public void HardRemoveBinding (InControl.BindingSource binding) =>
CallMethod(new object[] {binding});

public void RemoveBinding (InControl.BindingSource binding) =>
orig.RemoveBinding(binding);

public void RemoveBindingAt (int index) =>
orig.RemoveBindingAt(index);

public int CountBindingsOfType (InControl.BindingSourceType bindingSourceType) =>
CallMethod<int>(new object[] {bindingSourceType});

public void RemoveFirstBindingOfType (InControl.BindingSourceType bindingSourceType) =>
CallMethod(new object[] {bindingSourceType});

public int IndexOfFirstInvalidBinding () =>
CallMethod<int>();

public void ClearBindings () =>
orig.ClearBindings();

public void ResetBindings () =>
orig.ResetBindings();

public void ListenForBinding () =>
orig.ListenForBinding();

public void ListenForBindingReplacing (InControl.BindingSource binding) =>
orig.ListenForBindingReplacing(binding);

public void StopListeningForBinding () =>
orig.StopListeningForBinding();

public void RemoveOrphanedBindings () =>
CallMethod();

public void Update (System.UInt64 updateTick, float deltaTime, InControl.InputDevice device) =>
CallMethod(new object[] {updateTick, deltaTime, device});

public void UpdateBindings (System.UInt64 updateTick, float deltaTime) =>
CallMethod(new object[] {updateTick, deltaTime});

public void DetectBindings () =>
CallMethod();

public void UpdateVisibleBindings () =>
CallMethod();

public void Load (System.IO.BinaryReader reader, System.UInt16 dataFormatVersion) =>
CallMethod(new object[] {reader, dataFormatVersion});

public void Save (System.IO.BinaryWriter writer) =>
CallMethod(new object[] {writer});

}
}
