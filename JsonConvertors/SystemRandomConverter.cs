using System;
using System.Collections.Generic;
using System.Linq;
using Modding;
using Newtonsoft.Json;

namespace Satchel.JsonConvertors
{
    /// <summary>
    /// A class to help serialize a System.Random Object for global settings and or save settings 
    /// <para/>To use this, add the line [JsonConverter(typeof(Satchel.JsonConvertors.RandomConverter))] above the System.Random Object in the settings class 
    /// </summary>
    public class SystemRandomConverter : JsonConverter<Random>
    {
        public override void WriteJson(JsonWriter writer, Random value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            
            /* System.Random has 3 const int we dont care about to serialize because it is const
             * the 3 fields we do care about is inext (int), inextp(int), SeedArray(int[])
             * so we get these and write them in the json. */
            
            //we use reflection because fields are private
            int inext = ReflectionHelper.GetField<Random, int>(value, "inext");
            writer.WritePropertyName("inext");
            writer.WriteValue(inext);

            int inextp = ReflectionHelper.GetField<Random, int>(value, "inextp");
            writer.WritePropertyName("inextp");
            writer.WriteValue(inextp);
            
            int[] SeedArray = ReflectionHelper.GetField<Random, int[]>(value, "SeedArray");
            writer.WritePropertyName("SeedArray");
            writer.WriteStartArray();
            SeedArray.ToList().ForEach(writer.WriteValue);
            writer.WriteEndArray();
            
            writer.WriteEndObject();
        }

        public override Random ReadJson(JsonReader reader, Type objectType, Random existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            reader.Read(); //property name
            reader.Read(); //inext value
            int inext = Convert.ToInt32(reader.Value);
            
            reader.Read(); //property name
            reader.Read(); //inextp value
            int inextp = Convert.ToInt32(reader.Value);

            reader.Read(); //property name
            reader.Read(); //Writer.WriteStartArray() token
            
            List<int> SeedArrayList = new List<int>();//so it is easier to add elements in while loop
            
            //read until we read Writer.WriteEndArray();
            while (reader.TokenType != JsonToken.EndArray)
            {
                reader.Read(); //value of element in array
                SeedArrayList.Add(Convert.ToInt32(reader.Value));
            }

            int[] SeedArray = SeedArrayList.ToArray();

            //create new random object and use reflection to set the private fields
            System.Random random = new System.Random();
            ReflectionHelper.SetField(random, "inext", inext);
            ReflectionHelper.SetField(random, "inextp", inextp);
            ReflectionHelper.SetField(random, "SeedArray", SeedArray);

            return random;
        }
    }
}