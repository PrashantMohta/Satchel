namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of KeepInScene allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeepInSceneR : InstanceClassWrapper<KeepInScene>
{
    public KeepInSceneR(KeepInScene _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public float minX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float maxX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float minY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float maxY
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}