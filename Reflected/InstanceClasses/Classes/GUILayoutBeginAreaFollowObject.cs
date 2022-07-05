namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutBeginAreaFollowObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutBeginAreaFollowObjectR : InstanceClassWrapper<GUILayoutBeginAreaFollowObject>
{
    public GUILayoutBeginAreaFollowObjectR(GUILayoutBeginAreaFollowObject _orig) : base(_orig)
    {
    }

    public FsmGameObject gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat offsetLeft
    {
        get => orig.offsetLeft;
        set => orig.offsetLeft = value;
    }

    public FsmFloat offsetTop
    {
        get => orig.offsetTop;
        set => orig.offsetTop = value;
    }

    public FsmFloat width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmBool normalized
    {
        get => orig.normalized;
        set => orig.normalized = value;
    }

    public FsmString style
    {
        get => orig.style;
        set => orig.style = value;
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

    public void OnGUI()
    {
        orig.OnGUI();
    }

    public void DummyBeginArea()
    {
        CallMethodStatic();
    }
}