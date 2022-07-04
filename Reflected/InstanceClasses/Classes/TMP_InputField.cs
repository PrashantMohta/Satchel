namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_InputField allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_InputFieldR:InstanceClassWrapper<TMPro.TMP_InputField>
{
public TMP_InputFieldR(TMPro.TMP_InputField _orig) : base(_orig) {}
public UnityEngine.TouchScreenKeyboard m_Keyboard
{
get => GetField<UnityEngine.TouchScreenKeyboard>();
set => SetField(value);
}

public System.Char[] kSeparators
{
get => GetFieldStatic<System.Char[]>();
set => SetField(value);
}

public UnityEngine.RectTransform m_TextViewport
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public TMPro.TMP_Text m_TextComponent
{
get => GetField<TMPro.TMP_Text>();
set => SetField(value);
}

public UnityEngine.RectTransform m_TextComponentRectTransform
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.UI.Graphic m_Placeholder
{
get => GetField<UnityEngine.UI.Graphic>();
set => SetField(value);
}

public System.Char m_AsteriskChar
{
get => GetField<System.Char>();
set => SetField(value);
}

public UnityEngine.TouchScreenKeyboardType m_KeyboardType
{
get => GetField<UnityEngine.TouchScreenKeyboardType>();
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

public UnityEngine.Color m_CaretColor
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public bool m_CustomCaretColor
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Color m_SelectionColor
{
get => GetField<UnityEngine.Color>();
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

public UnityEngine.RectTransform caretRectTrans
{
get => GetField<UnityEngine.RectTransform>();
set => SetField(value);
}

public UnityEngine.UIVertex[] m_CursorVerts
{
get => GetField<UnityEngine.UIVertex[]>();
set => SetField(value);
}

public UnityEngine.CanvasRenderer m_CachedInputRenderer
{
get => GetField<UnityEngine.CanvasRenderer>();
set => SetField(value);
}

public UnityEngine.Mesh m_Mesh
{
get => GetField<UnityEngine.Mesh>();
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

public UnityEngine.Coroutine m_BlinkCoroutine
{
get => GetField<UnityEngine.Coroutine>();
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

public UnityEngine.Coroutine m_DragCoroutine
{
get => GetField<UnityEngine.Coroutine>();
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

public UnityEngine.Event m_ProcessingEvent
{
get => GetField<UnityEngine.Event>();
set => SetField(value);
}

public int m_CurrentIndex
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.Mesh mesh
{
get => GetProperty<UnityEngine.Mesh>();
}

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

public bool isFocused
{
get => orig.isFocused;
}

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

public UnityEngine.RectTransform textViewport
{
get => orig.textViewport;
set => orig.textViewport = value;
}

public TMPro.TMP_Text textComponent
{
get => orig.textComponent;
set => orig.textComponent = value;
}

public UnityEngine.UI.Graphic placeholder
{
get => orig.placeholder;
set => orig.placeholder = value;
}

public UnityEngine.Color caretColor
{
get => orig.caretColor;
set => orig.caretColor = value;
}

public bool customCaretColor
{
get => orig.customCaretColor;
set => orig.customCaretColor = value;
}

public UnityEngine.Color selectionColor
{
get => orig.selectionColor;
set => orig.selectionColor = value;
}

public int characterLimit
{
get => orig.characterLimit;
set => orig.characterLimit = value;
}

public UnityEngine.TouchScreenKeyboardType keyboardType
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

public bool multiLine
{
get => orig.multiLine;
}

public System.Char asteriskChar
{
get => orig.asteriskChar;
set => orig.asteriskChar = value;
}

public bool wasCanceled
{
get => orig.wasCanceled;
}

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

public bool hasSelection
{
get => GetProperty<bool>();
}

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



public void ClampPos (int pos) =>
CallMethod(new object[] {pos});

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator CaretBlink () =>
CallMethod<System.Collections.IEnumerator>();

public void SetCaretVisible () =>
CallMethod();

public void SetCaretActive () =>
CallMethod();

public void OnFocus () =>
CallMethod();

public void SelectAll () =>
CallMethod();

public void MoveTextEnd (bool shift) =>
orig.MoveTextEnd(shift);

public void MoveTextStart (bool shift) =>
orig.MoveTextStart(shift);

public bool InPlaceEditing () =>
CallMethod<bool>();

public void LateUpdate () =>
CallMethod();

public int GetCharacterIndexFromPosition (UnityEngine.Vector2 pos) =>
CallMethod<int>(new object[] {pos});

public bool MayDrag (UnityEngine.EventSystems.PointerEventData eventData) =>
CallMethod<bool>(new object[] {eventData});

public void OnBeginDrag (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnBeginDrag(eventData);

public void OnDrag (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnDrag(eventData);

public System.Collections.IEnumerator MouseDragOutsideRect (UnityEngine.EventSystems.PointerEventData eventData) =>
CallMethod<System.Collections.IEnumerator>(new object[] {eventData});

public void OnEndDrag (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnEndDrag(eventData);

public void OnPointerDown (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerDown(eventData);

public bool IsValidChar (System.Char c) =>
CallMethod<bool>(new object[] {c});

public void ProcessEvent (UnityEngine.Event e) =>
orig.ProcessEvent(e);

public void OnUpdateSelected (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnUpdateSelected(eventData);

public string GetSelectedString () =>
CallMethod<string>();

public int FindtNextWordBegin () =>
CallMethod<int>();

public void MoveRight (bool shift, bool ctrl) =>
CallMethod(new object[] {shift, ctrl});

public int FindtPrevWordBegin () =>
CallMethod<int>();

public void MoveLeft (bool shift, bool ctrl) =>
CallMethod(new object[] {shift, ctrl});

public int LineUpCharacterPosition (int originalPos, bool goToFirstChar) =>
CallMethod<int>(new object[] {originalPos, goToFirstChar});

public int LineDownCharacterPosition (int originalPos, bool goToLastChar) =>
CallMethod<int>(new object[] {originalPos, goToLastChar});

public void MoveDown (bool shift) =>
CallMethod(new object[] {shift});

public void MoveDown (bool shift, bool goToLastChar) =>
CallMethod(new object[] {shift, goToLastChar});

public void MoveUp (bool shift) =>
CallMethod(new object[] {shift});

public void MoveUp (bool shift, bool goToFirstChar) =>
CallMethod(new object[] {shift, goToFirstChar});

public void Delete () =>
CallMethod();

public void ForwardSpace () =>
CallMethod();

public void Backspace () =>
CallMethod();

public void Insert (System.Char c) =>
CallMethod(new object[] {c});

public void SendOnValueChangedAndUpdateLabel () =>
CallMethod();

public void SendOnValueChanged () =>
CallMethod();

public void SendOnSubmit () =>
CallMethod();

public void SendOnFocusLost () =>
CallMethod();

public void Append (string input) =>
CallMethod(new object[] {input});

public void Append (System.Char input) =>
CallMethod(new object[] {input});

public void UpdateLabel () =>
CallMethod();

public int GetCaretPositionFromStringIndex (int stringIndex) =>
CallMethod<int>(new object[] {stringIndex});

public int GetStringIndexFromCaretPosition (int caretPosition) =>
CallMethod<int>(new object[] {caretPosition});

public void ForceLabelUpdate () =>
orig.ForceLabelUpdate();

public void MarkGeometryAsDirty () =>
CallMethod();

public void Rebuild (UnityEngine.UI.CanvasUpdate update) =>
orig.Rebuild(update);

public void LayoutComplete () =>
orig.LayoutComplete();

public void GraphicUpdateComplete () =>
orig.GraphicUpdateComplete();

public void UpdateGeometry () =>
CallMethod();

public void AssignPositioningIfNeeded () =>
CallMethod();

public void OnFillVBO (UnityEngine.Mesh vbo) =>
CallMethod(new object[] {vbo});

public void GenerateCaret (UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) =>
CallMethod(new object[] {vbo, roundingOffset});

public void CreateCursorVerts () =>
CallMethod();

public void GenerateHightlight (UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset) =>
CallMethod(new object[] {vbo, roundingOffset});

public void AdjustRectTransformRelativeToViewport (UnityEngine.Vector2 startPosition, float height, bool isCharVisible) =>
CallMethod(new object[] {startPosition, height, isCharVisible});

public System.Char Validate (string text, int pos, System.Char ch) =>
CallMethod<System.Char>(new object[] {text, pos, ch});

public void ActivateInputField () =>
orig.ActivateInputField();

public void ActivateInputFieldInternal () =>
CallMethod();

public void OnSelect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSelect(eventData);

public void OnPointerClick (UnityEngine.EventSystems.PointerEventData eventData) =>
orig.OnPointerClick(eventData);

public void DeactivateInputField () =>
orig.DeactivateInputField();

public void OnDeselect (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnDeselect(eventData);

public void OnSubmit (UnityEngine.EventSystems.BaseEventData eventData) =>
orig.OnSubmit(eventData);

public void EnforceContentType () =>
CallMethod();

public void SetTextComponentWrapMode () =>
CallMethod();

public void SetTextComponentRichTextMode () =>
CallMethod();

public void SetToCustomIfContentTypeIsNot (TMPro.TMP_InputField.ContentType[] allowedContentTypes) =>
CallMethod(new object[] {allowedContentTypes});

public void SetToCustom () =>
CallMethod();
}
}
