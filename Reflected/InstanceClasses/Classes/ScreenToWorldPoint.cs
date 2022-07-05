namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScreenToWorldPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScreenToWorldPointR : InstanceClassWrapper<ScreenToWorldPoint>
{
    public ScreenToWorldPointR(ScreenToWorldPoint _orig) : base(_orig)
    {
    }

    public FsmVector3 screenVector
    {
        get => orig.screenVector;
        set => orig.screenVector = value;
    }

    public FsmFloat screenX
    {
        get => orig.screenX;
        set => orig.screenX = value;
    }

    public FsmFloat screenY
    {
        get => orig.screenY;
        set => orig.screenY = value;
    }

    public FsmFloat screenZ
    {
        get => orig.screenZ;
        set => orig.screenZ = value;
    }

    public FsmBool normalized
    {
        get => orig.normalized;
        set => orig.normalized = value;
    }

    public FsmVector3 storeWorldVector
    {
        get => orig.storeWorldVector;
        set => orig.storeWorldVector = value;
    }

    public FsmFloat storeWorldX
    {
        get => orig.storeWorldX;
        set => orig.storeWorldX = value;
    }

    public FsmFloat storeWorldY
    {
        get => orig.storeWorldY;
        set => orig.storeWorldY = value;
    }

    public FsmFloat storeWorldZ
    {
        get => orig.storeWorldZ;
        set => orig.storeWorldZ = value;
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

    public void DoScreenToWorldPoint()
    {
        CallMethod();
    }
}