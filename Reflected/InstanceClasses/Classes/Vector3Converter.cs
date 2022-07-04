namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Vector3Converter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector3ConverterR:InstanceClassWrapper<Modding.Converters.Vector3Converter>
{
public Vector3ConverterR(Modding.Converters.Vector3Converter _orig) : base(_orig) {}
public bool CanRead
{
get => orig.CanRead;
}

public bool CanWrite
{
get => orig.CanWrite;
}

public UnityEngine.Vector3 ReadJson (System.Collections.Generic.Dictionary<System.String,System.Object> token, System.Object existingValue) =>
orig.ReadJson(token, existingValue);

public void WriteJson (Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector3 value) =>
orig.WriteJson(writer, value);

}
}
