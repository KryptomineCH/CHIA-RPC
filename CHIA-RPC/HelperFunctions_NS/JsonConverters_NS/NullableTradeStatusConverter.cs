using CHIA_RPC.Objects_NS;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    public class NullableTradeStatusConverter : JsonConverter<TradeStatus?>
    {
        public override TradeStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            string value = reader.GetString();
            try
            {
                return (TradeStatus)Enum.Parse(typeof(TradeStatus), value, true);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Invalid enum value encountered during deserialization: '{value}'");
                throw;
            }
        }

        public override void Write(Utf8JsonWriter writer, TradeStatus? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
