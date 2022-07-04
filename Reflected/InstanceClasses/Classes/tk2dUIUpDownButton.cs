namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIUpDownButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIUpDownButtonR:InstanceClassWrapper<tk2dUIUpDownButton>
{
public tk2dUIUpDownButtonR(tk2dUIUpDownButton _orig) : base(_orig) {}
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

public tk2dUIItem uiItem
{
get => orig.uiItem;
set => orig.uiItem = value;
}

public bool UseOnReleaseInsteadOfOnUp
{
get => orig.UseOnReleaseInsteadOfOnUp;
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

public void SetState () =>
CallMethod();

public void InternalSetUseOnReleaseInsteadOfOnUp (bool state) =>
orig.InternalSetUseOnReleaseInsteadOfOnUp(state);

}
}
