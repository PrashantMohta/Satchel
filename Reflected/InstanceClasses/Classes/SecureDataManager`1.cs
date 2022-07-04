using SecPlayerPrefs;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SecureDataManager`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecureDataManagerR<T> : InstanceClassWrapper<SecureDataManager<T>> where T : new()
{
    public SecureDataManagerR(SecureDataManager<T> _orig) : base(_orig)
    {
    }

    public T stats
    {
        get => GetField<T>();
        set => SetField(value);
    }

    public string key
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public T Get()
    {
        return orig.Get();
    }

    public T Load()
    {
        return CallMethod<T>();
    }

    public void Save(T stats)
    {
        orig.Save(stats);
    }

    public string SerializeObject(T pObject)
    {
        return CallMethod<string>(new object[] { pObject });
    }

    public T DeserializeObject(string pXmlizedString)
    {
        return CallMethod<T>(new object[] { pXmlizedString });
    }

    public string UTF8ByteArrayToString(byte[] characters)
    {
        return CallMethodStatic<string>(new object[] { characters });
    }

    public byte[] StringToUTF8ByteArray(string pXmlString)
    {
        return CallMethodStatic<byte[]>(new object[] { pXmlString });
    }
}