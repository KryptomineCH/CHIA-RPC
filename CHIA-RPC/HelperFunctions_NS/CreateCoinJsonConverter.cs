using System.Text.Json.Serialization;
using System.Text.Json;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.HelperFunctions_NS
{
    public class CreateMempoolCoinJsonConverter : JsonConverter<MempoolCoin>
    {
        public override MempoolCoin Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            string parent_coin_info = null;
            if (reader.TokenType != JsonTokenType.Null)
            {
                parent_coin_info = reader.GetString();
            }

            reader.Read();
            ulong amount = reader.GetUInt64();
            reader.Read();

            string puzzle_hash = null;
            if (reader.TokenType != JsonTokenType.Null)
            {
                puzzle_hash = reader.GetString();
            }


            reader.Read(); // EndArray

            return new MempoolCoin
            {
                puzzle_hash = puzzle_hash,
                amount = amount,
                memos = parent_coin_info
            };
        }

        public override void Write(Utf8JsonWriter writer, MempoolCoin value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteStringValue(value.memos);
            writer.WriteNumberValue(value.amount);
            writer.WriteStringValue(value.puzzle_hash);
            writer.WriteEndArray();
        }
    }
}
