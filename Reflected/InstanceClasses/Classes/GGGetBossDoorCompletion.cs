namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GGGetBossDoorCompletion allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GGGetBossDoorCompletionR : InstanceClassWrapper<GGGetBossDoorCompletion>
{
    public GGGetBossDoorCompletionR(GGGetBossDoorCompletion _orig) : base(_orig)
    {
    }

    public FsmString playerDataVariable
    {
        get => orig.playerDataVariable;
        set => orig.playerDataVariable = value;
    }

    public FsmBool unlocked
    {
        get => orig.unlocked;
        set => orig.unlocked = value;
    }

    public FsmBool completed
    {
        get => orig.completed;
        set => orig.completed = value;
    }

    public FsmBool allBindings
    {
        get => orig.allBindings;
        set => orig.allBindings = value;
    }

    public FsmBool noHits
    {
        get => orig.noHits;
        set => orig.noHits = value;
    }

    public FsmBool boundNail
    {
        get => orig.boundNail;
        set => orig.boundNail = value;
    }

    public FsmBool boundShell
    {
        get => orig.boundShell;
        set => orig.boundShell = value;
    }

    public FsmBool boundCharms
    {
        get => orig.boundCharms;
        set => orig.boundCharms = value;
    }

    public FsmBool boundSoul
    {
        get => orig.boundSoul;
        set => orig.boundSoul = value;
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