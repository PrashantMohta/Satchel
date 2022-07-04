using InControl;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MappableControllerButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MappableControllerButtonR : InstanceClassWrapper<MappableControllerButton>
{
    public MappableControllerButtonR(MappableControllerButton _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

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

    public PlayerAction playerAction
    {
        get => GetField<PlayerAction>();
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

    public InputControlType currentBinding
    {
        get => GetField<InputControlType>();
        set => SetField(value);
    }

    public List<DeviceBindingSource> unmappableButtons
    {
        get => GetField<List<DeviceBindingSource>>();
        set => SetField(value);
    }

    public HeroActionButton actionButtonType
    {
        get => orig.actionButtonType;
        set => orig.actionButtonType = value;
    }

    public Text buttonmapText
    {
        get => orig.buttonmapText;
        set => orig.buttonmapText = value;
    }

    public Image buttonmapSprite
    {
        get => orig.buttonmapSprite;
        set => orig.buttonmapSprite = value;
    }

    public Throbber listeningThrobber
    {
        get => orig.listeningThrobber;
        set => orig.listeningThrobber = value;
    }

    public PlayerActionSet actionSet
    {
        get => orig.actionSet;
        set => orig.actionSet = value;
    }

    public Animator flashEffect
    {
        get => orig.flashEffect;
        set => orig.flashEffect = value;
    }

    public CancelAction cancelAction
    {
        get => orig.cancelAction;
        set => orig.cancelAction = value;
    }

    public Animator leftCursor
    {
        get => orig.leftCursor;
        set => orig.leftCursor = value;
    }

    public Animator rightCursor
    {
        get => orig.rightCursor;
        set => orig.rightCursor = value;
    }

    public Animator selectHighlight
    {
        get => orig.selectHighlight;
        set => orig.selectHighlight = value;
    }

    public bool playSubmitSound
    {
        get => orig.playSubmitSound;
        set => orig.playSubmitSound = value;
    }

    public Animator descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public MenuAudioController uiAudioPlayer
    {
        get => GetField<MenuAudioController>();
        set => SetField(value);
    }

    public GameObject prevSelectedObject
    {
        get => GetField<GameObject>();
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

    public Action<MenuButton> submitAction
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

    public Action<MenuSelectable> customCancelAction
    {
        get => orig.customCancelAction;
        set => orig.customCancelAction = value;
    }

    public Navigation navigation
    {
        get => orig.navigation;
        set => orig.navigation = value;
    }

    public ColorBlock colors
    {
        get => orig.colors;
        set => orig.colors = value;
    }

    public SpriteState spriteState
    {
        get => orig.spriteState;
        set => orig.spriteState = value;
    }

    public AnimationTriggers animationTriggers
    {
        get => orig.animationTriggers;
        set => orig.animationTriggers = value;
    }

    public Graphic targetGraphic
    {
        get => orig.targetGraphic;
        set => orig.targetGraphic = value;
    }

    public bool interactable
    {
        get => orig.interactable;
        set => orig.interactable = value;
    }

    public Image image
    {
        get => orig.image;
        set => orig.image = value;
    }

    public Animator animator => orig.animator;


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void GetBinding()
    {
        CallMethod();
    }

    public void ListenForNewButton()
    {
        orig.ListenForNewButton();
    }

    public void ShowCurrentBinding()
    {
        orig.ShowCurrentBinding();
    }

    public void AbortRebind()
    {
        orig.AbortRebind();
    }

    public void StopActionListening()
    {
        orig.StopActionListening();
    }

    public bool OnBindingFound(PlayerAction action, BindingSource binding)
    {
        return orig.OnBindingFound(action, binding);
    }

    public void OnBindingAdded(PlayerAction action, BindingSource binding)
    {
        orig.OnBindingAdded(action, binding);
    }

    public void OnBindingRejected(PlayerAction action, BindingSource binding, BindingSourceRejectionType rejection)
    {
        orig.OnBindingRejected(action, binding, rejection);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public void StopListeningForNewButton()
    {
        CallMethod();
    }

    public void SetupUnmappableButtons()
    {
        CallMethod();
    }

    public void SetupBindingListenOptions()
    {
        CallMethod();
    }

    public void SetupRefs()
    {
        CallMethod();
    }

    public void orig_SetupUnmappableButtons()
    {
        CallMethod();
    }

    public void InitCustomActions(PlayerActionSet actionSet, PlayerAction playerAction)
    {
        orig.InitCustomActions(actionSet, playerAction);
    }

    public void OnDestroy()
    {
        CallMethod();
    }

    public void GetBindingPublic()
    {
        orig.GetBindingPublic();
    }

    public void orig_GetBinding()
    {
        CallMethod();
    }

    public void orig_SetupBindingListenOptions()
    {
        CallMethod();
    }

    public void orig_ShowCurrentBinding()
    {
        orig.orig_ShowCurrentBinding();
    }

    public void orig_SetupRefs()
    {
        CallMethod();
    }
}