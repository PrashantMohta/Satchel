namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerProfileButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerProfileButtonR:InstanceClassWrapper<UnityEngine.UI.ControllerProfileButton>
{
public ControllerProfileButtonR(UnityEngine.UI.ControllerProfileButton _orig) : base(_orig) {}
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

public UnityEngine.UI.Image highlightCursor
{
get => orig.highlightCursor;
set => orig.highlightCursor = value;
}

public MenuAudioController uiAudioPlayer
{
get => orig.uiAudioPlayer;
set => orig.uiAudioPlayer = value;
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



public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public System.Collections.IEnumerator ValidateDeselect () =>
CallMethod<System.Collections.IEnumerator>();

}
}
