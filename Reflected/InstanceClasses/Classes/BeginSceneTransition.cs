namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BeginSceneTransition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BeginSceneTransitionR : InstanceClassWrapper<BeginSceneTransition>
{
    public BeginSceneTransitionR(BeginSceneTransition _orig) : base(_orig)
    {
    }

    public FsmString sceneName
    {
        get => orig.sceneName;
        set => orig.sceneName = value;
    }

    public FsmString entryGateName
    {
        get => orig.entryGateName;
        set => orig.entryGateName = value;
    }

    public FsmFloat entryDelay
    {
        get => orig.entryDelay;
        set => orig.entryDelay = value;
    }

    public FsmEnum visualization
    {
        get => orig.visualization;
        set => orig.visualization = value;
    }

    public bool preventCameraFadeOut
    {
        get => orig.preventCameraFadeOut;
        set => orig.preventCameraFadeOut = value;
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