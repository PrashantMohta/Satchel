namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of WorldToScreenPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldToScreenPointR : InstanceClassWrapper<WorldToScreenPoint>
{
    public WorldToScreenPointR(WorldToScreenPoint _orig) : base(_orig)
    {
    }

    public FsmVector3 worldPosition
    {
        get => orig.worldPosition;
        set => orig.worldPosition = value;
    }

    public FsmFloat worldX
    {
        get => orig.worldX;
        set => orig.worldX = value;
    }

    public FsmFloat worldY
    {
        get => orig.worldY;
        set => orig.worldY = value;
    }

    public FsmFloat worldZ
    {
        get => orig.worldZ;
        set => orig.worldZ = value;
    }

    public FsmVector3 storeScreenPoint
    {
        get => orig.storeScreenPoint;
        set => orig.storeScreenPoint = value;
    }

    public FsmFloat storeScreenX
    {
        get => orig.storeScreenX;
        set => orig.storeScreenX = value;
    }

    public FsmFloat storeScreenY
    {
        get => orig.storeScreenY;
        set => orig.storeScreenY = value;
    }

    public FsmBool normalize
    {
        get => orig.normalize;
        set => orig.normalize = value;
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

    public void DoWorldToScreenPoint()
    {
        CallMethod();
    }
}