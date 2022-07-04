namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SecurePlayerPrefs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecurePlayerPrefsR:InstanceClassWrapper<SecPlayerPrefs.SecurePlayerPrefs>
{
public SecurePlayerPrefsR(SecPlayerPrefs.SecurePlayerPrefs _orig) : base(_orig) {}
public System.Byte[] Salt
{
get => GetFieldStatic<System.Byte[]>();
set => SetField(value);
}

public System.Byte[] keyArray
{
get => GetFieldStatic<System.Byte[]>();
set => SetField(value);
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public string Encrypt (string toEncrypt) =>
CallMethodStatic<string>(new object[] {toEncrypt});

public string Decrypt (string toDecrypt) =>
CallMethodStatic<string>(new object[] {toDecrypt});

public string UTF8ByteArrayToString (System.Byte[] characters) =>
CallMethodStatic<string>(new object[] {characters});

public System.Byte[] StringToUTF8ByteArray (string pXmlString) =>
CallMethodStatic<System.Byte[]>(new object[] {pXmlString});

public void SetInt (string Key, int Value) =>
SecPlayerPrefs.SecurePlayerPrefs.SetInt(Key, Value);

public void SetString (string Key, string Value) =>
SecPlayerPrefs.SecurePlayerPrefs.SetString(Key, Value);

public void SetFloat (string Key, float Value) =>
SecPlayerPrefs.SecurePlayerPrefs.SetFloat(Key, Value);

public void SetBool (string Key, bool Value) =>
SecPlayerPrefs.SecurePlayerPrefs.SetBool(Key, Value);

public string GetString (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.GetString(Key);

public int GetInt (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.GetInt(Key);

public float GetFloat (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.GetFloat(Key);

public bool GetBool (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.GetBool(Key);

public void DeleteKey (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.DeleteKey(Key);

public void DeleteAll () =>
SecPlayerPrefs.SecurePlayerPrefs.DeleteAll();

public void Save () =>
SecPlayerPrefs.SecurePlayerPrefs.Save();

public bool HasKey (string Key) =>
SecPlayerPrefs.SecurePlayerPrefs.HasKey(Key);

}
}
