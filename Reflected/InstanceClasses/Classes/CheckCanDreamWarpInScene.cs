namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CheckCanDreamWarpInScene allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckCanDreamWarpInSceneR : InstanceClassWrapper<CheckCanDreamWarpInScene>
{
    public CheckCanDreamWarpInSceneR(CheckCanDreamWarpInScene _orig) : base(_orig)
    {
    }

    public Func<bool> bossRushCheck
    {
        get => GetFieldStatic<Func<bool>>();
        set => SetField(value);
    }

    public Dictionary<string, Func<bool>> sceneCheckFunctions
    {
        get => GetField<Dictionary<string, Func<bool>>>();
        set => SetField(value);
    }

    public FsmEvent trueEvent
    {
        get => orig.trueEvent;
        set => orig.trueEvent = value;
    }

    public FsmEvent falseEvent
    {
        get => orig.falseEvent;
        set => orig.falseEvent = value;
    }

    public bool IsTrue => orig.IsTrue;

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
}