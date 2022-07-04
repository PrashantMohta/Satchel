using System.Security.Cryptography;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerPrefsSharedData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerPrefsSharedDataR : InstanceClassWrapper<PlayerPrefsSharedData>
{
    public PlayerPrefsSharedDataR(PlayerPrefsSharedData _orig) : base(_orig)
    {
    }

    public RijndaelManaged cryptoSettings
    {
        get => GetField<RijndaelManaged>();
        set => SetField(value);
    }

    public bool IsEncrypted => orig.IsEncrypted;

    public string ReadEncrypted(string key)
    {
        return CallMethod<string>(new object[] { key });
    }

    public void WriteEncrypted(string key, string val)
    {
        CallMethod(new object[] { key, val });
    }

    public bool HasKey(string key)
    {
        return orig.HasKey(key);
    }

    public void DeleteKey(string key)
    {
        orig.DeleteKey(key);
    }

    public void DeleteAll()
    {
        orig.DeleteAll();
    }

    public bool GetBool(string key, bool def)
    {
        return orig.GetBool(key, def);
    }

    public void SetBool(string key, bool val)
    {
        orig.SetBool(key, val);
    }

    public int GetInt(string key, int def)
    {
        return orig.GetInt(key, def);
    }

    public void SetInt(string key, int val)
    {
        orig.SetInt(key, val);
    }

    public float GetFloat(string key, float def)
    {
        return orig.GetFloat(key, def);
    }

    public void SetFloat(string key, float val)
    {
        orig.SetFloat(key, val);
    }

    public string GetString(string key, string def)
    {
        return orig.GetString(key, def);
    }

    public void SetString(string key, string val)
    {
        orig.SetString(key, val);
    }

    public void Save()
    {
        orig.Save();
    }
}