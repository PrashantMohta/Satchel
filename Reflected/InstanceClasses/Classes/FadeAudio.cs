namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FadeAudio allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FadeAudioR : InstanceClassWrapper<FadeAudio>
{
    public FadeAudioR(FadeAudio _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat startVolume
    {
        get => orig.startVolume;
        set => orig.startVolume = value;
    }

    public FsmFloat endVolume
    {
        get => orig.endVolume;
        set => orig.endVolume = value;
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public float timeElapsed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float timePercentage
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool fadingDown
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Rigidbody rigidbody => GetProperty<Rigidbody>();

    public Rigidbody2D rigidbody2d => GetProperty<Rigidbody2D>();

    public Renderer renderer => GetProperty<Renderer>();

    public UnityEngine.Animation animation => GetProperty<UnityEngine.Animation>();

    public AudioSource audio => GetProperty<AudioSource>();

    public Camera camera => GetProperty<Camera>();

    public Light light => GetProperty<Light>();

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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoSetAudioVolume()
    {
        CallMethod();
    }
}