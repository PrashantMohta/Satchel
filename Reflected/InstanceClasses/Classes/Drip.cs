namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Drip allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DripR : InstanceClassWrapper<Drip>
{
    public DripR(Drip _orig) : base(_orig)
    {
    }

    public float minWaitTime
    {
        get => orig.minWaitTime;
        set => orig.minWaitTime = value;
    }

    public float maxWaitTime
    {
        get => orig.maxWaitTime;
        set => orig.maxWaitTime = value;
    }

    public GameObject idleSprite
    {
        get => orig.idleSprite;
        set => orig.idleSprite = value;
    }

    public GameObject dripSprite
    {
        get => orig.dripSprite;
        set => orig.dripSprite = value;
    }

    public Animator dripAnimator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Transform dripSpawnPoint
    {
        get => orig.dripSpawnPoint;
        set => orig.dripSpawnPoint = value;
    }

    public float dripDelay
    {
        get => orig.dripDelay;
        set => orig.dripDelay = value;
    }

    public GameObject dripPrefab
    {
        get => orig.dripPrefab;
        set => orig.dripPrefab = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public IEnumerator DripRoutine()
    {
        return CallMethod<IEnumerator>();
    }

    public IEnumerator DropDrip()
    {
        return CallMethod<IEnumerator>();
    }
}