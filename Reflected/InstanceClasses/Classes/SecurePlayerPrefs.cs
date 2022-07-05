using SecPlayerPrefs;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SecurePlayerPrefs allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SecurePlayerPrefsR : InstanceClassWrapper<SecurePlayerPrefs>
{
    public SecurePlayerPrefsR(SecurePlayerPrefs _orig) : base(_orig)
    {
    }

    public byte[] Salt
    {
        get => GetFieldStatic<byte[]>();
        set => SetField(value);
    }

    public byte[] keyArray
    {
        get => GetFieldStatic<byte[]>();
        set => SetField(value);
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public string Encrypt(string toEncrypt)
    {
        return CallMethodStatic<string>(new object[] { toEncrypt });
    }

    public string Decrypt(string toDecrypt)
    {
        return CallMethodStatic<string>(new object[] { toDecrypt });
    }

    public string UTF8ByteArrayToString(byte[] characters)
    {
        return CallMethodStatic<string>(new object[] { characters });
    }

    public byte[] StringToUTF8ByteArray(string pXmlString)
    {
        return CallMethodStatic<byte[]>(new object[] { pXmlString });
    }

    public void SetInt(string Key, int Value)
    {
        SecurePlayerPrefs.SetInt(Key, Value);
    }

    public void SetString(string Key, string Value)
    {
        SecurePlayerPrefs.SetString(Key, Value);
    }

    public void SetFloat(string Key, float Value)
    {
        SecurePlayerPrefs.SetFloat(Key, Value);
    }

    public void SetBool(string Key, bool Value)
    {
        SecurePlayerPrefs.SetBool(Key, Value);
    }

    public string GetString(string Key)
    {
        return SecurePlayerPrefs.GetString(Key);
    }

    public int GetInt(string Key)
    {
        return SecurePlayerPrefs.GetInt(Key);
    }

    public float GetFloat(string Key)
    {
        return SecurePlayerPrefs.GetFloat(Key);
    }

    public bool GetBool(string Key)
    {
        return SecurePlayerPrefs.GetBool(Key);
    }

    public void DeleteKey(string Key)
    {
        SecurePlayerPrefs.DeleteKey(Key);
    }

    public void DeleteAll()
    {
        SecurePlayerPrefs.DeleteAll();
    }

    public void Save()
    {
        SecurePlayerPrefs.Save();
    }

    public bool HasKey(string Key)
    {
        return SecurePlayerPrefs.HasKey(Key);
    }
}