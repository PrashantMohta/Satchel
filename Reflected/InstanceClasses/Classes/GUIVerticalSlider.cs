namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GUIVerticalSlider allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUIVerticalSliderR : InstanceClassWrapper<GUIVerticalSlider>
{
    public GUIVerticalSliderR(GUIVerticalSlider _orig) : base(_orig)
    {
    }

    public FsmFloat floatVariable
    {
        get => orig.floatVariable;
        set => orig.floatVariable = value;
    }

    public FsmFloat topValue
    {
        get => orig.topValue;
        set => orig.topValue = value;
    }

    public FsmFloat bottomValue
    {
        get => orig.bottomValue;
        set => orig.bottomValue = value;
    }

    public FsmString sliderStyle
    {
        get => orig.sliderStyle;
        set => orig.sliderStyle = value;
    }

    public FsmString thumbStyle
    {
        get => orig.thumbStyle;
        set => orig.thumbStyle = value;
    }

    public FsmRect screenRect
    {
        get => orig.screenRect;
        set => orig.screenRect = value;
    }

    public FsmFloat left
    {
        get => orig.left;
        set => orig.left = value;
    }

    public FsmFloat top
    {
        get => orig.top;
        set => orig.top = value;
    }

    public FsmFloat width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmBool normalized
    {
        get => orig.normalized;
        set => orig.normalized = value;
    }

    public Rect rect
    {
        get => GetField<Rect>();
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

    public void OnGUI()
    {
        orig.OnGUI();
    }
}