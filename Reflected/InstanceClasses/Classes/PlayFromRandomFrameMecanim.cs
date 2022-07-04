namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayFromRandomFrameMecanim allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayFromRandomFrameMecanimR : InstanceClassWrapper<PlayFromRandomFrameMecanim>
{
    public PlayFromRandomFrameMecanimR(PlayFromRandomFrameMecanim _orig) : base(_orig)
    {
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public string stateToPlay
    {
        get => orig.stateToPlay;
        set => orig.stateToPlay = value;
    }

    public bool onEnable
    {
        get => orig.onEnable;
        set => orig.onEnable = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void DoPlay()
    {
        CallMethod();
    }

    public IEnumerator DelayStart()
    {
        return CallMethod<IEnumerator>();
    }
}