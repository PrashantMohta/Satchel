namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PersonalObjectPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PersonalObjectPoolR : InstanceClassWrapper<PersonalObjectPool>
{
    public PersonalObjectPoolR(PersonalObjectPool _orig) : base(_orig)
    {
    }

    public StartupPool[] startupPool
    {
        get => orig.startupPool;
        set => orig.startupPool = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public bool createdStartupPools
    {
        get => GetField<bool>();
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

    public void CreateStartupPools()
    {
        orig.CreateStartupPools();
    }

    public void CreatePool(GameObject prefab, int initialPoolSize)
    {
        orig.CreatePool(prefab, initialPoolSize);
    }

    public void DestroyMyPooledObjects()
    {
        orig.DestroyMyPooledObjects();
    }
}