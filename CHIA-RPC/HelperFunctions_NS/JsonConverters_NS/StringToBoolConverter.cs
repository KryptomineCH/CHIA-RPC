using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// A custom JSON converter for converting JSON strings to boolean values. 
    /// </summary>
    /// <remarks>
    /// This class is particularly useful when you're dealing with JSON payloads that represent boolean values as strings (i.e., "true" and "false") 
    /// rather than using the standard JSON boolean values (i.e., true and false without quotes). 
    /// It allows for the deserialization of these string values into .NET boolean values and also handles the reverse during serialization.
    /// </remarks>
    public class StringToBoolConverter : JsonConverter<bool>
    {
        /// <summary>
        /// This method is invoked by the JsonSerializer when it reads the JSON input, providing custom deserialization logic.
        /// </summary>
        /// <param name="reader">The Utf8JsonReader to read the JSON input.</param>
        /// <param name="typeToConvert">The type of the object that is expected to be converted.</param>
        /// <param name="options">The JsonSerializerOptions object that can be used during the conversion.</param>
        /// <returns>A boolean value that is parsed from the JSON input.</returns>
        /// <exception cref="JsonException">Throws a JsonException if the JSON string cannot be parsed to a boolean value.</exception>
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? stringValue = reader.GetString();
            return bool.TryParse(stringValue, out var result) ? result : throw new JsonException($"Invalid value '{stringValue}' for boolean.");
        }
        /// <summary>
        /// This method is invoked by the JsonSerializer when it writes the JSON output, providing custom serialization logic.
        /// </summary>
        /// <param name="writer">The Utf8JsonWriter to write the JSON output.</param>
        /// <param name="value">The boolean value that is to be converted.</param>
        /// <param name="options">The JsonSerializerOptions object that can be used during the conversion.</param>
        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().ToLower());
        }
    }

}
