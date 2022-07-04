namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIDropDownItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIDropDownItemR:InstanceClassWrapper<tk2dUIDropDownItem>
{
public tk2dUIDropDownItemR(tk2dUIDropDownItem _orig) : base(_orig) {}
public tk2dTextMesh label
{
get => orig.label;
set => orig.label = value;
}

public float height
{
get => orig.height;
set => orig.height = value;
}

public tk2dUIUpDownHoverButton upDownHoverBtn
{
get => orig.upDownHoverBtn;
set => orig.upDownHoverBtn = value;
}

public int index
{
get => GetField<int>();
set => SetField(value);
}

public System.Action<tk2dUIDropDownItem> OnItemSelected
{
get => GetField<System.Action<tk2dUIDropDownItem>>();
set => SetField(value);
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

public string LabelText
{
get => orig.LabelText;
set => orig.LabelText = value;
}

public UnityEngine.GameObject SendMessageTarget
{
get => orig.SendMessageTarget;
set => orig.SendMessageTarget = value;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void ItemSelected () =>
CallMethod();

}
}
