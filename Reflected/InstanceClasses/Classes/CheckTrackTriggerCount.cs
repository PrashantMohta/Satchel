namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CheckTrackTriggerCount allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckTrackTriggerCountR : InstanceClassWrapper<CheckTrackTriggerCount>
{
    public CheckTrackTriggerCountR(CheckTrackTriggerCount _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmInt count
    {
        get => orig.count;
        set => orig.count = value;
    }

    public FsmEnum test
    {
        get => orig.test;
        set => orig.test = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public FsmEvent successEvent
    {
        get => orig.successEvent;
        set => orig.successEvent = value;
    }

    public TrackTriggerObjects track
    {
        get => GetField<TrackTriggerObjects>();
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public bool CheckCount()
    {
        return orig.CheckCount();
    }
}