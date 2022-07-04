namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerAnimatorStateSynchronization allowing
///     you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerAnimatorStateSynchronizationR : InstanceClassWrapper<PlayMakerAnimatorStateSynchronization>
{
    public PlayMakerAnimatorStateSynchronizationR(PlayMakerAnimatorStateSynchronization _orig) : base(_orig)
    {
    }

    public int LayerIndex
    {
        get => orig.LayerIndex;
        set => orig.LayerIndex = value;
    }

    public PlayMakerFSM Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public bool EveryFrame
    {
        get => orig.EveryFrame;
        set => orig.EveryFrame = value;
    }

    public bool debug
    {
        get => orig.debug;
        set => orig.debug = value;
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public int lastState
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int lastTransition
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Dictionary<int, FsmState> fsmStateLUT
    {
        get => GetField<Dictionary<int, FsmState>>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void RegisterHash(string key, FsmState state)
    {
        CallMethod(new object[] { key, state });
    }

    public void Update()
    {
        CallMethod();
    }

    public void Synchronize()
    {
        orig.Synchronize();
    }

    public void SwitchState(Fsm fsm, FsmState state)
    {
        CallMethod(new object[] { fsm, state });
    }
}