namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiComponentProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiComponentProxyR:InstanceClassWrapper<PlayMakerUGuiComponentProxy>
{
public PlayMakerUGuiComponentProxyR(PlayMakerUGuiComponentProxy _orig) : base(_orig) {}
public bool debug
{
get => orig.debug;
set => orig.debug = value;
}

public string error
{
get => GetField<string>();
set => SetField(value);
}

public HutongGames.PlayMaker.OwnerDefaultOption UiTargetOption
{
get => orig.UiTargetOption;
set => orig.UiTargetOption = value;
}

public UnityEngine.GameObject UiTarget
{
get => orig.UiTarget;
set => orig.UiTarget = value;
}

public HutongGames.PlayMaker.FsmFloat fsmFloatTarget
{
get => GetField<HutongGames.PlayMaker.FsmFloat>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmBool fsmBoolTarget
{
get => GetField<HutongGames.PlayMaker.FsmBool>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmVector2 fsmVector2Target
{
get => GetField<HutongGames.PlayMaker.FsmVector2>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmString fsmStringTarget
{
get => GetField<HutongGames.PlayMaker.FsmString>();
set => SetField(value);
}

public HutongGames.PlayMaker.FsmEventTarget fsmEventTarget
{
get => GetField<HutongGames.PlayMaker.FsmEventTarget>();
set => SetField(value);
}

public bool WatchInputField
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.UI.InputField inputField
{
get => GetField<UnityEngine.UI.InputField>();
set => SetField(value);
}

public string lastInputFieldValue
{
get => GetField<string>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

public void SetupEventTarget () =>
CallMethod();

public void SetupVariableTarget () =>
CallMethod();

public void SetupUiListeners () =>
CallMethod();

public void OnClick () =>
CallMethod();

public void OnValueChanged (bool value) =>
CallMethod(new object[] {value});

public void OnValueChanged (float value) =>
CallMethod(new object[] {value});

public void OnValueChanged (UnityEngine.Vector2 value) =>
CallMethod(new object[] {value});

public void onEndEdit (string value) =>
CallMethod(new object[] {value});

public void SetFsmVariable (UnityEngine.Vector2 value) =>
CallMethod(new object[] {value});

public void SetFsmVariable (bool value) =>
CallMethod(new object[] {value});

public void SetFsmVariable (float value) =>
CallMethod(new object[] {value});

public void SetFsmVariable (string value) =>
CallMethod(new object[] {value});

public void FirePlayMakerEvent (HutongGames.PlayMaker.FsmEventData eventData) =>
CallMethod(new object[] {eventData});

public bool DoesTargetImplementsEvent () =>
orig.DoesTargetImplementsEvent();

public string GetEventString () =>
CallMethod<string>();

}
}
