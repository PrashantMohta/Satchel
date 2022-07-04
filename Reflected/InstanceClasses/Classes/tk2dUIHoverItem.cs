namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIHoverItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIHoverItemR:InstanceClassWrapper<tk2dUIHoverItem>
{
public tk2dUIHoverItemR(tk2dUIHoverItem _orig) : base(_orig) {}
public UnityEngine.GameObject outStateGO
{
get => orig.outStateGO;
set => orig.outStateGO = value;
}

public UnityEngine.GameObject overStateGO
{
get => orig.overStateGO;
set => orig.overStateGO = value;
}

public bool isOver
{
get => GetField<bool>();
set => SetField(value);
}

public System.Action<tk2dUIHoverItem> OnToggleHover
{
get => GetField<System.Action<tk2dUIHoverItem>>();
set => SetField(value);
}

public string SendMessageOnToggleHoverMethodName
{
get => orig.SendMessageOnToggleHoverMethodName;
set => orig.SendMessageOnToggleHoverMethodName = value;
}

public tk2dUIItem uiItem
{
get => orig.uiItem;
set => orig.uiItem = value;
}

public bool IsOver
{
get => orig.IsOver;
set => orig.IsOver = value;
}

public UnityEngine.GameObject SendMessageTarget
{
get => orig.SendMessageTarget;
set => orig.SendMessageTarget = value;
}



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void HoverOver () =>
CallMethod();

public void HoverOut () =>
CallMethod();

public void SetState () =>
orig.SetState();

}
}
