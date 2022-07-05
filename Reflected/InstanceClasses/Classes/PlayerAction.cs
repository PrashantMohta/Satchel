using System.Collections.ObjectModel;
using System.IO;
using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerActionR : InstanceClassWrapper<PlayerAction>
{
    public PlayerActionR(PlayerAction _orig) : base(_orig)
    {
    }

    public BindingListenOptions ListenOptions
    {
        get => orig.ListenOptions;
        set => orig.ListenOptions = value;
    }

    public BindingSourceType LastInputType
    {
        get => orig.LastInputType;
        set => orig.LastInputType = value;
    }

    public Action<BindingSourceType> OnLastInputTypeChanged
    {
        get => GetField<Action<BindingSourceType>>();
        set => SetField(value);
    }

    public ulong LastInputTypeChangedTick
    {
        get => orig.LastInputTypeChangedTick;
        set => orig.LastInputTypeChangedTick = value;
    }

    public InputDeviceClass LastDeviceClass
    {
        get => orig.LastDeviceClass;
        set => orig.LastDeviceClass = value;
    }

    public InputDeviceStyle LastDeviceStyle
    {
        get => orig.LastDeviceStyle;
        set => orig.LastDeviceStyle = value;
    }

    public Action OnBindingsChanged
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public List<BindingSource> defaultBindings
    {
        get => GetField<List<BindingSource>>();
        set => SetField(value);
    }

    public List<BindingSource> regularBindings
    {
        get => GetField<List<BindingSource>>();
        set => SetField(value);
    }

    public List<BindingSource> visibleBindings
    {
        get => GetField<List<BindingSource>>();
        set => SetField(value);
    }

    public ReadOnlyCollection<BindingSource> bindings
    {
        get => GetField<ReadOnlyCollection<BindingSource>>();
        set => SetField(value);
    }

    public ReadOnlyCollection<BindingSource> unfilteredBindings
    {
        get => GetField<ReadOnlyCollection<BindingSource>>();
        set => SetField(value);
    }

    public BindingSourceListener[] bindingSourceListeners
    {
        get => GetField<BindingSourceListener[]>();
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

    public InputDevice device
    {
        get => GetField<InputDevice>();
        set => SetField(value);
    }

    public InputDevice activeDevice
    {
        get => GetField<InputDevice>();
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

    public PlayerActionSet Owner
    {
        get => orig.Owner;
        set => SetProperty(value);
    }

    public object UserData
    {
        get => orig.UserData;
        set => orig.UserData = value;
    }

    public bool IsListeningForBinding => orig.IsListeningForBinding;

    public ReadOnlyCollection<BindingSource> Bindings => orig.Bindings;

    public ReadOnlyCollection<BindingSource> UnfilteredBindings => orig.UnfilteredBindings;

    public InputDevice Device
    {
        get => GetProperty<InputDevice>();
        set => SetProperty(value);
    }

    public InputDevice ActiveDevice => orig.ActiveDevice;

    public bool LastInputTypeIsDevice => GetProperty<bool>();

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

    public ulong UpdateTick
    {
        get => orig.UpdateTick;
        set => SetProperty(value);
    }

    public bool State => orig.State;

    public bool LastState => orig.LastState;

    public float Value => orig.Value;

    public float LastValue => orig.LastValue;

    public float RawValue => orig.RawValue;

    public float NextRawValue => GetProperty<float>();

    public bool HasInput => GetProperty<bool>();

    public bool HasChanged => orig.HasChanged;

    public bool IsPressed => orig.IsPressed;

    public bool WasPressed => orig.WasPressed;

    public bool WasReleased => orig.WasReleased;

    public bool WasRepeated => orig.WasRepeated;

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

    public bool IsNullControl => orig.IsNullControl;

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool EnabledInHierarchy => orig.EnabledInHierarchy;

    public void AddDefaultBinding(BindingSource binding)
    {
        orig.AddDefaultBinding(binding);
    }

    public void AddDefaultBinding(Key[] keys)
    {
        orig.AddDefaultBinding(keys);
    }

    public void AddDefaultBinding(KeyCombo keyCombo)
    {
        orig.AddDefaultBinding(keyCombo);
    }

    public void AddDefaultBinding(Mouse control)
    {
        orig.AddDefaultBinding(control);
    }

    public void AddDefaultBinding(InputControlType control)
    {
        orig.AddDefaultBinding(control);
    }

    public bool AddBinding(BindingSource binding)
    {
        return orig.AddBinding(binding);
    }

    public bool InsertBindingAt(int index, BindingSource binding)
    {
        return orig.InsertBindingAt(index, binding);
    }

    public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
    {
        return orig.ReplaceBinding(findBinding, withBinding);
    }

    public bool HasBinding(BindingSource binding)
    {
        return orig.HasBinding(binding);
    }

    public BindingSource FindBinding(BindingSource binding)
    {
        return orig.FindBinding(binding);
    }

    public void HardRemoveBinding(BindingSource binding)
    {
        CallMethod(new object[] { binding });
    }

    public void RemoveBinding(BindingSource binding)
    {
        orig.RemoveBinding(binding);
    }

    public void RemoveBindingAt(int index)
    {
        orig.RemoveBindingAt(index);
    }

    public int CountBindingsOfType(BindingSourceType bindingSourceType)
    {
        return CallMethod<int>(new object[] { bindingSourceType });
    }

    public void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
    {
        CallMethod(new object[] { bindingSourceType });
    }

    public int IndexOfFirstInvalidBinding()
    {
        return CallMethod<int>();
    }

    public void ClearBindings()
    {
        orig.ClearBindings();
    }

    public void ResetBindings()
    {
        orig.ResetBindings();
    }

    public void ListenForBinding()
    {
        orig.ListenForBinding();
    }

    public void ListenForBindingReplacing(BindingSource binding)
    {
        orig.ListenForBindingReplacing(binding);
    }

    public void StopListeningForBinding()
    {
        orig.StopListeningForBinding();
    }

    public void RemoveOrphanedBindings()
    {
        CallMethod();
    }

    public void Update(ulong updateTick, float deltaTime, InputDevice device)
    {
        CallMethod(new object[] { updateTick, deltaTime, device });
    }

    public void UpdateBindings(ulong updateTick, float deltaTime)
    {
        CallMethod(new object[] { updateTick, deltaTime });
    }

    public void DetectBindings()
    {
        CallMethod();
    }

    public void UpdateVisibleBindings()
    {
        CallMethod();
    }

    public void Load(BinaryReader reader, ushort dataFormatVersion)
    {
        CallMethod(new object[] { reader, dataFormatVersion });
    }

    public void Save(BinaryWriter writer)
    {
        CallMethod(new object[] { writer });
    }
}