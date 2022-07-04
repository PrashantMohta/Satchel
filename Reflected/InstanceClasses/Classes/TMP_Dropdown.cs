using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Dropdown allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_DropdownR : InstanceClassWrapper<TMP_Dropdown>
{
    public TMP_DropdownR(TMP_Dropdown _orig) : base(_orig)
    {
    }

    public RectTransform m_Template
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public TMP_Text m_CaptionText
    {
        get => GetField<TMP_Text>();
        set => SetField(value);
    }

    public Image m_CaptionImage
    {
        get => GetField<Image>();
        set => SetField(value);
    }

    public TMP_Text m_ItemText
    {
        get => GetField<TMP_Text>();
        set => SetField(value);
    }

    public Image m_ItemImage
    {
        get => GetField<Image>();
        set => SetField(value);
    }

    public int m_Value
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public GameObject m_Dropdown
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject m_Blocker
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }


    public bool validTemplate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_CurrentIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public RectTransform template
    {
        get => orig.template;
        set => orig.template = value;
    }

    public TMP_Text captionText
    {
        get => orig.captionText;
        set => orig.captionText = value;
    }

    public Image captionImage
    {
        get => orig.captionImage;
        set => orig.captionImage = value;
    }

    public TMP_Text itemText
    {
        get => orig.itemText;
        set => orig.itemText = value;
    }

    public Image itemImage
    {
        get => orig.itemImage;
        set => orig.itemImage = value;
    }

    public List<TMP_Dropdown.OptionData> options
    {
        get => orig.options;
        set => orig.options = value;
    }

    public int value
    {
        get => orig.value;
        set => orig.value = value;
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

    public void RefreshShownValue()
    {
        orig.RefreshShownValue();
    }

    public void AddOptions(List<TMP_Dropdown.OptionData> options)
    {
        orig.AddOptions(options);
    }

    public void AddOptions(List<string> options)
    {
        orig.AddOptions(options);
    }

    public void AddOptions(List<Sprite> options)
    {
        orig.AddOptions(options);
    }

    public void ClearOptions()
    {
        orig.ClearOptions();
    }

    public void SetupTemplate()
    {
        CallMethod();
    }

    public T GetOrAddComponent<T>(GameObject go)
    {
        return CallMethodStatic<T>(new object[] { go });
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public void Show()
    {
        orig.Show();
    }

    public GameObject CreateBlocker(Canvas rootCanvas)
    {
        return CallMethod<GameObject>(new object[] { rootCanvas });
    }

    public void DestroyBlocker(GameObject blocker)
    {
        CallMethod(new object[] { blocker });
    }

    public GameObject CreateDropdownList(GameObject template)
    {
        return CallMethod<GameObject>(new object[] { template });
    }

    public void DestroyDropdownList(GameObject dropdownList)
    {
        CallMethod(new object[] { dropdownList });
    }

    public void AlphaFadeList(float duration, float alpha)
    {
        CallMethod(new object[] { duration, alpha });
    }

    public void AlphaFadeList(float duration, float start, float end)
    {
        CallMethod(new object[] { duration, start, end });
    }

    public void SetAlpha(float alpha)
    {
        CallMethod(new object[] { alpha });
    }

    public void Hide()
    {
        orig.Hide();
    }

    public IEnumerator DelayedDestroyDropdownList(float delay)
    {
        return CallMethod<IEnumerator>(new object[] { delay });
    }

    public void OnSelectItem(Toggle toggle)
    {
        CallMethod(new object[] { toggle });
    }
}