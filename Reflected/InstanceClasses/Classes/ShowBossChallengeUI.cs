namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShowBossChallengeUI allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShowBossChallengeUIR : InstanceClassWrapper<ShowBossChallengeUI>
{
    public ShowBossChallengeUIR(ShowBossChallengeUI _orig) : base(_orig)
    {
    }

    public GameObject spawnedUI
    {
        get => GetFieldStatic<GameObject>();
        set => SetField(value);
    }

    public FsmGameObject prefab
    {
        get => orig.prefab;
        set => orig.prefab = value;
    }

    public FsmString bossNameSheet
    {
        get => orig.bossNameSheet;
        set => orig.bossNameSheet = value;
    }

    public FsmString bossNameKey
    {
        get => orig.bossNameKey;
        set => orig.bossNameKey = value;
    }

    public FsmString descriptionSheet
    {
        get => orig.descriptionSheet;
        set => orig.descriptionSheet = value;
    }

    public FsmString descriptionKey
    {
        get => orig.descriptionKey;
        set => orig.descriptionKey = value;
    }

    public FsmEvent levelSelectedEvent
    {
        get => orig.levelSelectedEvent;
        set => orig.levelSelectedEvent = value;
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