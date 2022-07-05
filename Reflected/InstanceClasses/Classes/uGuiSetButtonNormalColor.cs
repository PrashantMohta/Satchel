using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiSetButtonNormalColor allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiSetButtonNormalColorR : InstanceClassWrapper<uGuiSetButtonNormalColor>
{
    public uGuiSetButtonNormalColorR(uGuiSetButtonNormalColor _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmColor normalColor
    {
        get => orig.normalColor;
        set => orig.normalColor = value;
    }

    public bool resetOnExit
    {
        get => orig.resetOnExit;
        set => orig.resetOnExit = value;
    }

    public FsmBool enabled
    {
        get => orig.enabled;
        set => orig.enabled = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Button _Button
    {
        get => GetField<Button>();
        set => SetField(value);
    }

    public Color _OriginalNormalColor
    {
        get => GetField<Color>();
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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void Initialize(GameObject go)
    {
        CallMethod(new object[] { go });
    }

    public void DoSetButtonColor()
    {
        CallMethod();
    }

    public void DoSetOldColorValue()
    {
        CallMethod();
    }
}