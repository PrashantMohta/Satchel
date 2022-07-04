namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MappableKey allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MappableKeyR:InstanceClassWrapper<MappableKey>
{
public MappableKeyR(MappableKey _orig) : base(_orig) {}
public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public InputHandler ih
{
get => GetField<InputHandler>();
set => SetField(value);
}

public UIManager ui
{
get => GetField<UIManager>();
set => SetField(value);
}

public UIButtonSkins uibs
{
get => GetField<UIButtonSkins>();
set => SetField(value);
}

public GameSettings gs
{
get => GetField<GameSettings>();
set => SetField(value);
}

public InControl.PlayerAction playerAction
{
get => GetField<InControl.PlayerAction>();
set => SetField(value);
}

public bool active
{
get => GetField<bool>();
set => SetField(value);
}

public bool isListening
{
get => GetField<bool>();
set => SetField(value);
}

public bool changePending
{
get => GetField<bool>();
set => SetField(value);
}

public int oldFontSize
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.TextAnchor oldAlignment
{
get => GetField<UnityEngine.TextAnchor>();
set => SetField(value);
}

public UnityEngine.Sprite oldSprite
{
get => GetField<UnityEngine.Sprite>();
set => SetField(value);
}

public string oldText
{
get => GetField<string>();
set => SetField(value);
}

public System.Collections.Generic.List<InControl.KeyBindingSource> unmappableKeys
{
get => GetField<System.Collections.Generic.List<InControl.KeyBindingSource>>();
set => SetField(value);
}

public float sqrX
{
get => GetField<float>();
set => SetField(value);
}

public float sqrWidth
{
get => GetField<float>();
set => SetField(value);
}

public bool sqrBestFit
{
get => GetField<bool>();
set => SetField(value);
}

public int sqrFontSize
{
get => GetField<int>();
set => SetField(value);
}

public int sqrMinFont
{
get => GetField<int>();
set => SetField(value);
}

public int sqrMaxFont
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.HorizontalWrapMode sqrHOverflow
{
get => GetField<UnityEngine.HorizontalWrapMode>();
set => SetField(value);
}

public UnityEngine.TextAnchor sqrAlignment
{
get => GetField<UnityEngine.TextAnchor>();
set => SetField(value);
}

public float wideX
{
get => GetField<float>();
set => SetField(value);
}

public float wideWidth
{
get => GetField<float>();
set => SetField(value);
}

public bool wideBestFit
{
get => GetField<bool>();
set => SetField(value);
}

public int wideFontSize
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.HorizontalWrapMode wideHOverflow
{
get => GetField<UnityEngine.HorizontalWrapMode>();
set => SetField(value);
}

public UnityEngine.TextAnchor wideAlignment
{
get => GetField<UnityEngine.TextAnchor>();
set => SetField(value);
}

public float blankX
{
get => GetField<float>();
set => SetField(value);
}

public float blankWidth
{
get => GetField<float>();
set => SetField(value);
}

public bool blankBestFit
{
get => GetField<bool>();
set => SetField(value);
}

public int blankFontSize
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.HorizontalWrapMode blankOverflow
{
get => GetField<UnityEngine.HorizontalWrapMode>();
set => SetField(value);
}

public UnityEngine.TextAnchor blankAlignment
{
get => GetField<UnityEngine.TextAnchor>();
set => SetField(value);
}

public GlobalEnums.HeroActionButton actionButtonType
{
get => orig.actionButtonType;
set => orig.actionButtonType = value;
}

public UnityEngine.UI.Text keymapText
{
get => orig.keymapText;
set => orig.keymapText = value;
}

public UnityEngine.UI.Image keymapSprite
{
get => orig.keymapSprite;
set => orig.keymapSprite = value;
}

public InControl.PlayerActionSet actionSet
{
get => orig.actionSet;
set => orig.actionSet = value;
}

public UnityEngine.Animator flashEffect
{
get => orig.flashEffect;
set => orig.flashEffect = value;
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

public System.Action<UnityEngine.UI.MenuButton> submitAction
{
get => orig.submitAction;
set => orig.submitAction = value;
}

public bool proceed
{
get => orig.proceed;
set => orig.proceed = value;
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



public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void GetBinding () =>
orig.GetBinding();

public void ListenForNewButton () =>
orig.ListenForNewButton();

public void ShowCurrentBinding () =>
orig.ShowCurrentBinding();

public void AbortRebind () =>
orig.AbortRebind();

public void StopActionListening () =>
orig.StopActionListening();

public bool OnBindingFound (InControl.PlayerAction action, InControl.BindingSource binding) =>
orig.OnBindingFound(action, binding);

public void OnBindingAdded (InControl.PlayerAction action, InControl.BindingSource binding) =>
orig.OnBindingAdded(action, binding);

public void OnBindingRejected (InControl.PlayerAction action, InControl.BindingSource binding, InControl.BindingSourceRejectionType rejection) =>
orig.OnBindingRejected(action, binding, rejection);

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public void OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnCancel(eventData);

public void StopListeningForNewKey () =>
CallMethod();

public void SetupUnmappableKeys () =>
CallMethod();

public void SetupBindingListenOptions () =>
CallMethod();

public void SetupRefs () =>
CallMethod();

public void InitCustomActions (InControl.PlayerActionSet actionSet, InControl.PlayerAction playerAction) =>
orig.InitCustomActions(actionSet, playerAction);

public void OnDestroy () =>
CallMethod();

public void orig_GetBinding () =>
orig.orig_GetBinding();

public void orig_SetupBindingListenOptions () =>
CallMethod();

public void orig_SetupRefs () =>
CallMethod();

}
}
