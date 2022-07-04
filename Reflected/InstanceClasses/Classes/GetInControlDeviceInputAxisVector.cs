using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetInControlDeviceInputAxisVector allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetInControlDeviceInputAxisVectorR : InstanceClassWrapper<GetInControlDeviceInputAxisVector>
{
    public GetInControlDeviceInputAxisVectorR(GetInControlDeviceInputAxisVector _orig) : base(_orig)
    {
    }

    public FsmInt deviceIndex
    {
        get => orig.deviceIndex;
        set => orig.deviceIndex = value;
    }

    public InputControlType horizontalAxis
    {
        get => orig.horizontalAxis;
        set => orig.horizontalAxis = value;
    }

    public InputControlType verticalAxis
    {
        get => orig.verticalAxis;
        set => orig.verticalAxis = value;
    }

    public FsmFloat multiplier
    {
        get => orig.multiplier;
        set => orig.multiplier = value;
    }

    public FsmGameObject relativeTo
    {
        get => orig.relativeTo;
        set => orig.relativeTo = value;
    }

    public FsmVector3 storeVector
    {
        get => orig.storeVector;
        set => orig.storeVector = value;
    }

    public FsmFloat storeMagnitude
    {
        get => orig.storeMagnitude;
        set => orig.storeMagnitude = value;
    }

    public InputDevice _inputDevice
    {
        get => GetField<InputDevice>();
        set => SetField(value);
    }

    public InputControl _inputControl
    {
        get => GetField<InputControl>();
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

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
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

    public void Reset()
    {
        orig.Reset();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}