using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuSelectable allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuSelectableR : InstanceClassWrapper<MenuSelectable>
{
    public MenuSelectableR(MenuSelectable _orig) : base(_orig)
    {
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


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void ForceDeselect()
    {
        orig.ForceDeselect();
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public IEnumerator ValidateDeselect()
    {
        return CallMethod<IEnumerator>();
    }

    public void HookUpAudioPlayer()
    {
        CallMethod();
    }

    public void PlaySubmitSound()
    {
        CallMethod();
    }

    public void PlayCancelSound()
    {
        CallMethod();
    }

    public void PlaySelectSound()
    {
        CallMethod();
    }

    public void orig_OnCancel(BaseEventData eventData)
    {
        orig.orig_OnCancel(eventData);
    }
}