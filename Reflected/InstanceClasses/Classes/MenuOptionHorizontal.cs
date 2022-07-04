namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuOptionHorizontal allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuOptionHorizontalR:InstanceClassWrapper<UnityEngine.UI.MenuOptionHorizontal>
{
public MenuOptionHorizontalR(UnityEngine.UI.MenuOptionHorizontal _orig) : base(_orig) {}
public UnityEngine.UI.Text optionText
{
get => orig.optionText;
set => orig.optionText = value;
}

public System.String[] optionList
{
get => orig.optionList;
set => orig.optionList = value;
}

public int selectedOptionIndex
{
get => orig.selectedOptionIndex;
set => orig.selectedOptionIndex = value;
}

public MenuSetting menuSetting
{
get => orig.menuSetting;
set => orig.menuSetting = value;
}

public bool localizeText
{
get => orig.localizeText;
set => orig.localizeText = value;
}

public string sheetTitle
{
get => orig.sheetTitle;
set => orig.sheetTitle = value;
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

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

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void OnMove (UnityEngine.EventSystems.AxisEventData move) =>
orig.OnMove(move);

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public bool MoveOption (UnityEngine.EventSystems.MoveDirection dir) =>
CallMethod<bool>(new object[] {dir});

public void PointerClickCheckArrows (UnityEngine.EventSystems.PointerEventData eventData) =>
CallMethod(new object[] {eventData});

public bool IsInside (UnityEngine.GameObject obj, UnityEngine.EventSystems.PointerEventData eventData) =>
CallMethod<bool>(new object[] {obj, eventData});

public void SetOptionList (System.String[] optionList) =>
orig.SetOptionList(optionList);

public string GetSelectedOptionText () =>
orig.GetSelectedOptionText();

public string GetSelectedOptionTextRaw () =>
orig.GetSelectedOptionTextRaw();

public void SetOptionTo (int optionNumber) =>
orig.SetOptionTo(optionNumber);

public void UpdateText () =>
CallMethod();

public void UpdateSetting () =>
CallMethod();

public void DecrementOption () =>
CallMethod();

public void IncrementOption () =>
CallMethod();

}
}
