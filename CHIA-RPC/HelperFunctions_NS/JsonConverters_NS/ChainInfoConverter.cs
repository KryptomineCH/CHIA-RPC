using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    public class ChainInfoConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }

            throw new JsonException("Invalid token type for chain_info field");
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }

}
