namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AudioPlayerOneShotSingle allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioPlayerOneShotSingleR : InstanceClassWrapper<AudioPlayerOneShotSingle>
{
    public AudioPlayerOneShotSingleR(AudioPlayerOneShotSingle _orig) : base(_orig)
    {
    }

    public FsmGameObject audioPlayer
    {
        get => orig.audioPlayer;
        set => orig.audioPlayer = value;
    }

    public FsmGameObject spawnPoint
    {
        get => orig.spawnPoint;
        set => orig.spawnPoint = value;
    }

    public FsmObject audioClip
    {
        get => orig.audioClip;
        set => orig.audioClip = value;
    }

    public FsmFloat pitchMin
    {
        get => orig.pitchMin;
        set => orig.pitchMin = value;
    }

    public FsmFloat pitchMax
    {
        get => orig.pitchMax;
        set => orig.pitchMax = value;
    }

    public FsmFloat volume
    {
        get => orig.volume;
        set => orig.volume = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public FsmGameObject storePlayer
    {
        get => orig.storePlayer;
        set => orig.storePlayer = value;
    }

    public AudioSource audio
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public float timer
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoPlayRandomClip()
    {
        CallMethod();
    }
}