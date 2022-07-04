using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_InputField allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_InputFieldR : InstanceClassWrapper<TMP_InputField>
{
    public TMP_InputFieldR(TMP_InputField _orig) : base(_orig)
    {
    }

    public TouchScreenKeyboard m_Keyboard
    {
        get => GetField<TouchScreenKeyboard>();
        set => SetField(value);
    }

    public char[] kSeparators
    {
        get => GetFieldStatic<char[]>();
        set => SetField(value);
    }

    public RectTransform m_TextViewport
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public TMP_Text m_TextComponent
    {
        get => GetField<TMP_Text>();
        set => SetField(value);
    }

    public RectTransform m_TextComponentRectTransform
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public Graphic m_Placeholder
    {
        get => GetField<Graphic>();
        set => SetField(value);
    }

    public char m_AsteriskChar
    {
        get => GetField<char>();
        set => SetField(value);
    }

    public TouchScreenKeyboardType m_KeyboardType
    {
        get => GetField<TouchScreenKeyboardType>();
        set => SetField(value);
    }

    public bool m_HideMobileInput
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_CharacterLimit
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Color m_CaretColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public bool m_CustomCaretColor
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Color m_SelectionColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public string m_Text
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public float m_CaretBlinkRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int m_CaretWidth
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool m_ReadOnly
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_RichText
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public int m_StringPosition
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_StringSelectPosition
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_CaretPosition
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_CaretSelectPosition
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public RectTransform caretRectTrans
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public UIVertex[] m_CursorVerts
    {
        get => GetField<UIVertex[]>();
        set => SetField(value);
    }

    public CanvasRenderer m_CachedInputRenderer
    {
        get => GetField<CanvasRenderer>();
        set => SetField(value);
    }

    public Mesh m_Mesh
    {
        get => GetField<Mesh>();
        set => SetField(value);
    }

    public bool m_AllowInput
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_HasLostFocus
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_ShouldActivateNextUpdate
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_UpdateDrag
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_DragPositionOutOfBounds
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float kHScrollSpeed
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float kVScrollSpeed
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public bool m_CaretVisible
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Coroutine m_BlinkCoroutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public float m_BlinkStartTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int m_DrawStart
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public int m_DrawEnd
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Coroutine m_DragCoroutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public string m_OriginalText
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool m_WasCanceled
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_HasDoneFocusTransition
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool m_isLastKeyBackspace
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string kEmailSpecialCharacters
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public bool isCaretInsideTag
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Event m_ProcessingEvent
    {
        get => GetField<Event>();
        set => SetField(value);
    }

    public int m_CurrentIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public Mesh mesh => GetProperty<Mesh>();

    public bool shouldHideMobileInput
    {
        get => orig.shouldHideMobileInput;
        set => orig.shouldHideMobileInput = value;
    }

    public string text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public bool isFocused => orig.isFocused;

    public float caretBlinkRate
    {
        get => orig.caretBlinkRate;
        set => orig.caretBlinkRate = value;
    }

    public int caretWidth
    {
        get => orig.caretWidth;
        set => orig.caretWidth = value;
    }

    public RectTransform textViewport
    {
        get => orig.textViewport;
        set => orig.textViewport = value;
    }

    public TMP_Text textComponent
    {
        get => orig.textComponent;
        set => orig.textComponent = value;
    }

    public Graphic placeholder
    {
        get => orig.placeholder;
        set => orig.placeholder = value;
    }

    public Color caretColor
    {
        get => orig.caretColor;
        set => orig.caretColor = value;
    }

    public bool customCaretColor
    {
        get => orig.customCaretColor;
        set => orig.customCaretColor = value;
    }

    public Color selectionColor
    {
        get => orig.selectionColor;
        set => orig.selectionColor = value;
    }

    public int characterLimit
    {
        get => orig.characterLimit;
        set => orig.characterLimit = value;
    }

    public TouchScreenKeyboardType keyboardType
    {
        get => orig.keyboardType;
        set => orig.keyboardType = value;
    }

    public bool readOnly
    {
        get => orig.readOnly;
        set => orig.readOnly = value;
    }

    public bool richText
    {
        get => orig.richText;
        set => orig.richText = value;
    }

    public bool multiLine => orig.multiLine;

    public char asteriskChar
    {
        get => orig.asteriskChar;
        set => orig.asteriskChar = value;
    }

    public bool wasCanceled => orig.wasCanceled;

    public int caretPositionInternal
    {
        get => GetProperty<int>();
        set => SetProperty(value);
    }

    public int stringPositionInternal
    {
        get => GetProperty<int>();
        set => SetProperty(value);
    }

    public int caretSelectPositionInternal
    {
        get => GetProperty<int>();
        set => SetProperty(value);
    }

    public int stringSelectPositionInternal
    {
        get => GetProperty<int>();
        set => SetProperty(value);
    }

    public bool hasSelection => GetProperty<bool>();

    public int caretPosition
    {
        get => orig.caretPosition;
        set => orig.caretPosition = value;
    }

    public int selectionAnchorPosition
    {
        get => orig.selectionAnchorPosition;
        set => orig.selectionAnchorPosition = value;
    }

    public int selectionFocusPosition
    {
        get => orig.selectionFocusPosition;
        set => orig.selectionFocusPosition = value;
    }

    public string clipboard
    {
        get => GetPropertyStatic<string>();
        set => SetPropertyStatic(value);
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


    public void ClampPos(int pos)
    {
        CallMethod(new object[] { pos });
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public IEnumerator CaretBlink()
    {
        return CallMethod<IEnumerator>();
    }

    public void SetCaretVisible()
    {
        CallMethod();
    }

    public void SetCaretActive()
    {
        CallMethod();
    }

    public void OnFocus()
    {
        CallMethod();
    }

    public void SelectAll()
    {
        CallMethod();
    }

    public void MoveTextEnd(bool shift)
    {
        orig.MoveTextEnd(shift);
    }

    public void MoveTextStart(bool shift)
    {
        orig.MoveTextStart(shift);
    }

    public bool InPlaceEditing()
    {
        return CallMethod<bool>();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public int GetCharacterIndexFromPosition(Vector2 pos)
    {
        return CallMethod<int>(new object[] { pos });
    }

    public bool MayDrag(PointerEventData eventData)
    {
        return CallMethod<bool>(new object[] { eventData });
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        orig.OnBeginDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        orig.OnDrag(eventData);
    }

    public IEnumerator MouseDragOutsideRect(PointerEventData eventData)
    {
        return CallMethod<IEnumerator>(new object[] { eventData });
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        orig.OnEndDrag(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        orig.OnPointerDown(eventData);
    }

    public bool IsValidChar(char c)
    {
        return CallMethod<bool>(new object[] { c });
    }

    public void ProcessEvent(Event e)
    {
        orig.ProcessEvent(e);
    }

    public void OnUpdateSelected(BaseEventData eventData)
    {
        orig.OnUpdateSelected(eventData);
    }

    public string GetSelectedString()
    {
        return CallMethod<string>();
    }

    public int FindtNextWordBegin()
    {
        return CallMethod<int>();
    }

    public void MoveRight(bool shift, bool ctrl)
    {
        CallMethod(new object[] { shift, ctrl });
    }

    public int FindtPrevWordBegin()
    {
        return CallMethod<int>();
    }

    public void MoveLeft(bool shift, bool ctrl)
    {
        CallMethod(new object[] { shift, ctrl });
    }

    public int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
    {
        return CallMethod<int>(new object[] { originalPos, goToFirstChar });
    }

    public int LineDownCharacterPosition(int originalPos, bool goToLastChar)
    {
        return CallMethod<int>(new object[] { originalPos, goToLastChar });
    }

    public void MoveDown(bool shift)
    {
        CallMethod(new object[] { shift });
    }

    public void MoveDown(bool shift, bool goToLastChar)
    {
        CallMethod(new object[] { shift, goToLastChar });
    }

    public void MoveUp(bool shift)
    {
        CallMethod(new object[] { shift });
    }

    public void MoveUp(bool shift, bool goToFirstChar)
    {
        CallMethod(new object[] { shift, goToFirstChar });
    }

    public void Delete()
    {
        CallMethod();
    }

    public void ForwardSpace()
    {
        CallMethod();
    }

    public void Backspace()
    {
        CallMethod();
    }

    public void Insert(char c)
    {
        CallMethod(new object[] { c });
    }

    public void SendOnValueChangedAndUpdateLabel()
    {
        CallMethod();
    }

    public void SendOnValueChanged()
    {
        CallMethod();
    }

    public void SendOnSubmit()
    {
        CallMethod();
    }

    public void SendOnFocusLost()
    {
        CallMethod();
    }

    public void Append(string input)
    {
        CallMethod(new object[] { input });
    }

    public void Append(char input)
    {
        CallMethod(new object[] { input });
    }

    public void UpdateLabel()
    {
        CallMethod();
    }

    public int GetCaretPositionFromStringIndex(int stringIndex)
    {
        return CallMethod<int>(new object[] { stringIndex });
    }

    public int GetStringIndexFromCaretPosition(int caretPosition)
    {
        return CallMethod<int>(new object[] { caretPosition });
    }

    public void ForceLabelUpdate()
    {
        orig.ForceLabelUpdate();
    }

    public void MarkGeometryAsDirty()
    {
        CallMethod();
    }

    public void Rebuild(CanvasUpdate update)
    {
        orig.Rebuild(update);
    }

    public void LayoutComplete()
    {
        orig.LayoutComplete();
    }

    public void GraphicUpdateComplete()
    {
        orig.GraphicUpdateComplete();
    }

    public void UpdateGeometry()
    {
        CallMethod();
    }

    public void AssignPositioningIfNeeded()
    {
        CallMethod();
    }

    public void OnFillVBO(Mesh vbo)
    {
        CallMethod(new object[] { vbo });
    }

    public void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
    {
        CallMethod(new object[] { vbo, roundingOffset });
    }

    public void CreateCursorVerts()
    {
        CallMethod();
    }

    public void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
    {
        CallMethod(new object[] { vbo, roundingOffset });
    }

    public void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
    {
        CallMethod(new object[] { startPosition, height, isCharVisible });
    }

    public char Validate(string text, int pos, char ch)
    {
        return CallMethod<char>(new object[] { text, pos, ch });
    }

    public void ActivateInputField()
    {
        orig.ActivateInputField();
    }

    public void ActivateInputFieldInternal()
    {
        CallMethod();
    }

    public void OnSelect(BaseEventData eventData)
    {
        orig.OnSelect(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }

    public void DeactivateInputField()
    {
        orig.DeactivateInputField();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        orig.OnDeselect(eventData);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void EnforceContentType()
    {
        CallMethod();
    }

    public void SetTextComponentWrapMode()
    {
        CallMethod();
    }

    public void SetTextComponentRichTextMode()
    {
        CallMethod();
    }

    public void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes)
    {
        CallMethod(new object[] { allowedContentTypes });
    }

    public void SetToCustom()
    {
        CallMethod();
    }
}