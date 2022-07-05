namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DistanceBetweenPoints allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DistanceBetweenPointsR : InstanceClassWrapper<DistanceBetweenPoints>
{
    public DistanceBetweenPointsR(DistanceBetweenPoints _orig) : base(_orig)
    {
    }

    public FsmFloat distanceResult
    {
        get => orig.distanceResult;
        set => orig.distanceResult = value;
    }

    public FsmVector3 point1
    {
        get => orig.point1;
        set => orig.point1 = value;
    }

    public FsmVector3 point2
    {
        get => orig.point2;
        set => orig.point2 = value;
    }

    public bool ignoreZ
    {
        get => orig.ignoreZ;
        set => orig.ignoreZ = value;
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

    public void DoCalcDistance()
    {
        CallMethod();
    }
}