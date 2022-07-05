namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetEventProperties allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetEventPropertiesR : InstanceClassWrapper<SetEventProperties>
{
    public SetEventPropertiesR(SetEventProperties _orig) : base(_orig)
    {
    }

    public FsmString[] keys
    {
        get => orig.keys;
        set => orig.keys = value;
    }

    public FsmVar[] datas
    {
        get => orig.datas;
        set => orig.datas = value;
    }

    public Dictionary<string, object> properties
    {
        get => SetEventProperties.properties;
        set => SetEventProperties.properties = value;
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