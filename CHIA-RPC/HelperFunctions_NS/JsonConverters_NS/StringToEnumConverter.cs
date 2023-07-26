using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// This class provides a custom JSON converter that enables the conversion of JSON strings to .NET Enum values.
    /// It is particularly useful when you're dealing with JSON that represents Enums as strings.
    /// </summary>
    /// <typeparam name="TEnum">The type of the Enum that this converter handles. Must be a struct and Enum.</typeparam>
    /// <remarks>
    /// This class can handle JSON strings that represent Enum values and convert them correctly to the corresponding Enum type in .NET during deserialization.
    /// During serialization, it converts the Enum values back to their string representation.
    /// </remarks>
    public class StringToEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
    {
        /// <summary>
        /// This method overrides the Read method of the base JsonConverter class for custom deserialization logic.
        /// It is invoked by the JsonSerializer when it reads the JSON input.
        /// </summary>
        /// <param name="reader">The Utf8JsonReader to read the JSON input.</param>
        /// <param name="typeToConvert">The type of the object expected to be converted.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        /// <returns>A value of type TEnum parsed from the JSON input.</returns>
        /// <exception cref="JsonException">Throws JsonException if the JSON string cannot be parsed to the Enum type.</exception>
        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? stringValue = reader.GetString();
            return Enum.TryParse<TEnum>(stringValue, true, out var result) ? result : throw new JsonException($"Invalid value '{stringValue}' for {typeof(TEnum).Name}.");
        }
        /// <summary>
        /// This method overrides the Write method of the base JsonConverter class for custom serialization logic.
        /// It is invoked by the JsonSerializer when it writes the JSON output.
        /// </summary>
        /// <param name="writer">The Utf8JsonWriter to write the JSON output.</param>
        /// <param name="value">The value of type TEnum to convert.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
