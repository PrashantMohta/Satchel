namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CheckTargetDirection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckTargetDirectionR : InstanceClassWrapper<CheckTargetDirection>
{
    public CheckTargetDirectionR(CheckTargetDirection _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmEvent aboveEvent
    {
        get => orig.aboveEvent;
        set => orig.aboveEvent = value;
    }

    public FsmEvent belowEvent
    {
        get => orig.belowEvent;
        set => orig.belowEvent = value;
    }

    public FsmEvent rightEvent
    {
        get => orig.rightEvent;
        set => orig.rightEvent = value;
    }

    public FsmEvent leftEvent
    {
        get => orig.leftEvent;
        set => orig.leftEvent = value;
    }

    public FsmBool aboveBool
    {
        get => orig.aboveBool;
        set => orig.aboveBool = value;
    }

    public FsmBool belowBool
    {
        get => orig.belowBool;
        set => orig.belowBool = value;
    }

    public FsmBool rightBool
    {
        get => orig.rightBool;
        set => orig.rightBool = value;
    }

    public FsmBool leftBool
    {
        get => orig.leftBool;
        set => orig.leftBool = value;
    }

    public FsmGameObject self
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public FsmFloat x
    {
        get => GetField<FsmFloat>();
        set => SetField(value);
    }

    public FsmFloat y
    {
        get => GetField<FsmFloat>();
        set => SetField(value);
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoCheckDirection()
    {
        CallMethod();
    }
}