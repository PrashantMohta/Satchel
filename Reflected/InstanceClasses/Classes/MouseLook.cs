namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MouseLook allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MouseLookR : InstanceClassWrapper<MouseLook>
{
    public MouseLookR(MouseLook _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat sensitivityX
    {
        get => orig.sensitivityX;
        set => orig.sensitivityX = value;
    }

    public FsmFloat sensitivityY
    {
        get => orig.sensitivityY;
        set => orig.sensitivityY = value;
    }

    public FsmFloat minimumX
    {
        get => orig.minimumX;
        set => orig.minimumX = value;
    }

    public FsmFloat maximumX
    {
        get => orig.maximumX;
        set => orig.maximumX = value;
    }

    public FsmFloat minimumY
    {
        get => orig.minimumY;
        set => orig.minimumY = value;
    }

    public FsmFloat maximumY
    {
        get => orig.maximumY;
        set => orig.maximumY = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public float rotationX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float rotationY
    {
        get => GetField<float>();
        set => SetField(value);
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoMouseLook()
    {
        CallMethod();
    }

    public float GetXRotation()
    {
        return CallMethod<float>();
    }

    public float GetYRotation()
    {
        return CallMethod<float>();
    }

    public float ClampAngle(float angle, FsmFloat min, FsmFloat max)
    {
        return CallMethodStatic<float>(new object[] { angle, min, max });
    }
}