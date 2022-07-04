namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Vector3Lerp allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector3LerpR : InstanceClassWrapper<Vector3Lerp>
{
    public Vector3LerpR(Vector3Lerp _orig) : base(_orig)
    {
    }

    public FsmVector3 fromVector
    {
        get => orig.fromVector;
        set => orig.fromVector = value;
    }

    public FsmVector3 toVector
    {
        get => orig.toVector;
        set => orig.toVector = value;
    }

    public FsmFloat amount
    {
        get => orig.amount;
        set => orig.amount = value;
    }

    public FsmVector3 storeResult
    {
        get => orig.storeResult;
        set => orig.storeResult = value;
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

    public void DoVector3Lerp()
    {
        CallMethod();
    }
}