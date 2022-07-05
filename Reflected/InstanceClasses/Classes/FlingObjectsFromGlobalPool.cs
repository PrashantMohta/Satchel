namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FlingObjectsFromGlobalPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FlingObjectsFromGlobalPoolR : InstanceClassWrapper<FlingObjectsFromGlobalPool>
{
    public FlingObjectsFromGlobalPoolR(FlingObjectsFromGlobalPool _orig) : base(_orig)
    {
    }

    public FsmGameObject gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject spawnPoint
    {
        get => orig.spawnPoint;
        set => orig.spawnPoint = value;
    }

    public FsmVector3 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public FsmInt spawnMin
    {
        get => orig.spawnMin;
        set => orig.spawnMin = value;
    }

    public FsmInt spawnMax
    {
        get => orig.spawnMax;
        set => orig.spawnMax = value;
    }

    public FsmFloat speedMin
    {
        get => orig.speedMin;
        set => orig.speedMin = value;
    }

    public FsmFloat speedMax
    {
        get => orig.speedMax;
        set => orig.speedMax = value;
    }

    public FsmFloat angleMin
    {
        get => orig.angleMin;
        set => orig.angleMin = value;
    }

    public FsmFloat angleMax
    {
        get => orig.angleMax;
        set => orig.angleMax = value;
    }

    public FsmFloat originVariationX
    {
        get => orig.originVariationX;
        set => orig.originVariationX = value;
    }

    public FsmFloat originVariationY
    {
        get => orig.originVariationY;
        set => orig.originVariationY = value;
    }

    public FsmString FSM
    {
        get => orig.FSM;
        set => orig.FSM = value;
    }

    public FsmString FSMEvent
    {
        get => orig.FSMEvent;
        set => orig.FSMEvent = value;
    }

    public float vectorX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float vectorY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool originAdjusted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Rigidbody2D rb2d
    {
        get => GetField<Rigidbody2D>();
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
}