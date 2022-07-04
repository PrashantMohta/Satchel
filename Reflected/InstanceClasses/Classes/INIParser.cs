namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of INIParser allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class INIParserR : InstanceClassWrapper<INIParser>
{
    public INIParserR(INIParser _orig) : base(_orig)
    {
    }

    public int error
    {
        get => orig.error;
        set => orig.error = value;
    }

    public object m_Lock
    {
        get => GetField<object>();
        set => SetField(value);
    }

    public string m_FileName
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string m_iniString
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public bool m_AutoFlush
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Dictionary<string, Dictionary<string, string>> m_Sections
    {
        get => GetField<Dictionary<string, Dictionary<string, string>>>();
        set => SetField(value);
    }

    public Dictionary<string, Dictionary<string, string>> m_Modified
    {
        get => GetField<Dictionary<string, Dictionary<string, string>>>();
        set => SetField(value);
    }

    public bool m_CacheModified
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string FileName => orig.FileName;

    public string iniString => orig.iniString;

    public void Open(string path)
    {
        orig.Open(path);
    }

    public void Open(TextAsset name)
    {
        orig.Open(name);
    }

    public void OpenFromString(string str)
    {
        orig.OpenFromString(str);
    }

    public string ToString()
    {
        return orig.ToString();
    }

    public void Initialize(string iniString, bool AutoFlush)
    {
        CallMethod(new object[] { iniString, AutoFlush });
    }

    public void Close()
    {
        orig.Close();
    }

    public string ParseSectionName(string Line)
    {
        return CallMethod<string>(new object[] { Line });
    }

    public bool ParseKeyValuePair(string Line, string Key, string Value)
    {
        return CallMethod<bool>(new object[] { Line, Key, Value });
    }

    public bool isComment(string Line)
    {
        return CallMethod<bool>(new object[] { Line });
    }

    public void Refresh()
    {
        CallMethod();
    }

    public void PerformFlush()
    {
        CallMethod();
    }

    public bool IsSectionExists(string SectionName)
    {
        return orig.IsSectionExists(SectionName);
    }

    public bool IsKeyExists(string SectionName, string Key)
    {
        return orig.IsKeyExists(SectionName, Key);
    }

    public void SectionDelete(string SectionName)
    {
        orig.SectionDelete(SectionName);
    }

    public void KeyDelete(string SectionName, string Key)
    {
        orig.KeyDelete(SectionName, Key);
    }

    public string ReadValue(string SectionName, string Key, string DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public void WriteValue(string SectionName, string Key, string Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public string EncodeByteArray(byte[] Value)
    {
        return CallMethod<string>(new object[] { Value });
    }

    public byte[] DecodeByteArray(string Value)
    {
        return CallMethod<byte[]>(new object[] { Value });
    }

    public bool ReadValue(string SectionName, string Key, bool DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public int ReadValue(string SectionName, string Key, int DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public long ReadValue(string SectionName, string Key, long DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public double ReadValue(string SectionName, string Key, double DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public byte[] ReadValue(string SectionName, string Key, byte[] DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public DateTime ReadValue(string SectionName, string Key, DateTime DefaultValue)
    {
        return orig.ReadValue(SectionName, Key, DefaultValue);
    }

    public void WriteValue(string SectionName, string Key, bool Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public void WriteValue(string SectionName, string Key, int Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public void WriteValue(string SectionName, string Key, long Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public void WriteValue(string SectionName, string Key, double Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public void WriteValue(string SectionName, string Key, byte[] Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }

    public void WriteValue(string SectionName, string Key, DateTime Value)
    {
        orig.WriteValue(SectionName, Key, Value);
    }
}