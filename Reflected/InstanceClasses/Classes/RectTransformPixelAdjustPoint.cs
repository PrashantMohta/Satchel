namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RectTransformPixelAdjustPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RectTransformPixelAdjustPointR : InstanceClassWrapper<RectTransformPixelAdjustPoint>
{
    public RectTransformPixelAdjustPointR(RectTransformPixelAdjustPoint _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject canvas
    {
        get => orig.canvas;
        set => orig.canvas = value;
    }

    public FsmVector2 screenPoint
    {
        get => orig.screenPoint;
        set => orig.screenPoint = value;
    }

    public FsmVector2 pixelPoint
    {
        get => orig.pixelPoint;
        set => orig.pixelPoint = value;
    }

    public RectTransform _rt
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public Canvas _canvas
    {
        get => GetField<Canvas>();
        set => SetField(value);
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnActionUpdate()
    {
        orig.OnActionUpdate();
    }

    public void DoAction()
    {
        CallMethod();
    }
}