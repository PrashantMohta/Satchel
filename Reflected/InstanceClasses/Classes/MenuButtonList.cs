namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonListR:InstanceClassWrapper<MenuButtonList>
{
public MenuButtonListR(MenuButtonList _orig) : base(_orig) {}

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

public UnityEngine.UI.MenuSelectable lastSelected
{
get => GetField<UnityEngine.UI.MenuSelectable>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.UI.Selectable> activeSelectables
{
get => GetField<System.Collections.Generic.List<UnityEngine.UI.Selectable>>();
set => SetField(value);
}

public System.Collections.Generic.List<MenuButtonList> menuButtonLists
{
get => GetFieldStatic<System.Collections.Generic.List<MenuButtonList>>();
set => SetField(value);
}

public bool started
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void DoSelect () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public System.Collections.IEnumerator SelectDelayed (UnityEngine.UI.Selectable selectable) =>
CallMethod<System.Collections.IEnumerator>(new object[] {selectable});

public void ClearLastSelected () =>
orig.ClearLastSelected();

public void ClearAllLastSelected () =>
MenuButtonList.ClearAllLastSelected();

public void AddSelectable (UnityEngine.UI.Selectable sel) =>
orig.AddSelectable(sel);

public void AddSelectableEnd (UnityEngine.UI.Selectable sel, int controlButtons) =>
orig.AddSelectableEnd(sel, controlButtons);

public void AddSelectable (UnityEngine.UI.Selectable sel, int index) =>
orig.AddSelectable(sel, index);

public void ClearSelectables () =>
orig.ClearSelectables();

public void RecalculateNavigation () =>
orig.RecalculateNavigation();

}
}
