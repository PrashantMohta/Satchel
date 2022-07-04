namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SelectRandomVector3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SelectRandomVector3R : InstanceClassWrapper<SelectRandomVector3>
{
    public SelectRandomVector3R(SelectRandomVector3 _orig) : base(_orig)
    {
    }

    public FsmVector3[] vector3Array
    {
        get => orig.vector3Array;
        set => orig.vector3Array = value;
    }

    public FsmFloat[] weights
    {
        get => orig.weights;
        set => orig.weights = value;
    }

    public FsmVector3 storeVector3
    {
        get => orig.storeVector3;
        set => orig.storeVector3 = value;
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

    public void DoSelectRandomColor()
    {
        CallMethod();
    }
}