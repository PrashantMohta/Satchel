namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ObjectPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ObjectPoolR : InstanceClassWrapper<ObjectPool>
{
    public ObjectPoolR(ObjectPool _orig) : base(_orig)
    {
    }

    public List<GameObject> tempList
    {
        get => GetFieldStatic<List<GameObject>>();
        set => SetField(value);
    }

    public List<GameObject> destroyList
    {
        get => GetFieldStatic<List<GameObject>>();
        set => SetField(value);
    }

    public Dictionary<GameObject, List<GameObject>> pooledObjects
    {
        get => GetField<Dictionary<GameObject, List<GameObject>>>();
        set => SetField(value);
    }

    public Dictionary<GameObject, GameObject> spawnedObjects
    {
        get => GetField<Dictionary<GameObject, GameObject>>();
        set => SetField(value);
    }

    public ObjectPool.StartupPool[] startupPools
    {
        get => orig.startupPools;
        set => orig.startupPools = value;
    }

    public bool startupPoolsCreated
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 activeStashLocation
    {
        get => GetFieldStatic<Vector2>();
        set => SetField(value);
    }

    public bool isRecycling
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public ObjectPool _instance
    {
        get => GetFieldStatic<ObjectPool>();
        set => SetField(value);
    }

    public ObjectPool instance => ObjectPool.instance;


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void CreateStartupPools()
    {
        ObjectPool.CreateStartupPools();
    }

    public void CreatePool<T>(T prefab, int initialPoolSize) where T : Component
    {
        ObjectPool.CreatePool(prefab, initialPoolSize);
    }

    public void CreatePool(GameObject prefab, int initialPoolSize)
    {
        ObjectPool.CreatePool(prefab, initialPoolSize);
    }

    public void RevertToStartState()
    {
        orig.RevertToStartState();
    }

    public T Spawn<T>(T prefab, Transform parent, Vector3 position, Quaternion rotation) where T : Component
    {
        return ObjectPool.Spawn(prefab, parent, position, rotation);
    }

    public T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component
    {
        return ObjectPool.Spawn(prefab, position, rotation);
    }

    public T Spawn<T>(T prefab, Transform parent, Vector3 position) where T : Component
    {
        return ObjectPool.Spawn(prefab, parent, position);
    }

    public T Spawn<T>(T prefab, Vector3 position) where T : Component
    {
        return ObjectPool.Spawn(prefab, position);
    }

    public T Spawn<T>(T prefab, Transform parent) where T : Component
    {
        return ObjectPool.Spawn(prefab, parent);
    }

    public T Spawn<T>(T prefab) where T : Component
    {
        return ObjectPool.Spawn(prefab);
    }

    public GameObject Spawn(GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
    {
        return ObjectPool.Spawn(prefab, parent, position, rotation);
    }

    public GameObject Spawn(GameObject prefab, Transform parent, Vector3 position)
    {
        return ObjectPool.Spawn(prefab, parent, position);
    }

    public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        return ObjectPool.Spawn(prefab, position, rotation);
    }

    public GameObject Spawn(GameObject prefab, Transform parent)
    {
        return ObjectPool.Spawn(prefab, parent);
    }

    public GameObject Spawn(GameObject prefab, Vector3 position)
    {
        return ObjectPool.Spawn(prefab, position);
    }

    public GameObject Spawn(GameObject prefab)
    {
        return ObjectPool.Spawn(prefab);
    }

    public void Recycle<T>(T obj) where T : Component
    {
        ObjectPool.Recycle(obj);
    }

    public void Recycle(GameObject obj)
    {
        ObjectPool.Recycle(obj);
    }

    public void Recycle(GameObject obj, GameObject prefab)
    {
        CallMethodStatic(new object[] { obj, prefab });
    }

    public void RecycleAll<T>(T prefab) where T : Component
    {
        ObjectPool.RecycleAll(prefab);
    }

    public void RecycleAll(GameObject prefab)
    {
        ObjectPool.RecycleAll(prefab);
    }

    public void RecycleAll()
    {
        ObjectPool.RecycleAll();
    }

    public bool IsSpawned(GameObject obj)
    {
        return ObjectPool.IsSpawned(obj);
    }

    public int CountPooled<T>(T prefab) where T : Component
    {
        return ObjectPool.CountPooled(prefab);
    }

    public int CountPooled(GameObject prefab)
    {
        return ObjectPool.CountPooled(prefab);
    }

    public int CountSpawned<T>(T prefab) where T : Component
    {
        return ObjectPool.CountSpawned(prefab);
    }

    public int CountSpawned(GameObject prefab)
    {
        return ObjectPool.CountSpawned(prefab);
    }

    public int CountAllPooled()
    {
        return ObjectPool.CountAllPooled();
    }

    public List<GameObject> GetPooled(GameObject prefab, List<GameObject> list, bool appendList)
    {
        return ObjectPool.GetPooled(prefab, list, appendList);
    }

    public List<T> GetPooled<T>(T prefab, List<T> list, bool appendList) where T : Component
    {
        return ObjectPool.GetPooled(prefab, list, appendList);
    }

    public List<GameObject> GetSpawned(GameObject prefab, List<GameObject> list, bool appendList)
    {
        return ObjectPool.GetSpawned(prefab, list, appendList);
    }

    public List<T> GetSpawned<T>(T prefab, List<T> list, bool appendList) where T : Component
    {
        return ObjectPool.GetSpawned(prefab, list, appendList);
    }

    public void DestroyPooled(GameObject prefab)
    {
        ObjectPool.DestroyPooled(prefab);
    }

    public void DestroyPooled<T>(T prefab) where T : Component
    {
        ObjectPool.DestroyPooled(prefab);
    }

    public void DestroyPooled(GameObject prefab, int amountToRemove)
    {
        ObjectPool.DestroyPooled(prefab, amountToRemove);
    }

    public void DestroyPooled<T>(T prefab, int amount) where T : Component
    {
        ObjectPool.DestroyPooled(prefab, amount);
    }

    public void DestroyAll(GameObject prefab)
    {
        ObjectPool.DestroyAll(prefab);
    }

    public void DestroyAll<T>(T prefab) where T : Component
    {
        ObjectPool.DestroyAll(prefab);
    }

    public GameObject orig_Spawn(GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
    {
        return ObjectPool.orig_Spawn(prefab, parent, position, rotation);
    }

    public void orig_CreatePool(GameObject prefab, int initialPoolSize)
    {
        ObjectPool.orig_CreatePool(prefab, initialPoolSize);
    }
}