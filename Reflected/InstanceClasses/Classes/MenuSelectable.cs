namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuSelectable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuSelectableR:InstanceClassWrapper<UnityEngine.UI.MenuSelectable>
{
public MenuSelectableR(UnityEngine.UI.MenuSelectable _orig) : base(_orig) {}
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

public UnityEngine.Animator selectHighlight
{
get => orig.selectHighlight;
set => orig.selectHighlight = value;
}

public bool playSubmitSound
{
get => orig.playSubmitSound;
set => orig.playSubmitSound = value;
}

public UnityEngine.Animator descriptionText
{
get => orig.descriptionText;
set => orig.descriptionText = value;
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

public MenuButtonList parentList
{
get => GetField<MenuButtonList>();
set => SetField(value);
}

public int m_CurrentIndex
{
get => GetField<int>();
set => SetField(value);
}

public bool DontPlaySelectSound
{
get => orig.DontPlaySelectSound;
set => orig.DontPlaySelectSound = value;
}

public System.Action<UnityEngine.UI.MenuSelectable> customCancelAction
{
get => orig.customCancelAction;
set => orig.customCancelAction = value;
}

public UnityEngine.UI.Navigation navigation
{
get => orig.navigation;
set => orig.navigation = value;
}

public UnityEngine.UI.ColorBlock colors
{
get => orig.colors;
set => orig.colors = value;
}

public UnityEngine.UI.SpriteState spriteState
{
get => orig.spriteState;
set => orig.spriteState = value;
}

public UnityEngine.UI.AnimationTriggers animationTriggers
{
get => orig.animationTriggers;
set => orig.animationTriggers = value;
}

public UnityEngine.UI.Graphic targetGraphic
{
get => orig.targetGraphic;
set => orig.targetGraphic = value;
}

public bool interactable
{
get => orig.interactable;
set => orig.interactable = value;
}

public UnityEngine.UI.Image image
{
get => orig.image;
set => orig.image = value;
}

public UnityEngine.Animator animator
{
get => orig.animator;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void ForceDeselect () =>
orig.ForceDeselect();

public void OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnCancel(eventData);

public System.Collections.IEnumerator ValidateDeselect () =>
CallMethod<System.Collections.IEnumerator>();

public void HookUpAudioPlayer () =>
CallMethod();

public void PlaySubmitSound () =>
CallMethod();

public void PlayCancelSound () =>
CallMethod();

public void PlaySelectSound () =>
CallMethod();

public void orig_OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.orig_OnCancel(eventData);

}
}
