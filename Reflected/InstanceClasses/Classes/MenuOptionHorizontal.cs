using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuOptionHorizontal allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuOptionHorizontalR : InstanceClassWrapper<MenuOptionHorizontal>
{
    public MenuOptionHorizontalR(MenuOptionHorizontal _orig) : base(_orig)
    {
    }

    public Text optionText
    {
        get => orig.optionText;
        set => orig.optionText = value;
    }

    public string[] optionList
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

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnMove(AxisEventData move)
    {
        orig.OnMove(move);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public bool MoveOption(MoveDirection dir)
    {
        return CallMethod<bool>(new object[] { dir });
    }

    public void PointerClickCheckArrows(PointerEventData eventData)
    {
        CallMethod(new object[] { eventData });
    }

    public bool IsInside(GameObject obj, PointerEventData eventData)
    {
        return CallMethod<bool>(new object[] { obj, eventData });
    }

    public void SetOptionList(string[] optionList)
    {
        orig.SetOptionList(optionList);
    }

    public string GetSelectedOptionText()
    {
        return orig.GetSelectedOptionText();
    }

    public string GetSelectedOptionTextRaw()
    {
        return orig.GetSelectedOptionTextRaw();
    }

    public void SetOptionTo(int optionNumber)
    {
        orig.SetOptionTo(optionNumber);
    }

    public void UpdateText()
    {
        CallMethod();
    }

    public void UpdateSetting()
    {
        CallMethod();
    }

    public void DecrementOption()
    {
        CallMethod();
    }

    public void IncrementOption()
    {
        CallMethod();
    }
}