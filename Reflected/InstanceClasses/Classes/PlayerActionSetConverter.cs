using Modding.Converters;
using Newtonsoft.Json;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerActionSetConverter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerActionSetConverterR : InstanceClassWrapper<PlayerActionSetConverter>
{
    public PlayerActionSetConverterR(PlayerActionSetConverter _orig) : base(_orig)
    {
    }

    public bool CanRead => orig.CanRead;

    public bool CanWrite => orig.CanWrite;

    public bool CanConvert(Type objectType)
    {
        return orig.CanConvert(objectType);
    }

    public object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        return orig.ReadJson(reader, objectType, existingValue, serializer);
    }

    public void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        orig.WriteJson(writer, value, serializer);
    }
}