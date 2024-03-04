using System.Text.Json.Serialization;
using System.Text.Json;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// The MempoolCoinArrayJsonConverter is a specialized JSON converter used to handle the serialization and deserialization of an array of MempoolCoin objects.
    /// MempoolCoin represents a coin that is currently in the memory pool (mempool), which is a set of unconfirmed transactions that a node has verified as valid but are not yet confirmed on the blockchain.
    /// </summary>
    /// <remarks>
    /// This class is used to ensure correct parsing of JSON when dealing with arrays of MempoolCoin objects. It leverages a specific converter for individual MempoolCoin instances, and applies this converter for each object in the array.
    /// This can help to prevent parsing errors, and makes it easier to deal with complex nested structures where each MempoolCoin might have a different structure or set of properties.
    /// </remarks>
    public class MempoolCoinArrayJsonConverter : JsonConverter<MempoolCoin[]>
    {
        /// <summary>
        /// Instance of the JSON converter used for individual MempoolCoin objects.
        /// </summary>
        private CreateMempoolCoinJsonConverter _createCoinConverter = new CreateMempoolCoinJsonConverter();

        /// <summary>
        /// Reads and converts the JSON to type MempoolCoin array.
        /// </summary>
        /// <param name="reader">The reader to read the JSON data from.</param>
        /// <param name="typeToConvert">The type of object to convert the JSON data to. In this case, it's an array of MempoolCoin objects.</param>
        /// <param name="options">The options to use while reading.</param>
        /// <returns>An array of MempoolCoin objects represented by the JSON data.</returns>
        public override MempoolCoin[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array in the JSON payload.");
            }

            var coins = new List<MempoolCoin>();

            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
            {
                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    reader.Read(); // Move to the first element of the sub-array
                    var puzzleHash = reader.TokenType != JsonTokenType.Null ? reader.GetString() : null; // Adjusted to handle null
                    reader.Read(); // Move to the second element
                    var amount = reader.GetUInt64();
                    reader.Read(); // Move to the third element (null or memo)
                    string? memo = reader.TokenType != JsonTokenType.Null ? reader.GetString() : null;

                    coins.Add(new MempoolCoin
                    {
                        puzzle_hash = puzzleHash,
                        amount = amount,
                        memos = memo
                    });

                    // Ensure the reader moves past the current sub-array
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        reader.Read();
                    }
                }
                else
                {
                    throw new JsonException($"Unexpected token {reader.TokenType} at {reader.TokenStartIndex}. Expected JsonTokenType.StartArray.");
                }
            }

            return coins.ToArray();
        }


        /// <summary>
        /// Writes a MempoolCoin array to JSON.
        /// </summary>
        /// <param name="writer">The writer to write the JSON data to.</param>
        /// <param name="value">The value to convert to JSON data. In this case, it's an array of MempoolCoin objects.</param>
        /// <param name="options">The options to use while writing.</param>
        public override void Write(Utf8JsonWriter writer, MempoolCoin[] value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var coin in value)
            {
                writer.WriteStartArray();

                // Write puzzle_hash. If it's null, write a null value; otherwise, write the string value.
                if (string.IsNullOrEmpty(coin.puzzle_hash))
                {
                    writer.WriteNullValue();
                }
                else
                {
                    writer.WriteStringValue(coin.puzzle_hash);
                }

                // Write amount
                writer.WriteNumberValue(coin.amount);

                // Write memos. Similar to puzzle_hash, if it's null, write a null value.
                if (string.IsNullOrEmpty(coin.memos))
                {
                    writer.WriteNullValue();
                }
                else
                {
                    writer.WriteStringValue(coin.memos);
                }

                writer.WriteEndArray();
            }

            writer.WriteEndArray();
        }


    }
}
