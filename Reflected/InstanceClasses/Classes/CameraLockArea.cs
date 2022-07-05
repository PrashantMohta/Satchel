namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CameraLockArea allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraLockAreaR : InstanceClassWrapper<CameraLockArea>
{
    public CameraLockAreaR(CameraLockArea _orig) : base(_orig)
    {
    }

    public bool verboseMode
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float cameraXMin
    {
        get => orig.cameraXMin;
        set => orig.cameraXMin = value;
    }

    public float cameraYMin
    {
        get => orig.cameraYMin;
        set => orig.cameraYMin = value;
    }

    public float cameraXMax
    {
        get => orig.cameraXMax;
        set => orig.cameraXMax = value;
    }

    public float cameraYMax
    {
        get => orig.cameraYMax;
        set => orig.cameraYMax = value;
    }

    public float leftSideX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float rightSideX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float topSideY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float botSideY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Vector3 heroPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public bool enteredLeft
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool enteredRight
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool enteredTop
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool enteredBot
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool exitedLeft
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool exitedRight
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool exitedTop
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool exitedBot
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool preventLookUp
    {
        get => orig.preventLookUp;
        set => orig.preventLookUp = value;
    }

    public bool preventLookDown
    {
        get => orig.preventLookDown;
        set => orig.preventLookDown = value;
    }

    public bool maxPriority
    {
        get => orig.maxPriority;
        set => orig.maxPriority = value;
    }

    public GameCameras gcams
    {
        get => GetField<GameCameras>();
        set => SetField(value);
    }

    public CameraController cameraCtrl
    {
        get => GetField<CameraController>();
        set => SetField(value);
    }

    public CameraTarget camTarget
    {
        get => GetField<CameraTarget>();
        set => SetField(value);
    }

    public Collider2D box2d
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public bool IsInApplicableGameState()
    {
        return CallMethod<bool>();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        orig.OnTriggerEnter2D(otherCollider);
    }

    public void OnTriggerStay2D(Collider2D otherCollider)
    {
        orig.OnTriggerStay2D(otherCollider);
    }

    public void OnTriggerExit2D(Collider2D otherCollider)
    {
        orig.OnTriggerExit2D(otherCollider);
    }

    public void OnDisable()
    {
        orig.OnDisable();
    }

    public bool ValidateBounds()
    {
        return CallMethod<bool>();
    }

    public void SetXMin(float xmin)
    {
        orig.SetXMin(xmin);
    }

    public void SetXMax(float xmax)
    {
        orig.SetXMax(xmax);
    }

    public IEnumerator orig_Start()
    {
        return CallMethod<IEnumerator>();
    }
}