namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dWatchAnimationEvents allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dWatchAnimationEventsR : InstanceClassWrapper<Tk2dWatchAnimationEvents>
{
    public Tk2dWatchAnimationEventsR(Tk2dWatchAnimationEvents _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmEvent animationTriggerEvent
    {
        get => orig.animationTriggerEvent;
        set => orig.animationTriggerEvent = value;
    }

    public FsmEvent animationCompleteEvent
    {
        get => orig.animationCompleteEvent;
        set => orig.animationCompleteEvent = value;
    }

    public tk2dSpriteAnimator _sprite
    {
        get => GetField<tk2dSpriteAnimator>();
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

    public void _getSprite()
    {
        CallMethod();
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

    public void DoWatchAnimationWithEvents()
    {
        CallMethod();
    }

    public void AnimationEventDelegate(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip, int frameNum)
    {
        CallMethod(new object[] { sprite, clip, frameNum });
    }

    public void AnimationCompleteDelegate(tk2dSpriteAnimator sprite, tk2dSpriteAnimationClip clip)
    {
        CallMethod(new object[] { sprite, clip });
    }
}