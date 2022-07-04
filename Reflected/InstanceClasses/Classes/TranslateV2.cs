namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TranslateV2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TranslateV2R : InstanceClassWrapper<TranslateV2>
{
    public TranslateV2R(TranslateV2 _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector3 vector
    {
        get => orig.vector;
        set => orig.vector = value;
    }

    public FsmFloat x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public FsmFloat y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public FsmFloat z
    {
        get => orig.z;
        set => orig.z = value;
    }

    public Space space
    {
        get => orig.space;
        set => orig.space = value;
    }

    public bool perSecond
    {
        get => orig.perSecond;
        set => orig.perSecond = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public bool lateUpdate
    {
        get => orig.lateUpdate;
        set => orig.lateUpdate = value;
    }

    public bool fixedUpdate
    {
        get => orig.fixedUpdate;
        set => orig.fixedUpdate = value;
    }

    public bool alwaysOnStart
    {
        get => orig.alwaysOnStart;
        set => orig.alwaysOnStart = value;
    }

    public FsmFloat yMin
    {
        get => orig.yMin;
        set => orig.yMin = value;
    }

    public FsmFloat yMax
    {
        get => orig.yMax;
        set => orig.yMax = value;
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

    public void Awake()
    {
        orig.Awake();
    }

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void OnLateUpdate()
    {
        orig.OnLateUpdate();
    }

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoTranslate()
    {
        CallMethod();
    }
}