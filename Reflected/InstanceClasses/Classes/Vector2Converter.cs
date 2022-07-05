using Modding.Converters;
using Newtonsoft.Json;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Vector2Converter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector2ConverterR : InstanceClassWrapper<Vector2Converter>
{
    public Vector2ConverterR(Vector2Converter _orig) : base(_orig)
    {
    }

    public bool CanRead => orig.CanRead;

    public bool CanWrite => orig.CanWrite;

    public Vector2 ReadJson(Dictionary<string, object> token, object existingValue)
    {
        return orig.ReadJson(token, existingValue);
    }

    public void WriteJson(JsonWriter writer, Vector2 value)
    {
        orig.WriteJson(writer, value);
    }
}