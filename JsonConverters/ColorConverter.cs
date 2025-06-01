using Newtonsoft.Json;

namespace Satchel.JsonConverters
{
    /// <summary>
    /// JsonConverter to save colors as hex codes to JSON
    /// </summary>
    public class ColorConverter : JsonConverter
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public ColorConverter()
        {
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                if (ColorUtility.TryParseHtmlString("#" + reader.Value, out Color loadedColor))
                {
                    return loadedColor;
                }
                else
                {
                    Debug.LogError($"Failed to parse color : {reader.Value}");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to parse color {objectType} : {ex.Message}");
            }

            return new Color(1, 1, 1, 1);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string val = ColorUtility.ToHtmlStringRGB((Color)value);
            writer.WriteValue(val);
        }
    }
}
