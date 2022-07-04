namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ListenForMenuActions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ListenForMenuActionsR : InstanceClassWrapper<ListenForMenuActions>
{
    public ListenForMenuActionsR(ListenForMenuActions _orig) : base(_orig)
    {
    }

    public FsmEventTarget eventTarget
    {
        get => orig.eventTarget;
        set => orig.eventTarget = value;
    }

    public FsmEvent submitPressed
    {
        get => orig.submitPressed;
        set => orig.submitPressed = value;
    }

    public FsmEvent cancelPressed
    {
        get => orig.cancelPressed;
        set => orig.cancelPressed = value;
    }

    public FsmBool ignoreAttack
    {
        get => orig.ignoreAttack;
        set => orig.ignoreAttack = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public InputHandler inputHandler
    {
        get => GetField<InputHandler>();
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
}