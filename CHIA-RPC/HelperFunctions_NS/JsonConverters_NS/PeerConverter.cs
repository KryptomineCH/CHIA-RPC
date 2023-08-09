using System.Text.Json.Serialization;
using System.Text.Json;
using CHIA_RPC.Objects_NS;

public class PeerConverter : JsonConverter<Peer>
{
    public override Peer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        var peer = new Peer();

        reader.Read();
        if (reader.TokenType == JsonTokenType.String)
        {
            peer.peerId = reader.GetString();
        }

        reader.Read();
        if (reader.TokenType == JsonTokenType.Number)
        {
            // Convert the integer value to the corresponding enum type.
            peer.inclusionStatus = (InclusionStatus)reader.GetInt32();
        }

        reader.Read();
        if (reader.TokenType == JsonTokenType.String)
        {
            peer.errorMessage = reader.GetString();
        }

        // Ensure we advance the reader to the end of the array
        while (reader.TokenType != JsonTokenType.EndArray)
        {
            reader.Read();
        }

        return peer;
    }

    public override void Write(Utf8JsonWriter writer, Peer value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        writer.WriteStringValue(value.peerId);
        writer.WriteNumberValue((int)value.inclusionStatus);
        writer.WriteStringValue(value.errorMessage);
        writer.WriteEndArray();
    }
}
