namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LookAt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LookAtR : InstanceClassWrapper<LookAt>
{
    public LookAtR(LookAt _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject targetObject
    {
        get => orig.targetObject;
        set => orig.targetObject = value;
    }

    public FsmVector3 targetPosition
    {
        get => orig.targetPosition;
        set => orig.targetPosition = value;
    }

    public FsmVector3 upVector
    {
        get => orig.upVector;
        set => orig.upVector = value;
    }

    public FsmBool keepVertical
    {
        get => orig.keepVertical;
        set => orig.keepVertical = value;
    }

    public FsmBool debug
    {
        get => orig.debug;
        set => orig.debug = value;
    }

    public FsmColor debugLineColor
    {
        get => orig.debugLineColor;
        set => orig.debugLineColor = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public GameObject go
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject goTarget
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public Vector3 lookAtPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 lookAtPosWithVertical
    {
        get => GetField<Vector3>();
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnLateUpdate()
    {
        orig.OnLateUpdate();
    }

    public void DoLookAt()
    {
        CallMethod();
    }

    public bool UpdateLookAtPosition()
    {
        return orig.UpdateLookAtPosition();
    }

    public Vector3 GetLookAtPosition()
    {
        return orig.GetLookAtPosition();
    }

    public Vector3 GetLookAtPositionWithVertical()
    {
        return orig.GetLookAtPositionWithVertical();
    }
}