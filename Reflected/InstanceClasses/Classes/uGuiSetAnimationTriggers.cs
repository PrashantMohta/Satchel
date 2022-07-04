using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiSetAnimationTriggers allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiSetAnimationTriggersR : InstanceClassWrapper<uGuiSetAnimationTriggers>
{
    public uGuiSetAnimationTriggersR(uGuiSetAnimationTriggers _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString normalTrigger
    {
        get => orig.normalTrigger;
        set => orig.normalTrigger = value;
    }

    public FsmString highlightedTrigger
    {
        get => orig.highlightedTrigger;
        set => orig.highlightedTrigger = value;
    }

    public FsmString pressedTrigger
    {
        get => orig.pressedTrigger;
        set => orig.pressedTrigger = value;
    }

    public FsmString disabledTrigger
    {
        get => orig.disabledTrigger;
        set => orig.disabledTrigger = value;
    }

    public FsmBool resetOnExit
    {
        get => orig.resetOnExit;
        set => orig.resetOnExit = value;
    }

    public Selectable _selectable
    {
        get => GetField<Selectable>();
        set => SetField(value);
    }

    public AnimationTriggers _animationTriggers
    {
        get => GetField<AnimationTriggers>();
        set => SetField(value);
    }

    public AnimationTriggers _originalAnimationTriggers
    {
        get => GetField<AnimationTriggers>();
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

    public void DoSetValue()
    {
        CallMethod();
    }

    public void OnExit()
    {
        orig.OnExit();
    }
}