namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuPreventDeselect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuPreventDeselectR:InstanceClassWrapper<UnityEngine.UI.MenuPreventDeselect>
{
public MenuPreventDeselectR(UnityEngine.UI.MenuPreventDeselect _orig) : base(_orig) {}
public GlobalEnums.CancelAction cancelAction
{
get => orig.cancelAction;
set => orig.cancelAction = value;
}

public UnityEngine.Animator leftCursor
{
get => orig.leftCursor;
set => orig.leftCursor = value;
}

public UnityEngine.Animator rightCursor
{
get => orig.rightCursor;
set => orig.rightCursor = value;
}

public MenuAudioController uiAudioPlayer
{
get => GetField<MenuAudioController>();
set => SetField(value);
}

public UnityEngine.GameObject prevSelectedObject
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public bool dontPlaySelectSound
{
get => GetField<bool>();
set => SetField(value);
}

public bool deselectWasForced
{
get => GetField<bool>();
set => SetField(value);
}

public System.Action<UnityEngine.UI.MenuPreventDeselect> customCancelAction
{
get => orig.customCancelAction;
set => orig.customCancelAction = value;
}



public void Start () =>
CallMethod();

public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnCancel(eventData);

public System.Collections.IEnumerator ValidateDeselect () =>
CallMethod<System.Collections.IEnumerator>();

public void HookUpAudioPlayer () =>
CallMethod();

public void ForceDeselect () =>
orig.ForceDeselect();

public void SimulateSubmit () =>
orig.SimulateSubmit();

public void orig_OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.orig_OnCancel(eventData);

}
}
