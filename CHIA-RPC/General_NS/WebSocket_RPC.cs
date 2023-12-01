using CHIA_RPC.Daemon_NS.KeychainServer_NS;
using CHIA_RPC.Daemon_NS.KeychainServer_NS.KeychainServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// contains the fingerprint (unique ID of a wallet)
    /// </summary>
    public class WebSocket_Response : ResponseTemplate<WebSocket_Response>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        
    }

    /// <summary>
    /// used for a variety of wallet management and wallet selection tasks
    /// </summary>
    /// <remarks>
    /// an implicit conversion from <see cref="ulong"/> exists<br/>
    /// an implicit conversion from <see cref="FingerPrint_Response"/> exists<br/>
    /// an implicit conversion from <see cref="Key"/> exists<br/>
    /// an implicit conversion from <see cref="GetKey_Response"/> exists<br/>
    /// </remarks>
    public class WebSocket_RPC : RPCTemplate<WebSocket_RPC>
    {
        public WebSocket_RPC() { }
        /// <summary>
        /// represents the payload structure to interact with the Websocket.
        /// </summary>
        /// <param name="command">the command which should be executed on the target endpoint</param>
        /// <param name="endpoint">the endpoint where this request should be routed to</param>
        /// <param name="data">the rpc payload for the target endpoint</param>
        /// <param name="requestId">the identifier of this request</param>
        /// <param name="origin">where this request came from</param>
        public WebSocket_RPC(string command, Endpoint endpoint, string data, int requestId, string origin)
        {
            this.command = command;
            this.data = data;
            this.destination = endpoint;
            this.request_id = requestId;
            this.origin = origin;
        }
        /// <summary>
        /// the command which should be executed on the endpoint
        /// </summary>
        public string command { get; set; }
        public bool ack { get; set; } = true;
        /// <summary>
        /// the payload rpc to send
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// the identifier of the rpquest
        /// </summary>
        public int request_id { get; set; }
        /// <summary>
        /// the target endpoint
        /// </summary>
        [JsonConverter(typeof(StringToEnumConverter<Endpoint>))]
        public Endpoint destination { get; set; }
        /// <summary>
        /// where this request came from
        /// </summary>
        public string origin { get; set; }
    }
}
