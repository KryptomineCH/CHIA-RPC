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
        public Dictionary<string, Dictionary<string, string[]>> data { get; set; }
    }
    /// <summary>
    /// a memo is of type string and might be attached to a <see cref="Transaction"/>
    /// </summary>
    public class Memos : ObjectTemplate<Memos>
    {
        public string memo { get; set; }
    }
    public class MemoResponseConverter : JsonConverter<Memo_Response>
    {
        public override Memo_Response Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var data = new Dictionary<string, Dictionary<string, string[]>>();
            bool success = false;
            string error = null;

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

                string propertyName = reader.GetString();
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
                    data.Add(propertyName, innerData);
                }
            }

            return new Memo_Response { data = data, success = success, error = error };
        }

        public override void Write(Utf8JsonWriter writer, Memo_Response value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("success");
            writer.WriteBooleanValue(value.success);

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
