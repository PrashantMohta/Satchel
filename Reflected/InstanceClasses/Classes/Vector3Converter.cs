using Modding.Converters;
using Newtonsoft.Json;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Vector3Converter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Vector3ConverterR : InstanceClassWrapper<Vector3Converter>
{
    public Vector3ConverterR(Vector3Converter _orig) : base(_orig)
    {
    }

    public bool CanRead => orig.CanRead;

    public bool CanWrite => orig.CanWrite;

    public Vector3 ReadJson(Dictionary<string, object> token, object existingValue)
    {
        return orig.ReadJson(token, existingValue);
    }

    public void WriteJson(JsonWriter writer, Vector3 value)
    {
        orig.WriteJson(writer, value);
    }
}