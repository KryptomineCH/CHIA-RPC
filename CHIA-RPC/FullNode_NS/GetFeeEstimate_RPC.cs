using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Contains information about the estimated Transaction Fees from the Chia Client
    /// </summary>
    /// <remarks>
    /// the request uses a <see cref="GetFeeEstimate_RPC"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_fee_estimate"/>
    /// </remarks>
    public class GetFeeEstimate_Response : ResponseTemplate<GetFeeEstimate_Response>
    {
        /// <summary>
        /// Current fee rate in mojos per byte.
        /// </summary>
        public ulong current_fee_rate { get; set; }

        /// <summary>
        /// Estimated fee for each targeted time in seconds.
        /// </summary>
        public ulong[] estimates { get; set; }

        /// <summary>
        /// Whether or not the full node is synced.
        /// </summary>
        public bool full_node_synced { get; set; }

        /// <summary>
        /// Timestamp in seconds of the last peak.
        /// </summary>
        public ulong last_peak_timestamp { get; set; }

        /// <summary>
        /// Maximum size of the mempool in bytes.
        /// </summary>
        public ulong mempool_max_size { get; set; }

        /// <summary>
        /// Current size of the mempool in bytes.
        /// </summary>
        public ulong mempool_size { get; set; }

        /// <summary>
        /// The current UTC timestamp of the node.
        /// </summary>
        public ulong node_time_utc { get; set; }

        /// <summary>
        /// The height of the last peak.
        /// </summary>
        public ulong peak_height { get; set; }

        /// <summary>
        /// Targeted times for transaction inclusion, in seconds.
        /// </summary>
        public ulong[] target_times { get; set; }
    }
    /// <summary>
    /// Contains the request parameters for the get_fee_estimate RPC method. 
    /// Used to obtain an estimated fee for one or more targeted times for a transaction to be included in the blockchain.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_fee_estimate"/></remarks>
    /// <returns><see cref="GetFeeEstimate_Response"/></returns>
    public class GetFeeEstimate_RPC : RPCTemplate<GetFeeEstimate_RPC>
    {
        /// <summary>
        /// The spend bundle file (in json format) for which to estimate the fee. 
        /// Exactly one of spend_bundle or cost must be specified.
        /// </summary>
        /// <remarks>
        /// either spend_bundle or cost need to be specified
        /// </remarks>
        public string? spend_bundle { get; set; }

        /// <summary>
        /// The CLVM cost for which to estimate the fee. 
        /// Exactly one of spend_bundle or cost must be specified.
        /// </summary>
        /// <remarks>
        /// either spend_bundle or cost need to be specified
        /// </remarks>
        public ulong? cost { get; set; }

        /// <summary>
        /// An array of the targeted times for transaction inclusion, in seconds. 
        /// Each targeted time must be at least 0.
        /// </summary>
        public ulong[] target_times { get; set; }
    }
}
