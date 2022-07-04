namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIToggleButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIToggleButtonR : InstanceClassWrapper<tk2dUIToggleButton>
{
    public tk2dUIToggleButtonR(tk2dUIToggleButton _orig) : base(_orig)
    {
    }

    public GameObject offStateGO
    {
        get => orig.offStateGO;
        set => orig.offStateGO = value;
    }

    public GameObject onStateGO
    {
        get => orig.onStateGO;
        set => orig.onStateGO = value;
    }

    public bool activateOnPress
    {
        get => orig.activateOnPress;
        set => orig.activateOnPress = value;
    }

    public bool isOn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isInToggleGroup
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Action<tk2dUIToggleButton> OnToggle
    {
        get => GetField<Action<tk2dUIToggleButton>>();
        set => SetField(value);
    }

    public string SendMessageOnToggleMethodName
    {
        get => orig.SendMessageOnToggleMethodName;
        set => orig.SendMessageOnToggleMethodName = value;
    }

    public tk2dUIItem uiItem
    {
        get => orig.uiItem;
        set => orig.uiItem = value;
    }

    public bool IsOn
    {
        get => orig.IsOn;
        set => orig.IsOn = value;
    }

    public bool IsInToggleGroup
    {
        get => orig.IsInToggleGroup;
        set => orig.IsInToggleGroup = value;
    }

    public GameObject SendMessageTarget
    {
        get => orig.SendMessageTarget;
        set => orig.SendMessageTarget = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void ButtonClick()
    {
        CallMethod();
    }

    public void ButtonDown()
    {
        CallMethod();
    }

    public void ButtonToggle()
    {
        CallMethod();
    }

    public void SetState()
    {
        CallMethod();
    }
}