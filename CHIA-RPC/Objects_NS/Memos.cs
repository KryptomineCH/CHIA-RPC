using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// used by GetTransactionMemo
    /// </summary>
    [JsonConverter(typeof(MemoResponseConverter))]
    public class Memo_Response : ResponseTemplate<Memo_Response>
    {
        /// <summary>
        /// contains the data of the response
        /// </summary>
        public Dictionary<string, Dictionary<string, string[]>>? data { get; set; }
    }
    /// <summary>
    /// a memo is of type string and might be attached to a <see cref="Transaction_DictMemos"/>
    /// </summary>
    public class Memos : ObjectTemplate<Memos>
    {
        /// <summary>
        /// the memo of the transaction
        /// </summary>
        public string? memo { get; set; }
    }
    /// <summary>
    /// contains functionality to convert between json string and memo_response
    /// </summary>
    public class MemoResponseConverter : JsonConverter<Memo_Response>
    {
        /// <summary>
        /// converts a string to memo_response
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Memo_Response Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var data = new Dictionary<string, Dictionary<string, string[]>>();
            bool success = false;
            string? error = null;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                string? propertyName = reader.GetString();
                reader.Read();

                if (propertyName == "success")
                {
                    success = reader.GetBoolean();
                }
                else if (propertyName == "error")
                {
                    error = reader.GetString();
                }
                else
                {
                    // Deserialize the inner dictionary
                    var innerData = JsonSerializer.Deserialize<Dictionary<string, string[]>>(ref reader, options);
                    if (propertyName == null)
                    {
                        throw new NullReferenceException(nameof(propertyName));
                    }
                    if (innerData == null)
                    {
                        throw new NullReferenceException(nameof(innerData));
                    }
                    data.Add(propertyName, innerData);
                }
            }

            return new Memo_Response { data = data, success = success, error = error };
        }

        /// <summary>
        /// converts a memo_response object to string
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, Memo_Response value, JsonSerializerOptions options)
        {
            if (value.data == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            writer.WriteStartObject();

            writer.WritePropertyName("success");
            writer.WriteBooleanValue(value.success ?? false);

            if (value.error != null)
            {
                writer.WritePropertyName("error");
                writer.WriteStringValue(value.error);
            }

            foreach (var outerEntry in value.data)
            {
                writer.WritePropertyName(outerEntry.Key);
                writer.WriteStartObject();

                foreach (var innerEntry in outerEntry.Value)
                {
                    writer.WritePropertyName(innerEntry.Key);
                    writer.WriteStartArray();

                    foreach (var arrayElement in innerEntry.Value)
                    {
                        writer.WriteStringValue(arrayElement);
                    }

                    writer.WriteEndArray();
                }

                writer.WriteEndObject();
            }

            writer.WriteEndObject();
        }
    }
}
