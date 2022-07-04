namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIDropDownMenu allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIDropDownMenuR : InstanceClassWrapper<tk2dUIDropDownMenu>
{
    public tk2dUIDropDownMenuR(tk2dUIDropDownMenu _orig) : base(_orig)
    {
    }

    public tk2dUIItem dropDownButton
    {
        get => orig.dropDownButton;
        set => orig.dropDownButton = value;
    }

    public tk2dTextMesh selectedTextMesh
    {
        get => orig.selectedTextMesh;
        set => orig.selectedTextMesh = value;
    }

    public float height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public tk2dUIDropDownItem dropDownItemTemplate
    {
        get => orig.dropDownItemTemplate;
        set => orig.dropDownItemTemplate = value;
    }

    public string[] startingItemList
    {
        get => GetField<string[]>();
        set => SetField(value);
    }

    public int startingIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public List<string> itemList
    {
        get => GetField<List<string>>();
        set => SetField(value);
    }

    public Action OnSelectedItemChange
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public string SendMessageOnSelectedItemChangeMethodName
    {
        get => orig.SendMessageOnSelectedItemChangeMethodName;
        set => orig.SendMessageOnSelectedItemChangeMethodName = value;
    }

    public int index
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public List<tk2dUIDropDownItem> dropDownItems
    {
        get => GetField<List<tk2dUIDropDownItem>>();
        set => SetField(value);
    }

    public bool isExpanded
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public tk2dUILayout menuLayoutItem
    {
        get => GetField<tk2dUILayout>();
        set => SetField(value);
    }

    public tk2dUILayout templateLayoutItem
    {
        get => GetField<tk2dUILayout>();
        set => SetField(value);
    }

    public List<string> ItemList
    {
        get => orig.ItemList;
        set => orig.ItemList = value;
    }

    public int Index
    {
        get => orig.Index;
        set => orig.Index = value;
    }

    public string SelectedItem => orig.SelectedItem;

    public GameObject SendMessageTarget
    {
        get => orig.SendMessageTarget;
        set => orig.SendMessageTarget = value;
    }

    public tk2dUILayout MenuLayoutItem
    {
        get => orig.MenuLayoutItem;
        set => orig.MenuLayoutItem = value;
    }

    public tk2dUILayout TemplateLayoutItem
    {
        get => orig.TemplateLayoutItem;
        set => orig.TemplateLayoutItem = value;
    }


    public void Awake()
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

    public void UpdateList()
    {
        orig.UpdateList();
    }

    public void SetSelectedItem()
    {
        orig.SetSelectedItem();
    }

    public tk2dUIDropDownItem CreateAnotherDropDownItem()
    {
        return CallMethod<tk2dUIDropDownItem>();
    }

    public void ItemSelected(tk2dUIDropDownItem item)
    {
        CallMethod(new object[] { item });
    }

    public void ExpandButtonPressed()
    {
        CallMethod();
    }

    public void ExpandList()
    {
        CallMethod();
    }

    public void CollapseList()
    {
        CallMethod();
    }

    public void DropDownItemHoverBtnToggle(tk2dUIUpDownHoverButton upDownHoverButton)
    {
        CallMethod(new object[] { upDownHoverButton });
    }

    public void OnDestroy()
    {
        CallMethod();
    }
}