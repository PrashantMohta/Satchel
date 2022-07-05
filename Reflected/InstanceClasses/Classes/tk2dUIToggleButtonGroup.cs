namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIToggleButtonGroup allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIToggleButtonGroupR : InstanceClassWrapper<tk2dUIToggleButtonGroup>
{
    public tk2dUIToggleButtonGroupR(tk2dUIToggleButtonGroup _orig) : base(_orig)
    {
    }

    public tk2dUIToggleButton[] toggleBtns
    {
        get => GetField<tk2dUIToggleButton[]>();
        set => SetField(value);
    }

    public GameObject sendMessageTarget
    {
        get => orig.sendMessageTarget;
        set => orig.sendMessageTarget = value;
    }

    public int selectedIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public tk2dUIToggleButton selectedToggleButton
    {
        get => GetField<tk2dUIToggleButton>();
        set => SetField(value);
    }

    public Action<tk2dUIToggleButtonGroup> OnChange
    {
        get => GetField<Action<tk2dUIToggleButtonGroup>>();
        set => SetField(value);
    }

    public string SendMessageOnChangeMethodName
    {
        get => orig.SendMessageOnChangeMethodName;
        set => orig.SendMessageOnChangeMethodName = value;
    }

    public tk2dUIToggleButton[] ToggleBtns => orig.ToggleBtns;

    public int SelectedIndex
    {
        get => orig.SelectedIndex;
        set => orig.SelectedIndex = value;
    }

    public tk2dUIToggleButton SelectedToggleButton
    {
        get => orig.SelectedToggleButton;
        set => orig.SelectedToggleButton = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Setup()
    {
        CallMethod();
    }

    public void AddNewToggleButtons(tk2dUIToggleButton[] newToggleBtns)
    {
        orig.AddNewToggleButtons(newToggleBtns);
    }

    public void ClearExistingToggleBtns()
    {
        CallMethod();
    }

    public void SetToggleButtonUsingSelectedIndex()
    {
        CallMethod();
    }

    public void ButtonToggle(tk2dUIToggleButton toggleButton)
    {
        CallMethod(new object[] { toggleButton });
    }

    public void SetSelectedIndexFromSelectedToggleButton()
    {
        CallMethod();
    }
}