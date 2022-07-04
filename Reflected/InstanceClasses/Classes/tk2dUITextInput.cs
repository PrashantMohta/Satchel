namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUITextInput allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUITextInputR:InstanceClassWrapper<tk2dUITextInput>
{
public tk2dUITextInputR(tk2dUITextInput _orig) : base(_orig) {}
public tk2dUIItem selectionBtn
{
get => orig.selectionBtn;
set => orig.selectionBtn = value;
}

public tk2dTextMesh inputLabel
{
get => orig.inputLabel;
set => orig.inputLabel = value;
}

public tk2dTextMesh emptyDisplayLabel
{
get => orig.emptyDisplayLabel;
set => orig.emptyDisplayLabel = value;
}

public UnityEngine.GameObject unSelectedStateGO
{
get => orig.unSelectedStateGO;
set => orig.unSelectedStateGO = value;
}

public UnityEngine.GameObject selectedStateGO
{
get => orig.selectedStateGO;
set => orig.selectedStateGO = value;
}

public UnityEngine.GameObject cursor
{
get => orig.cursor;
set => orig.cursor = value;
}

public float fieldLength
{
get => orig.fieldLength;
set => orig.fieldLength = value;
}

public int maxCharacterLength
{
get => orig.maxCharacterLength;
set => orig.maxCharacterLength = value;
}

public string emptyDisplayText
{
get => orig.emptyDisplayText;
set => orig.emptyDisplayText = value;
}

public bool isPasswordField
{
get => orig.isPasswordField;
set => orig.isPasswordField = value;
}

public string passwordChar
{
get => orig.passwordChar;
set => orig.passwordChar = value;
}

public tk2dUILayout layoutItem
{
get => GetField<tk2dUILayout>();
set => SetField(value);
}

public bool isSelected
{
get => GetField<bool>();
set => SetField(value);
}

public bool wasStartedCalled
{
get => GetField<bool>();
set => SetField(value);
}

public bool wasOnAnyPressEventAttached
{
get => GetField<bool>();
set => SetField(value);
}

public bool listenForKeyboardText
{
get => GetField<bool>();
set => SetField(value);
}

public bool isDisplayTextShown
{
get => GetField<bool>();
set => SetField(value);
}

public System.Action<tk2dUITextInput> OnTextChange
{
get => orig.OnTextChange;
set => orig.OnTextChange = value;
}

public string SendMessageOnTextChangeMethodName
{
get => orig.SendMessageOnTextChangeMethodName;
set => orig.SendMessageOnTextChangeMethodName = value;
}

public string text
{
get => GetField<string>();
set => SetField(value);
}

public tk2dUILayout LayoutItem
{
get => orig.LayoutItem;
set => orig.LayoutItem = value;
}

public UnityEngine.GameObject SendMessageTarget
{
get => orig.SendMessageTarget;
set => orig.SendMessageTarget = value;
}

public bool IsFocus
{
get => orig.IsFocus;
}

public string Text
{
get => orig.Text;
set => orig.Text = value;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void SetFocus () =>
orig.SetFocus();

public void SetFocus (bool focus) =>
orig.SetFocus(focus);

public void FormatTextForDisplay (string modifiedText) =>
CallMethod(new object[] {modifiedText});

public void ListenForKeyboardTextUpdate () =>
CallMethod();

public void InputSelected () =>
CallMethod();

public void InputDeselected () =>
CallMethod();

public void AnyPress () =>
CallMethod();

public void SetState () =>
CallMethod();

public void SetCursorPosition () =>
CallMethod();

public void ShowDisplayText () =>
CallMethod();

public void HideDisplayText () =>
CallMethod();

public void LayoutReshaped (UnityEngine.Vector3 dMin, UnityEngine.Vector3 dMax) =>
CallMethod(new object[] {dMin, dMax});

}
}
