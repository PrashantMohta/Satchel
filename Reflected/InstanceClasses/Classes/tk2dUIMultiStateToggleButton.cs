namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIMultiStateToggleButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIMultiStateToggleButtonR : InstanceClassWrapper<tk2dUIMultiStateToggleButton>
{
    public tk2dUIMultiStateToggleButtonR(tk2dUIMultiStateToggleButton _orig) : base(_orig)
    {
    }

    public GameObject[] states
    {
        get => orig.states;
        set => orig.states = value;
    }

    public bool activateOnPress
    {
        get => orig.activateOnPress;
        set => orig.activateOnPress = value;
    }

    public Action<tk2dUIMultiStateToggleButton> OnStateToggle
    {
        get => GetField<Action<tk2dUIMultiStateToggleButton>>();
        set => SetField(value);
    }

    public int index
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public string SendMessageOnStateToggleMethodName
    {
        get => orig.SendMessageOnStateToggleMethodName;
        set => orig.SendMessageOnStateToggleMethodName = value;
    }

    public tk2dUIItem uiItem
    {
        get => orig.uiItem;
        set => orig.uiItem = value;
    }

    public int Index
    {
        get => orig.Index;
        set => orig.Index = value;
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