namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ObjectPool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ObjectPoolR:InstanceClassWrapper<ObjectPool>
{
public ObjectPoolR(ObjectPool _orig) : base(_orig) {}
public System.Collections.Generic.List<UnityEngine.GameObject> tempList
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.GameObject> destroyList
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<UnityEngine.GameObject>> pooledObjects
{
get => GetField<System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<UnityEngine.GameObject>>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<UnityEngine.GameObject,UnityEngine.GameObject> spawnedObjects
{
get => GetField<System.Collections.Generic.Dictionary<UnityEngine.GameObject,UnityEngine.GameObject>>();
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

public UnityEngine.Vector2 activeStashLocation
{
get => GetFieldStatic<UnityEngine.Vector2>();
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

public ObjectPool instance
{
get => ObjectPool.instance;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void CreateStartupPools () =>
ObjectPool.CreateStartupPools();

public void CreatePool<T>(T prefab, int initialPoolSize) where T : Component=>
ObjectPool.CreatePool<T>(prefab, initialPoolSize);

public void CreatePool (UnityEngine.GameObject prefab, int initialPoolSize) =>
ObjectPool.CreatePool(prefab, initialPoolSize);

public void RevertToStartState () =>
orig.RevertToStartState();

public T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) where T : Component=>
ObjectPool.Spawn<T>(prefab, parent, position, rotation);

public T Spawn<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) where T : Component=>
ObjectPool.Spawn<T>(prefab, position, rotation);

public T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position) where T : Component=>
ObjectPool.Spawn<T>(prefab, parent, position);

public T Spawn<T>(T prefab, UnityEngine.Vector3 position) where T : Component=>
ObjectPool.Spawn<T>(prefab, position);

public T Spawn<T>(T prefab, UnityEngine.Transform parent) where T : Component=>
ObjectPool.Spawn<T>(prefab, parent);

public T Spawn<T>(T prefab)where T : Component =>
ObjectPool.Spawn<T>(prefab);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) =>
ObjectPool.Spawn(prefab, parent, position, rotation);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position) =>
ObjectPool.Spawn(prefab, parent, position);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) =>
ObjectPool.Spawn(prefab, position, rotation);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab, UnityEngine.Transform parent) =>
ObjectPool.Spawn(prefab, parent);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab, UnityEngine.Vector3 position) =>
ObjectPool.Spawn(prefab, position);

public UnityEngine.GameObject Spawn (UnityEngine.GameObject prefab) =>
ObjectPool.Spawn(prefab);

public void Recycle<T>(T obj)where T : Component =>
ObjectPool.Recycle<T>(obj);

public void Recycle (UnityEngine.GameObject obj) =>
ObjectPool.Recycle(obj);

public void Recycle (UnityEngine.GameObject obj, UnityEngine.GameObject prefab) =>
CallMethodStatic(new object[] {obj, prefab});

public void RecycleAll<T>(T prefab)where T : Component =>
ObjectPool.RecycleAll<T>(prefab);

public void RecycleAll (UnityEngine.GameObject prefab) =>
ObjectPool.RecycleAll(prefab);

public void RecycleAll () =>
ObjectPool.RecycleAll();

public bool IsSpawned (UnityEngine.GameObject obj) =>
ObjectPool.IsSpawned(obj);

public int CountPooled<T>(T prefab) where T : Component=>
ObjectPool.CountPooled<T>(prefab);

public int CountPooled (UnityEngine.GameObject prefab) =>
ObjectPool.CountPooled(prefab);

public int CountSpawned<T>(T prefab)where T : Component =>
ObjectPool.CountSpawned<T>(prefab);

public int CountSpawned (UnityEngine.GameObject prefab) =>
ObjectPool.CountSpawned(prefab);

public int CountAllPooled () =>
ObjectPool.CountAllPooled();

public System.Collections.Generic.List<UnityEngine.GameObject> GetPooled (UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList) =>
ObjectPool.GetPooled(prefab, list, appendList);

public System.Collections.Generic.List<T> GetPooled<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList)where T : Component =>
ObjectPool.GetPooled<T>(prefab, list, appendList);

public System.Collections.Generic.List<UnityEngine.GameObject> GetSpawned (UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList) =>
ObjectPool.GetSpawned(prefab, list, appendList);

public System.Collections.Generic.List<T> GetSpawned<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList) where T : Component=>
ObjectPool.GetSpawned<T>(prefab, list, appendList);

public void DestroyPooled (UnityEngine.GameObject prefab) =>
ObjectPool.DestroyPooled(prefab);

public void DestroyPooled<T>(T prefab)where T : Component =>
ObjectPool.DestroyPooled<T>(prefab);

public void DestroyPooled (UnityEngine.GameObject prefab, int amountToRemove) =>
ObjectPool.DestroyPooled(prefab, amountToRemove);

public void DestroyPooled<T>(T prefab, int amount)where T : Component =>
ObjectPool.DestroyPooled<T>(prefab, amount);

public void DestroyAll (UnityEngine.GameObject prefab) =>
ObjectPool.DestroyAll(prefab);

public void DestroyAll<T>(T prefab) where T : Component=>
ObjectPool.DestroyAll<T>(prefab);

public UnityEngine.GameObject orig_Spawn (UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) =>
ObjectPool.orig_Spawn(prefab, parent, position, rotation);

public void orig_CreatePool (UnityEngine.GameObject prefab, int initialPoolSize) =>
ObjectPool.orig_CreatePool(prefab, initialPoolSize);

}
}
