namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayVibration allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayVibrationR : InstanceClassWrapper<PlayVibration>
{
    public PlayVibrationR(PlayVibration _orig) : base(_orig)
    {
    }

    public FsmEnum lowFidelityVibration
    {
        get => orig.lowFidelityVibration;
        set => orig.lowFidelityVibration = value;
    }

    public FsmObject highFidelityVibration
    {
        get => orig.highFidelityVibration;
        set => orig.highFidelityVibration = value;
    }

    public FsmEnum motors
    {
        get => orig.motors;
        set => orig.motors = value;
    }

    public FsmFloat loopTime
    {
        get => orig.loopTime;
        set => orig.loopTime = value;
    }

    public FsmBool isLooping
    {
        get => orig.isLooping;
        set => orig.isLooping = value;
    }

    public FsmString tag
    {
        get => orig.tag;
        set => orig.tag = value;
    }

    public FsmObject gamepadVibration
    {
        get => orig.gamepadVibration;
        set => orig.gamepadVibration = value;
    }

    public float cooldownTimer
    {
        get => GetField<float>();
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

    public void Play(bool loop)
    {
        CallMethod(new object[] { loop });
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void EnqueueNextLoop()
    {
        CallMethod();
    }
}