namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutToolbar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutToolbarR : InstanceClassWrapper<GUILayoutToolbar>
{
    public GUILayoutToolbarR(GUILayoutToolbar _orig) : base(_orig)
    {
    }

    public FsmInt numButtons
    {
        get => orig.numButtons;
        set => orig.numButtons = value;
    }

    public FsmInt selectedButton
    {
        get => orig.selectedButton;
        set => orig.selectedButton = value;
    }

    public FsmEvent[] buttonEventsArray
    {
        get => orig.buttonEventsArray;
        set => orig.buttonEventsArray = value;
    }

    public FsmTexture[] imagesArray
    {
        get => orig.imagesArray;
        set => orig.imagesArray = value;
    }

    public FsmString[] textsArray
    {
        get => orig.textsArray;
        set => orig.textsArray = value;
    }

    public FsmString[] tooltipsArray
    {
        get => orig.tooltipsArray;
        set => orig.tooltipsArray = value;
    }

    public FsmString style
    {
        get => orig.style;
        set => orig.style = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public GUIContent[] contents
    {
        get => GetField<GUIContent[]>();
        set => SetField(value);
    }

    public LayoutOption[] layoutOptions
    {
        get => orig.layoutOptions;
        set => orig.layoutOptions = value;
    }

    public GUIContent[] Contents => orig.Contents;

    public GUILayoutOption[] LayoutOptions => orig.LayoutOptions;

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

    public void SetButtonsContent()
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

    public void OnGUI()
    {
        orig.OnGUI();
    }

    public string ErrorCheck()
    {
        return orig.ErrorCheck();
    }
}