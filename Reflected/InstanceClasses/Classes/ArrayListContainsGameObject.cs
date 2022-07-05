namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ArrayListContainsGameObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ArrayListContainsGameObjectR : InstanceClassWrapper<ArrayListContainsGameObject>
{
    public ArrayListContainsGameObjectR(ArrayListContainsGameObject _orig) : base(_orig)
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

    public FsmString gameObjectName
    {
        get => orig.gameObjectName;
        set => orig.gameObjectName = value;
    }

    public FsmString withTag
    {
        get => orig.withTag;
        set => orig.withTag = value;
    }

    public FsmGameObject result
    {
        get => orig.result;
        set => orig.result = value;
    }

    public FsmInt resultIndex
    {
        get => orig.resultIndex;
        set => orig.resultIndex = value;
    }

    public FsmBool isContained
    {
        get => orig.isContained;
        set => orig.isContained = value;
    }

    public FsmEvent isContainedEvent
    {
        get => orig.isContainedEvent;
        set => orig.isContainedEvent = value;
    }

    public FsmEvent isNotContainedEvent
    {
        get => orig.isNotContainedEvent;
        set => orig.isNotContainedEvent = value;
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

    public int DoContainsGo()
    {
        return CallMethod<int>();
    }
}