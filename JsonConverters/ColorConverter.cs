using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ColorUtility.TryParseHtmlString("#" + reader.Value, out Color loadedColor);
                return loadedColor;
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to parse color {objectType} : {ex.Message}");
                return new Color(1, 1, 1, 1);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string val = ColorUtility.ToHtmlStringRGB((Color)value);
            writer.WriteValue(val);
        }
    }
}
