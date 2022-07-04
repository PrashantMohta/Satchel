namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SecureDataManager`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecureDataManagerR<T>:InstanceClassWrapper<SecPlayerPrefs.SecureDataManager<T>>where T: new()
{
public SecureDataManagerR(SecPlayerPrefs.SecureDataManager<T> _orig) : base(_orig) {}
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

public T Get () =>
orig.Get();

public T Load () =>
CallMethod<T>();

public void Save (T stats) =>
orig.Save(stats);

public string SerializeObject (T pObject) =>
CallMethod<string>(new object[] {pObject});

public T DeserializeObject (string pXmlizedString) =>
CallMethod<T>(new object[] {pXmlizedString});

public string UTF8ByteArrayToString (System.Byte[] characters) =>
CallMethodStatic<string>(new object[] {characters});

public System.Byte[] StringToUTF8ByteArray (string pXmlString) =>
CallMethodStatic<System.Byte[]>(new object[] {pXmlString});

}
}
