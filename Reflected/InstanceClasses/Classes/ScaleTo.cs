namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScaleTo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScaleToR : InstanceClassWrapper<ScaleTo>
{
    public ScaleToR(ScaleTo _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector3 target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmFloat duration
    {
        get => orig.duration;
        set => orig.duration = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public ScaleToCurves curve
    {
        get => orig.curve;
        set => orig.curve = value;
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Transform transform
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Vector3 startScale
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

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void UpdateScaling()
    {
        CallMethod();
    }

    public float GetCurved(float val, ScaleToCurves curve)
    {
        return CallMethodStatic<float>(new object[] { val, curve });
    }

    public float Linear(float val)
    {
        return CallMethodStatic<float>(new object[] { val });
    }

    public float QuadraticOut(float val)
    {
        return CallMethodStatic<float>(new object[] { val });
    }

    public float SinusoidalOut(float val)
    {
        return CallMethodStatic<float>(new object[] { val });
    }
}