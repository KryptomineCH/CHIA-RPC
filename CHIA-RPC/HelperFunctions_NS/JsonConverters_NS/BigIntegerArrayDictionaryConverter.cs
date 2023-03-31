using System.Numerics;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    public class BigIntegerArrayDictionaryConverter : JsonConverter<Dictionary<string, BigInteger[]>>
    {
        public override Dictionary<string, BigInteger[]> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var result = new Dictionary<string, BigInteger[]>();

            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected start of object.");
            }

            BigIntegerConverter bigIntegerConverter = new BigIntegerConverter();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("Expected property name.");
                }

                string key = reader.GetString();
                reader.Read();
                BigInteger[] values = new BigInteger[2];

                if (reader.TokenType != JsonTokenType.StartArray)
                {
                    throw new JsonException("Expected start of array.");
                }

                for (int i = 0; i < 2; i++)
                {
                    reader.Read();
                    values[i] = bigIntegerConverter.Read(ref reader, typeof(BigInteger), options);
                }

                reader.Read();
                if (reader.TokenType != JsonTokenType.EndArray)
                {
                    throw new JsonException("Expected end of array.");
                }

                result.Add(key, values);
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, BigInteger[]> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            BigIntegerConverter bigIntegerConverter = new BigIntegerConverter();

            foreach (var kvp in value)
            {
                writer.WritePropertyName(kvp.Key);
                writer.WriteStartArray();

                foreach (var bigInteger in kvp.Value)
                {
                    bigIntegerConverter.Write(writer, bigInteger, options);
                }

                writer.WriteEndArray();
            }

            writer.WriteEndObject();
        }
    }
}
