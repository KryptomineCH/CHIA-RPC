using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    public class StringToUlongConverter : JsonConverter<ulong>
    {
        public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (ulong.TryParse(stringValue, out ulong ulongValue))
                {
                    return ulongValue;
                }
                return 0;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetUInt64();
            }
            else
            {
                return 0;
            }
        }

        public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
    public class StringToUlongNullableConverter : JsonConverter<ulong?>
    {
        public override ulong? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (ulong.TryParse(stringValue, out ulong ulongValue))
                {
                    return ulongValue;
                }
                return null;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetUInt64();
            }
            else
            {
                return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, ulong? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString());
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

}
