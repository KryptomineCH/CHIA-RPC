using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// Provides functionality for converting chain info to and from JSON.
    /// This converter specifically handles chain info represented as strings.
    /// </summary>
    public class ChainInfoConverter : JsonConverter<string>
    {
        /// <summary>
        /// Reads the chain info from the JSON object.
        /// </summary>
        /// <param name="reader">A Utf8JsonReader positioned at the start of the string to read.</param>
        /// <param name="typeToConvert">The Type of object that the converted string will be converted to.</param>
        /// <param name="options">Options that specify how the conversion should take place.</param>
        /// <returns>The string representation of the chain info, if it can be converted; otherwise null.</returns>
        /// <exception cref="JsonException">Thrown when the TokenType is not String.</exception>
        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }

            throw new JsonException("Invalid token type for chain_info field");
        }

        /// <summary>
        /// Writes the chain info to a JSON object.
        /// </summary>
        /// <param name="writer">A Utf8JsonWriter into which the string will be written.</param>
        /// <param name="value">The string representation of the chain info to write.</param>
        /// <param name="options">Options that specify how the conversion should take place.</param>
        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}

