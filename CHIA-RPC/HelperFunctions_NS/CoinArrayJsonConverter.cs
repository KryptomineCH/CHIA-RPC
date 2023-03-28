using System.Text.Json.Serialization;
using System.Text.Json;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.HelperFunctions_NS
{
    public class CoinArrayJsonConverter : JsonConverter<Coin[]>
    {
        private CreateCoinJsonConverter _createCoinConverter = new CreateCoinJsonConverter();

        public override Coin[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            var coins = new List<Coin>();

            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    coins.Add(_createCoinConverter.Read(ref reader, typeof(Coin), options));
                }
                else
                {
                    throw new JsonException();
                }
            }

            return coins.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, Coin[] value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var coin in value)
            {
                _createCoinConverter.Write(writer, coin, options);
            }

            writer.WriteEndArray();
        }
    }
}
