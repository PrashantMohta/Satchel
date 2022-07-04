namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListGetClosestGameObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListGetClosestGameObjectR : InstanceClassWrapper<ArrayListGetClosestGameObject>
{
    public ArrayListGetClosestGameObjectR(ArrayListGetClosestGameObject _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString reference
    {
        get => orig.reference;
        set => orig.reference = value;
    }

    public FsmGameObject distanceFrom
    {
        get => orig.distanceFrom;
        set => orig.distanceFrom = value;
    }

    public FsmVector3 orDistanceFromVector3
    {
        get => orig.orDistanceFromVector3;
        set => orig.orDistanceFromVector3 = value;
    }

    public bool everyframe
    {
        get => orig.everyframe;
        set => orig.everyframe = value;
    }

    public FsmGameObject closestGameObject
    {
        get => orig.closestGameObject;
        set => orig.closestGameObject = value;
    }

    public FsmInt closestIndex
    {
        get => orig.closestIndex;
        set => orig.closestIndex = value;
    }

    public PlayMakerArrayListProxy proxy
    {
        get => GetField<PlayMakerArrayListProxy>();
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

    public void DoFindClosestGo()
    {
        CallMethod();
    }
}