namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetTouchInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetTouchInfoR : InstanceClassWrapper<GetTouchInfo>
{
    public GetTouchInfoR(GetTouchInfo _orig) : base(_orig)
    {
    }

    public FsmInt fingerId
    {
        get => orig.fingerId;
        set => orig.fingerId = value;
    }

    public FsmBool normalize
    {
        get => orig.normalize;
        set => orig.normalize = value;
    }

    public FsmVector3 storePosition
    {
        get => orig.storePosition;
        set => orig.storePosition = value;
    }

    public FsmFloat storeX
    {
        get => orig.storeX;
        set => orig.storeX = value;
    }

    public FsmFloat storeY
    {
        get => orig.storeY;
        set => orig.storeY = value;
    }

    public FsmVector3 storeDeltaPosition
    {
        get => orig.storeDeltaPosition;
        set => orig.storeDeltaPosition = value;
    }

    public FsmFloat storeDeltaX
    {
        get => orig.storeDeltaX;
        set => orig.storeDeltaX = value;
    }

    public FsmFloat storeDeltaY
    {
        get => orig.storeDeltaY;
        set => orig.storeDeltaY = value;
    }

    public FsmFloat storeDeltaTime
    {
        get => orig.storeDeltaTime;
        set => orig.storeDeltaTime = value;
    }

    public FsmInt storeTapCount
    {
        get => orig.storeTapCount;
        set => orig.storeTapCount = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public float screenWidth
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float screenHeight
    {
        get => GetField<float>();
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoGetTouchInfo()
    {
        CallMethod();
    }
}