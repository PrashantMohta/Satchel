namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of StopAnimatorsAtPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StopAnimatorsAtPointR : InstanceClassWrapper<StopAnimatorsAtPoint>
{
    public StopAnimatorsAtPointR(StopAnimatorsAtPoint _orig) : base(_orig)
    {
    }

    public EventRegister stopEvent
    {
        get => orig.stopEvent;
        set => orig.stopEvent = value;
    }

    public EventRegister stopInstantEvent
    {
        get => orig.stopInstantEvent;
        set => orig.stopInstantEvent = value;
    }

    public bool canStop
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool shouldStop
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float stopInstantHeight
    {
        get => orig.stopInstantHeight;
        set => orig.stopInstantHeight = value;
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void SetCanStop()
    {
        orig.SetCanStop();
    }

    public void SetCannotStop()
    {
        orig.SetCannotStop();
    }

    public void Update()
    {
        CallMethod();
    }
}