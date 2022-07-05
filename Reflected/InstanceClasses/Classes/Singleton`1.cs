namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Singleton`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SingletonR<T> : InstanceClassWrapper<Singleton<T>> where T : MonoBehaviour
{
    public SingletonR(Singleton<T> _orig) : base(_orig)
    {
    }

    public T _instance
    {
        get => GetFieldStatic<T>();
        set => SetField(value);
    }

    public object _lock
    {
        get => GetFieldStatic<object>();
        set => SetField(value);
    }

    public bool applicationIsQuitting
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public T instance => Singleton<T>.instance;


    public void Awake()
    {
        orig.Awake();
    }

    public void OnDestroy()
    {
        orig.OnDestroy();
    }
}