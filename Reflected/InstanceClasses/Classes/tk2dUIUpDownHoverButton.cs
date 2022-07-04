namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIUpDownHoverButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIUpDownHoverButtonR:InstanceClassWrapper<tk2dUIUpDownHoverButton>
{
public tk2dUIUpDownHoverButtonR(tk2dUIUpDownHoverButton _orig) : base(_orig) {}
public UnityEngine.GameObject upStateGO
{
get => orig.upStateGO;
set => orig.upStateGO = value;
}

public UnityEngine.GameObject downStateGO
{
get => orig.downStateGO;
set => orig.downStateGO = value;
}

public UnityEngine.GameObject hoverOverStateGO
{
get => orig.hoverOverStateGO;
set => orig.hoverOverStateGO = value;
}

public bool useOnReleaseInsteadOfOnUp
{
get => GetField<bool>();
set => SetField(value);
}

public bool isDown
{
get => GetField<bool>();
set => SetField(value);
}

public bool isHover
{
get => GetField<bool>();
set => SetField(value);
}

public string SendMessageOnToggleOverMethodName
{
get => orig.SendMessageOnToggleOverMethodName;
set => orig.SendMessageOnToggleOverMethodName = value;
}

public System.Action<tk2dUIUpDownHoverButton> OnToggleOver
{
get => GetField<System.Action<tk2dUIUpDownHoverButton>>();
set => SetField(value);
}

public tk2dUIItem uiItem
{
get => orig.uiItem;
set => orig.uiItem = value;
}

public bool UseOnReleaseInsteadOfOnUp
{
get => orig.UseOnReleaseInsteadOfOnUp;
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

public void ButtonUp () =>
CallMethod();

public void ButtonDown () =>
CallMethod();

public void ButtonHoverOver () =>
CallMethod();

public void ButtonHoverOut () =>
CallMethod();

public void SetState () =>
orig.SetState();

public void InternalSetUseOnReleaseInsteadOfOnUp (bool state) =>
orig.InternalSetUseOnReleaseInsteadOfOnUp(state);

}
}
