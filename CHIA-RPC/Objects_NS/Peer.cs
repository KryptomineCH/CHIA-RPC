using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// represents a peer node?
    /// </summary>
    /// <remarks>no official documentation available.<br/>
    /// check <see href="https://docs.chia.net/walletconnect-commands/?_highlight=sent#peer"/> for updates
    /// </remarks>
    [JsonConverter(typeof(PeerConverter))]
    public class Peer : ObjectTemplate<Peer>
    {
        /// <summary>
        /// Peer id.
        /// </summary>
        public string? peerId { get; set; }
        /// <summary>
        /// Inclusion status.
        /// </summary>
        public InclusionStatus? inclusionStatus { get; set; }
        /// <summary>
        /// Error message, if present.
        /// </summary>
        public string? errorMessage { get; set; }
    }
}
