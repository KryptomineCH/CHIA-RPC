using System.Text.Json.Serialization;
using System.Text.Json;
using CHIA_RPC.Wallet_NS.NFT_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// Custom JsonConverter for NftCalculateRoyalties_Response class
    /// </summary>
    public class NftCalculateRoyaltiesResponseConverter : JsonConverter<NftCalculateRoyalties_Response>
    {
        /// <summary>
        /// converts a json string to a NftCalculateRoyalties_Response
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        public override NftCalculateRoyalties_Response Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Expect a StartObject token at the beginning of the JSON
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected StartObject token.");
            }

            var response = new NftCalculateRoyalties_Response();
            response.NFTTrade = new Dictionary<string, TradeData[]>();

            // Read through the JSON properties
            while (reader.Read())
            {
                // Break the loop when the EndObject token is encountered
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                // Process the property names
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();

                    // If the property is 'success', read its value as a boolean
                    if (propertyName == "success")
                    {
                        reader.Read();
                        response.success = reader.GetBoolean();
                    }
                    else
                    {
                        // For other properties, deserialize the value as an array of TradeData objects
                        var tradeDataArray = JsonSerializer.Deserialize<TradeData[]>(ref reader, options);
                        if (propertyName == null)
                        {
                            throw new NullReferenceException(nameof(propertyName));
                        }
                        if (tradeDataArray == null)
                        {
                            throw new NullReferenceException(nameof(tradeDataArray));
                        }
                        response.NFTTrade[propertyName] = tradeDataArray;
                    }
                }
            }

            return response;
        }

        /// <summary>
        /// Write JSON for the NftCalculateRoyalties_Response class
        /// </summary>
        /// <param name="writer">The Utf8JsonWriter to write JSON to</param>
        /// <param name="value">The NftCalculateRoyalties_Response object to serialize</param>
        /// <param name="options">JsonSerializerOptions for customizing serialization</param>
        public override void Write(Utf8JsonWriter writer, NftCalculateRoyalties_Response value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            // Write the 'success' property
            writer.WritePropertyName("success");
            writer.WriteBooleanValue(value.success ?? false);

            // Iterate through the NFTTrade dictionary and write the key-value pairs
            if (value.NFTTrade != null)
            {
                foreach (var kvp in value.NFTTrade)
                {
                    writer.WritePropertyName(kvp.Key);
                    JsonSerializer.Serialize(writer, kvp.Value, options);
                }
            }

            writer.WriteEndObject();
        }
    }
}
