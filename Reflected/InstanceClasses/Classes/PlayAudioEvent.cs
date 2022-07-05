namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayAudioEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayAudioEventR : InstanceClassWrapper<PlayAudioEvent>
{
    public PlayAudioEventR(PlayAudioEvent _orig) : base(_orig)
    {
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

    public FsmObject audioPlayerPrefab
    {
        get => orig.audioPlayerPrefab;
        set => orig.audioPlayerPrefab = value;
    }

    public FsmOwnerDefault spawnPoint
    {
        get => orig.spawnPoint;
        set => orig.spawnPoint = value;
    }

    public FsmVector3 spawnPosition
    {
        get => orig.spawnPosition;
        set => orig.spawnPosition = value;
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