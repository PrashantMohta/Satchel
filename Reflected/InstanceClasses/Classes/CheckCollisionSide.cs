namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CheckCollisionSide allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CheckCollisionSideR : InstanceClassWrapper<CheckCollisionSide>
{
    public CheckCollisionSideR(CheckCollisionSide _orig) : base(_orig)
    {
    }

    public FsmBool topHit
    {
        get => orig.topHit;
        set => orig.topHit = value;
    }

    public FsmBool rightHit
    {
        get => orig.rightHit;
        set => orig.rightHit = value;
    }

    public FsmBool bottomHit
    {
        get => orig.bottomHit;
        set => orig.bottomHit = value;
    }

    public FsmBool leftHit
    {
        get => orig.leftHit;
        set => orig.leftHit = value;
    }

    public FsmEvent topHitEvent
    {
        get => orig.topHitEvent;
        set => orig.topHitEvent = value;
    }

    public FsmEvent rightHitEvent
    {
        get => orig.rightHitEvent;
        set => orig.rightHitEvent = value;
    }

    public FsmEvent bottomHitEvent
    {
        get => orig.bottomHitEvent;
        set => orig.bottomHitEvent = value;
    }

    public FsmEvent leftHitEvent
    {
        get => orig.leftHitEvent;
        set => orig.leftHitEvent = value;
    }

    public bool otherLayer
    {
        get => orig.otherLayer;
        set => orig.otherLayer = value;
    }

    public int otherLayerNumber
    {
        get => orig.otherLayerNumber;
        set => orig.otherLayerNumber = value;
    }

    public FsmBool ignoreTriggers
    {
        get => orig.ignoreTriggers;
        set => orig.ignoreTriggers = value;
    }

    public PlayMakerUnity2DProxy _proxy
    {
        get => GetField<PlayMakerUnity2DProxy>();
        set => SetField(value);
    }

    public Collider2D col2d
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public float RAYCAST_LENGTH
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public List<Vector2> topRays
    {
        get => GetField<List<Vector2>>();
        set => SetField(value);
    }

    public List<Vector2> rightRays
    {
        get => GetField<List<Vector2>>();
        set => SetField(value);
    }

    public List<Vector2> bottomRays
    {
        get => GetField<List<Vector2>>();
        set => SetField(value);
    }

    public List<Vector2> leftRays
    {
        get => GetField<List<Vector2>>();
        set => SetField(value);
    }

    public bool checkUp
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool checkDown
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool checkLeft
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool checkRight
    {
        get => GetField<bool>();
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

    public void OnExit()
    {
        orig.OnExit();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoCollisionStay2D(Collision2D collision)
    {
        orig.DoCollisionStay2D(collision);
    }

    public void DoCollisionExit2D(Collision2D collision)
    {
        orig.DoCollisionExit2D(collision);
    }

    public void CheckTouching(LayerMask layer)
    {
        CallMethod(new object[] { layer });
    }
}