namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUITweenItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUITweenItemR : InstanceClassWrapper<tk2dUITweenItem>
{
    public tk2dUITweenItemR(tk2dUITweenItem _orig) : base(_orig)
    {
    }

    public Vector3 onUpScale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 onDownScale
    {
        get => orig.onDownScale;
        set => orig.onDownScale = value;
    }

    public float tweenDuration
    {
        get => orig.tweenDuration;
        set => orig.tweenDuration = value;
    }

    public bool canButtonBeHeldDown
    {
        get => orig.canButtonBeHeldDown;
        set => orig.canButtonBeHeldDown = value;
    }

    public bool useOnReleaseInsteadOfOnUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool internalTweenInProgress
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector3 tweenTargetScale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 tweenStartingScale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float tweenTimeElapsed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public tk2dUIItem uiItem
    {
        get => orig.uiItem;
        set => orig.uiItem = value;
    }

    public bool UseOnReleaseInsteadOfOnUp => orig.UseOnReleaseInsteadOfOnUp;

    public GameObject SendMessageTarget
    {
        get => orig.SendMessageTarget;
        set => orig.SendMessageTarget = value;
    }


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

    public void ButtonDown()
    {
        CallMethod();
    }

    public void ButtonUp()
    {
        CallMethod();
    }

    public IEnumerator ScaleTween()
    {
        return CallMethod<IEnumerator>();
    }

    public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
    {
        orig.InternalSetUseOnReleaseInsteadOfOnUp(state);
    }
}