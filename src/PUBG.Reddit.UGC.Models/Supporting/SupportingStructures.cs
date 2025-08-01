using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PUBG.Reddit.UGC.Models
{
    // Custom Vector3 converter for compact JSON serialization
    public class Vector3JsonConverter : JsonConverter<Vector3>
    {
        public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                reader.Read();
                var x = reader.GetSingle();
                reader.Read();
                var y = reader.GetSingle();
                reader.Read();
                var z = reader.GetSingle();
                reader.Read(); // End array
                return new Vector3(x, y, z);
            }
            
            throw new JsonException("Vector3 JSON must be in array format [x,y,z]");
        }

        public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteNumberValue(value.Z);
            writer.WriteEndArray();
        }
    }

    [JsonConverter(typeof(Vector3JsonConverter))]
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
 
}
