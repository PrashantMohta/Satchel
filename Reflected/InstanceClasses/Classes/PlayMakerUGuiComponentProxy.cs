using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiComponentProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUGuiComponentProxyR : InstanceClassWrapper<PlayMakerUGuiComponentProxy>
{
    public PlayMakerUGuiComponentProxyR(PlayMakerUGuiComponentProxy _orig) : base(_orig)
    {
    }

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

    public OwnerDefaultOption UiTargetOption
    {
        get => orig.UiTargetOption;
        set => orig.UiTargetOption = value;
    }

    public GameObject UiTarget
    {
        get => orig.UiTarget;
        set => orig.UiTarget = value;
    }

    public FsmFloat fsmFloatTarget
    {
        get => GetField<FsmFloat>();
        set => SetField(value);
    }

    public FsmBool fsmBoolTarget
    {
        get => GetField<FsmBool>();
        set => SetField(value);
    }

    public FsmVector2 fsmVector2Target
    {
        get => GetField<FsmVector2>();
        set => SetField(value);
    }

    public FsmString fsmStringTarget
    {
        get => GetField<FsmString>();
        set => SetField(value);
    }

    public FsmEventTarget fsmEventTarget
    {
        get => GetField<FsmEventTarget>();
        set => SetField(value);
    }

    public bool WatchInputField
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public InputField inputField
    {
        get => GetField<InputField>();
        set => SetField(value);
    }

    public string lastInputFieldValue
    {
        get => GetField<string>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void SetupEventTarget()
    {
        CallMethod();
    }

    public void SetupVariableTarget()
    {
        CallMethod();
    }

    public void SetupUiListeners()
    {
        CallMethod();
    }

    public void OnClick()
    {
        CallMethod();
    }

    public void OnValueChanged(bool value)
    {
        CallMethod(new object[] { value });
    }

    public void OnValueChanged(float value)
    {
        CallMethod(new object[] { value });
    }

    public void OnValueChanged(Vector2 value)
    {
        CallMethod(new object[] { value });
    }

    public void onEndEdit(string value)
    {
        CallMethod(new object[] { value });
    }

    public void SetFsmVariable(Vector2 value)
    {
        CallMethod(new object[] { value });
    }

    public void SetFsmVariable(bool value)
    {
        CallMethod(new object[] { value });
    }

    public void SetFsmVariable(float value)
    {
        CallMethod(new object[] { value });
    }

    public void SetFsmVariable(string value)
    {
        CallMethod(new object[] { value });
    }

    public void FirePlayMakerEvent(FsmEventData eventData)
    {
        CallMethod(new object[] { eventData });
    }

    public bool DoesTargetImplementsEvent()
    {
        return orig.DoesTargetImplementsEvent();
    }

    public string GetEventString()
    {
        return CallMethod<string>();
    }
}