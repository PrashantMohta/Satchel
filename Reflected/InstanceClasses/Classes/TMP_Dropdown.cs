namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_Dropdown allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_DropdownR:InstanceClassWrapper<TMPro.TMP_Dropdown>
{
public TMP_DropdownR(TMPro.TMP_Dropdown _orig) : base(_orig) {}
public UnityEngine.RectTransform m_Template
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public TMPro.TMP_Text m_CaptionText
{
get => GetField<TMPro.TMP_Text>();
set => SetField(value);
}

public UnityEngine.UI.Image m_CaptionImage
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public TMPro.TMP_Text m_ItemText
{
get => GetField<TMPro.TMP_Text>();
set => SetField(value);
}

public UnityEngine.UI.Image m_ItemImage
{
get => GetField<UnityEngine.UI.Image>();
set => SetField(value);
}

public int m_Value
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.GameObject m_Dropdown
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject m_Blocker
{
get => GetField<UnityEngine.GameObject>();
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

public UnityEngine.RectTransform template
{
get => orig.template;
set => orig.template = value;
}

public TMPro.TMP_Text captionText
{
get => orig.captionText;
set => orig.captionText = value;
}

public UnityEngine.UI.Image captionImage
{
get => orig.captionImage;
set => orig.captionImage = value;
}

public TMPro.TMP_Text itemText
{
get => orig.itemText;
set => orig.itemText = value;
}

public UnityEngine.UI.Image itemImage
{
get => orig.itemImage;
set => orig.itemImage = value;
}

public System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options
{
get => orig.options;
set => orig.options = value;
}

public int value
{
get => orig.value;
set => orig.value = value;
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

public void RefreshShownValue () =>
orig.RefreshShownValue();

public void AddOptions (System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options) =>
orig.AddOptions(options);

public void AddOptions (System.Collections.Generic.List<System.String> options) =>
orig.AddOptions(options);

public void AddOptions (System.Collections.Generic.List<UnityEngine.Sprite> options) =>
orig.AddOptions(options);

public void ClearOptions () =>
orig.ClearOptions();

public void SetupTemplate () =>
CallMethod();

public T GetOrAddComponent <T>(UnityEngine.GameObject go) =>
CallMethodStatic<T>(new object[] {go});

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public void OnCancel (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnCancel(eventData);

public void Show () =>
orig.Show();

public UnityEngine.GameObject CreateBlocker (UnityEngine.Canvas rootCanvas) =>
CallMethod<UnityEngine.GameObject>(new object[] {rootCanvas});

public void DestroyBlocker (UnityEngine.GameObject blocker) =>
CallMethod(new object[] {blocker});

public UnityEngine.GameObject CreateDropdownList (UnityEngine.GameObject template) =>
CallMethod<UnityEngine.GameObject>(new object[] {template});

public void DestroyDropdownList (UnityEngine.GameObject dropdownList) =>
CallMethod(new object[] {dropdownList});

public void AlphaFadeList (float duration, float alpha) =>
CallMethod(new object[] {duration, alpha});

public void AlphaFadeList (float duration, float start, float end) =>
CallMethod(new object[] {duration, start, end});

public void SetAlpha (float alpha) =>
CallMethod(new object[] {alpha});

public void Hide () =>
orig.Hide();

public System.Collections.IEnumerator DelayedDestroyDropdownList (float delay) =>
CallMethod<System.Collections.IEnumerator>(new object[] {delay});

public void OnSelectItem (UnityEngine.UI.Toggle toggle) =>
CallMethod(new object[] {toggle});

}
}
