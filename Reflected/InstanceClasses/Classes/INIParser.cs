namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of INIParser allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class INIParserR:InstanceClassWrapper<INIParser>
{
public INIParserR(INIParser _orig) : base(_orig) {}
public int error
{
get => orig.error;
set => orig.error = value;
}

public System.Object m_Lock
{
get => GetField<System.Object>();
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

public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.String>> m_Sections
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.String>>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.String>> m_Modified
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.String>>>();
set => SetField(value);
}

public bool m_CacheModified
{
get => GetField<bool>();
set => SetField(value);
}

public string FileName
{
get => orig.FileName;
}

public string iniString
{
get => orig.iniString;
}

public void Open (string path) =>
orig.Open(path);

public void Open (UnityEngine.TextAsset name) =>
orig.Open(name);

public void OpenFromString (string str) =>
orig.OpenFromString(str);

public string ToString () =>
orig.ToString();

public void Initialize (string iniString, bool AutoFlush) =>
CallMethod(new object[] {iniString, AutoFlush});

public void Close () =>
orig.Close();

public string ParseSectionName (string Line) =>
CallMethod<string>(new object[] {Line});

public bool ParseKeyValuePair (string Line, string Key, string Value) =>
CallMethod<bool>(new object[] {Line, Key, Value});

public bool isComment (string Line) =>
CallMethod<bool>(new object[] {Line});

public void Refresh () =>
CallMethod();

public void PerformFlush () =>
CallMethod();

public bool IsSectionExists (string SectionName) =>
orig.IsSectionExists(SectionName);

public bool IsKeyExists (string SectionName, string Key) =>
orig.IsKeyExists(SectionName, Key);

public void SectionDelete (string SectionName) =>
orig.SectionDelete(SectionName);

public void KeyDelete (string SectionName, string Key) =>
orig.KeyDelete(SectionName, Key);

public string ReadValue (string SectionName, string Key, string DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public void WriteValue (string SectionName, string Key, string Value) =>
orig.WriteValue(SectionName, Key, Value);

public string EncodeByteArray (System.Byte[] Value) =>
CallMethod<string>(new object[] {Value});

public System.Byte[] DecodeByteArray (string Value) =>
CallMethod<System.Byte[]>(new object[] {Value});

public bool ReadValue (string SectionName, string Key, bool DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public int ReadValue (string SectionName, string Key, int DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public System.Int64 ReadValue (string SectionName, string Key, System.Int64 DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public System.Double ReadValue (string SectionName, string Key, System.Double DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public System.Byte[] ReadValue (string SectionName, string Key, System.Byte[] DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public System.DateTime ReadValue (string SectionName, string Key, System.DateTime DefaultValue) =>
orig.ReadValue(SectionName, Key, DefaultValue);

public void WriteValue (string SectionName, string Key, bool Value) =>
orig.WriteValue(SectionName, Key, Value);

public void WriteValue (string SectionName, string Key, int Value) =>
orig.WriteValue(SectionName, Key, Value);

public void WriteValue (string SectionName, string Key, System.Int64 Value) =>
orig.WriteValue(SectionName, Key, Value);

public void WriteValue (string SectionName, string Key, System.Double Value) =>
orig.WriteValue(SectionName, Key, Value);

public void WriteValue (string SectionName, string Key, System.Byte[] Value) =>
orig.WriteValue(SectionName, Key, Value);

public void WriteValue (string SectionName, string Key, System.DateTime Value) =>
orig.WriteValue(SectionName, Key, Value);

}
}
