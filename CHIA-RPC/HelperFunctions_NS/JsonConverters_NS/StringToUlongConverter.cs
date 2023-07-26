using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.HelperFunctions_NS.JsonConverters_NS
{
    /// <summary>
    /// This class defines a custom JSON converter for converting JSON strings to ulong (non-nullable) and vice versa.
    /// It inherits from the JsonConverter class, specifically for ulong type.
    /// </summary>
    /// <remarks>
    /// This class is specifically useful when the JSON input might represent ulong values as strings rather than numbers.
    /// It allows for seamless deserialization of these values into ulong values in .NET.
    /// Moreover, it ensures correct serialization of ulong values back to stringified JSON.
    /// </remarks>
    public class StringToUlongConverter : JsonConverter<ulong>
    {
        /// <summary>
        /// This method overrides the Read method of the base JsonConverter class to handle custom deserialization.
        /// It is called by the JsonSerializer when it reads the JSON input.
        /// </summary>
        /// <param name="reader">The Utf8JsonReader to read the JSON input.</param>
        /// <param name="typeToConvert">The type of the object expected to be converted.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        /// <returns>An ulong value parsed from the JSON input. Returns 0 if parsing is not possible.</returns>
        public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (ulong.TryParse(stringValue, out ulong ulongValue))
                {
                    return ulongValue;
                }
                return 0;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetUInt64();
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// This method overrides the Write method of the base JsonConverter class to handle custom serialization.
        /// It is called by the JsonSerializer when it writes the JSON output.
        /// </summary>
        /// <param name="writer">The Utf8JsonWriter to write the JSON output.</param>
        /// <param name="value">The ulong value to convert.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
    /// <summary>
    /// This class defines a custom JSON converter for converting JSON strings to ulong? (nullable ulong) and vice versa.
    /// It inherits from the JsonConverter class, specifically for ulong? type.
    /// </summary>
    /// <remarks>
    /// This class is specifically useful when the JSON input might represent ulong values as strings rather than numbers.
    /// It allows for seamless deserialization of these values into nullable ulong values in .NET.
    /// Moreover, it ensures correct serialization of nullable ulong values back to stringified JSON.
    /// </remarks>
    public class StringToUlongNullableConverter : JsonConverter<ulong?>
    {
        /// <summary>
        /// This method overrides the Read method of the base JsonConverter class to handle custom deserialization.
        /// It is called by the JsonSerializer when it reads the JSON input.
        /// </summary>
        /// <param name="reader">The Utf8JsonReader to read the JSON input.</param>
        /// <param name="typeToConvert">The type of the object expected to be converted.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        /// <returns>A nullable ulong parsed from the JSON input. Returns null if parsing is not possible.</returns>
        public override ulong? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string stringValue = reader.GetString();
                if (ulong.TryParse(stringValue, out ulong ulongValue))
                {
                    return ulongValue;
                }
                return null;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetUInt64();
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// This method overrides the Write method of the base JsonConverter class to handle custom serialization.
        /// It is called by the JsonSerializer when it writes the JSON output.
        /// </summary>
        /// <param name="writer">The Utf8JsonWriter to write the JSON output.</param>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="options">The JsonSerializerOptions object to use.</param>
        public override void Write(Utf8JsonWriter writer, ulong? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
            {
                writer.WriteStringValue(value.Value.ToString());
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
