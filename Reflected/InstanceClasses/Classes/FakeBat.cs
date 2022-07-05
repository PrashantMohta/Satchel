namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FakeBat allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FakeBatR : InstanceClassWrapper<FakeBat>
{
    public FakeBatR(FakeBat _orig) : base(_orig)
    {
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public float turnCooldown
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Transform grimm
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public float Z
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public List<FakeBat> fakeBats
    {
        get => GetFieldStatic<List<FakeBat>>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Init()
    {
        CallMethodStatic();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void NotifyAllBossAwake()
    {
        FakeBat.NotifyAllBossAwake();
    }

    public void NotifyBossAwake()
    {
        orig.NotifyBossAwake();
    }

    public void SendAllOut()
    {
        FakeBat.SendAllOut();
    }

    public void SendOut()
    {
        orig.SendOut();
    }

    public IEnumerator SendOutRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public void BringAllIn()
    {
        FakeBat.BringAllIn();
    }

    public void BringIn()
    {
        orig.BringIn();
    }

    public IEnumerator BringInRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public void FaceDirection(int sign, bool snap)
    {
        CallMethod(new object[] { sign, snap });
    }

    public void Accelerate(Vector2 fixedAcceleration, Vector2 speedLimit)
    {
        CallMethod(new object[] { fixedAcceleration, speedLimit });
    }
}