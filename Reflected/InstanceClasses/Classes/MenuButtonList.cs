using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonListR : InstanceClassWrapper<MenuButtonList>
{
    public MenuButtonListR(MenuButtonList _orig) : base(_orig)
    {
    }

    public bool isTopLevelMenu
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool skipDisabled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public MenuSelectable lastSelected
    {
        get => GetField<MenuSelectable>();
        set => SetField(value);
    }

    public List<Selectable> activeSelectables
    {
        get => GetField<List<Selectable>>();
        set => SetField(value);
    }

    public List<MenuButtonList> menuButtonLists
    {
        get => GetFieldStatic<List<MenuButtonList>>();
        set => SetField(value);
    }

    public bool started
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void DoSelect()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public IEnumerator SelectDelayed(Selectable selectable)
    {
        return CallMethod<IEnumerator>(new object[] { selectable });
    }

    public void ClearLastSelected()
    {
        orig.ClearLastSelected();
    }

    public void ClearAllLastSelected()
    {
        MenuButtonList.ClearAllLastSelected();
    }

    public void AddSelectable(Selectable sel)
    {
        orig.AddSelectable(sel);
    }

    public void AddSelectableEnd(Selectable sel, int controlButtons)
    {
        orig.AddSelectableEnd(sel, controlButtons);
    }

    public void AddSelectable(Selectable sel, int index)
    {
        orig.AddSelectable(sel, index);
    }

    public void ClearSelectables()
    {
        orig.ClearSelectables();
    }

    public void RecalculateNavigation()
    {
        orig.RecalculateNavigation();
    }
}