namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Vector2Converter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector2ConverterR:InstanceClassWrapper<Modding.Converters.Vector2Converter>
{
public Vector2ConverterR(Modding.Converters.Vector2Converter _orig) : base(_orig) {}
public bool CanRead
{
get => orig.CanRead;
}

public bool CanWrite
{
get => orig.CanWrite;
}

public UnityEngine.Vector2 ReadJson (System.Collections.Generic.Dictionary<System.String,System.Object> token, System.Object existingValue) =>
orig.ReadJson(token, existingValue);

public void WriteJson (Newtonsoft.Json.JsonWriter writer, UnityEngine.Vector2 value) =>
orig.WriteJson(writer, value);

}
}
