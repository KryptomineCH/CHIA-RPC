using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Represents the response from the get_recent_signage_point_or_eos RPC call.
    /// </summary>
    /// <remarks>
    /// request uses a <see cref="GetRecentSignagePointOrEos_RPC"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/>
    /// </remarks>
    public class GetRecentSignagePointOrEos_Response : ResponseTemplate<GetRecentSignagePointOrEos_Response>
    {
        /// <summary>
        /// End of slot data.
        /// </summary>
        public Eos eos { get; set; }

        /// <summary>
        /// Indicates if the data has been reverted.
        /// </summary>
        public bool reverted { get; set; }

        /// <summary>
        /// Time when the response was received.
        /// </summary>
        public double time_received { get; set; }
    }
    /// <summary>
    /// Retrieves a recent signage point or end of slot<br/>
    /// *Either sp_hash or challenge_hash are required to be included in the query*
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/></remarks>
    /// <returns><see cref="GetRecentSignagePointOrEos_Response"/></returns>
    public class GetRecentSignagePointOrEos_RPC : RPCTemplate<GetRecentSignagePointOrEos_RPC>
    {
        /// <summary>
        /// Gets or sets the hash of the output for a signage point (if it's in the middle of a sub slot).
        /// </summary>
        public string sp_hash { get; set; }
        /// <summary>
        /// Gets or sets the challenge_hash for the subslot (if it's an end of sub slot challenge).
        /// </summary>
        public string challenge_hash { get; set; }
    }
}
