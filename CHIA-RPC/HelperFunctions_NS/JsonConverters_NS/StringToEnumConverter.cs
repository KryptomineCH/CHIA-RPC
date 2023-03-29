using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    public class StringToEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
    {
        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string stringValue = reader.GetString();
            return Enum.TryParse<TEnum>(stringValue, true, out var result) ? result : throw new JsonException($"Invalid value '{stringValue}' for {typeof(TEnum).Name}.");
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

}
