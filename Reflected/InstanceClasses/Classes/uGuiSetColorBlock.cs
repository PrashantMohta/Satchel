using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiSetColorBlock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiSetColorBlockR : InstanceClassWrapper<uGuiSetColorBlock>
{
    public uGuiSetColorBlockR(uGuiSetColorBlock _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat fadeDuration
    {
        get => orig.fadeDuration;
        set => orig.fadeDuration = value;
    }

    public FsmFloat colorMultiplier
    {
        get => orig.colorMultiplier;
        set => orig.colorMultiplier = value;
    }

    public FsmColor normalColor
    {
        get => orig.normalColor;
        set => orig.normalColor = value;
    }

    public FsmColor pressedColor
    {
        get => orig.pressedColor;
        set => orig.pressedColor = value;
    }

    public FsmColor highlightedColor
    {
        get => orig.highlightedColor;
        set => orig.highlightedColor = value;
    }

    public FsmColor disabledColor
    {
        get => orig.disabledColor;
        set => orig.disabledColor = value;
    }

    public FsmBool resetOnExit
    {
        get => orig.resetOnExit;
        set => orig.resetOnExit = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Selectable _selectable
    {
        get => GetField<Selectable>();
        set => SetField(value);
    }

    public ColorBlock _colorBlock
    {
        get => GetField<ColorBlock>();
        set => SetField(value);
    }

    public ColorBlock _originalColorBlock
    {
        get => GetField<ColorBlock>();
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

    public void DoSetValue()
    {
        CallMethod();
    }

    public void OnExit()
    {
        orig.OnExit();
    }
}