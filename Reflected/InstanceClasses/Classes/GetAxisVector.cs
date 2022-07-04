namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetAxisVector allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAxisVectorR : InstanceClassWrapper<GetAxisVector>
{
    public GetAxisVectorR(GetAxisVector _orig) : base(_orig)
    {
    }

    public FsmString horizontalAxis
    {
        get => orig.horizontalAxis;
        set => orig.horizontalAxis = value;
    }

    public FsmString verticalAxis
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