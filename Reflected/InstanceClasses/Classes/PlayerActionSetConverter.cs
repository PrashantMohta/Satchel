namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerActionSetConverter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerActionSetConverterR:InstanceClassWrapper<Modding.Converters.PlayerActionSetConverter>
{
public PlayerActionSetConverterR(Modding.Converters.PlayerActionSetConverter _orig) : base(_orig) {}
public bool CanRead
{
get => orig.CanRead;
}

public bool CanWrite
{
get => orig.CanWrite;
}

public bool CanConvert (System.Type objectType) =>
orig.CanConvert(objectType);

public System.Object ReadJson (Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer) =>
orig.ReadJson(reader, objectType, existingValue, serializer);

public void WriteJson (Newtonsoft.Json.JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer) =>
orig.WriteJson(writer, value, serializer);

}
}
