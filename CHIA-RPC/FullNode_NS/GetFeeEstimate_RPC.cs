using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// Contains information about the estimated Transaction Fees from the Chia Client
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_fee_estimate"/><br/><br/>
    /// Uses:<br/><see cref="GetFeeEstimate_RPC"/>
    /// </remarks>
    public class GetFeeEstimate_Response : ResponseTemplate<GetFeeEstimate_Response>
    {
        /// <summary>
        /// Current fee rate in mojos per byte.
        /// </summary>
        public decimal current_fee_rate { get; set; }

        /// <summary>
        /// Estimated fee for each targeted time in seconds.
        /// </summary>
        /// <remarks>in mojos</remarks>
        public ulong[] estimates { get; set; }
        /// <summary>
        /// Estimated fee for each targeted time in seconds.
        /// </summary>
        /// <remarks>in mojos</remarks>
        [JsonIgnore]
        public decimal[] estimates_in_xch { get
            {
                List<decimal> result = new List<decimal>();
                foreach(decimal fee in estimates)
                {
                    result.Add(fee / GlobalVar.OneChiaInMojos);
                }
                return result.ToArray();
            } 
        }

        /// <summary>
        /// the actual fee rate of the last block
        /// </summary>
        public decimal fee_rate_last_block { get; set; }

        /// <summary>
        /// The accumulated fees of the last block in mojos
        /// </summary>
        public ulong fees_last_block { get; set; }
        /// <summary>
        /// The accumulated fees of the last block in mojos
        /// </summary>
        [JsonIgnore]
        public decimal fees_last_block_in_xch
        {
            get { return fees_last_block / GlobalVar.OneChiaInMojos; }
            set { fees_last_block = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// Whether or not the full node is synced.
        /// </summary>
        public bool full_node_synced { get; set; }

        /// <summary>
        /// the total cost of the last block
        /// </summary>
        public ulong last_block_cost { get; set; }

        /// <summary>
        /// Timestamp in seconds of the last peak.
        /// </summary>
        public ulong last_peak_timestamp { get; set; }

        /// <summary>
        /// the mempool fees in mojos
        /// </summary>
        public ulong mempool_fees { get; set; }
        /// <summary>
        /// the mempool fees in xch
        /// </summary>
        [JsonIgnore]
        public decimal mempool_fees_in_xch
        {
            get { return mempool_fees / GlobalVar.OneChiaInMojos; }
            set { mempool_fees = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// the block height of the last block
        /// </summary>
        public ulong last_tx_block_height { get; set; }

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
        /// the amount of block spends
        /// </summary>
        public ulong num_spends { get; set; }

        /// <summary>
        /// The height of the last peak.
        /// </summary>
        public ulong peak_height { get; set; }

        /// <summary>
        /// Targeted times for transaction inclusion, in seconds.
        /// </summary>
        public ulong[] target_times { get; set; }
        /// <summary>
        /// Targeted times for transaction inclusion
        /// </summary>
        [JsonIgnore]
        public TimeSpan[] target_times_converted {
            get
            {
                TimeSpan[] targets = new TimeSpan[target_times.Length];
                for (int i = 0; i < target_times.Length; i++)
                {
                    targets[i] = TimeSpan.FromSeconds(target_times[i]);
                }
                return targets;
            }
        }
    }
    /// <summary>
    /// Contains the request parameters for the get_fee_estimate RPC method. <br/>
    /// Used to obtain an estimated fee for one or more targeted times for a transaction to be included in the blockchain.<br/><br/>
    /// Explicit conversions exist so you can call:<br/><br/>
    /// <code>
    /// GetFeeEstimate_RPC rpc = TimeSpan.FromMinutes(5);
    /// GetFeeEstimate_RPC rpc = new TimeSpan[] {TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(15)};
    /// GetFeeEstimate_Response fees = Client.GetFeeEstimate_Sync(TimeSpan.FromMinutes(5));
    /// </code>
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_fee_estimate"/></remarks>
    /// <returns><see cref="GetFeeEstimate_Response"/></returns>
    public class GetFeeEstimate_RPC : RPCTemplate<GetFeeEstimate_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        public GetFeeEstimate_RPC() { /* for serialisation */ }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_times">an array of the targeted times for transaction inclusion, in seconds.</param>
        /// <param name="cost">The CLVM cost for which to estimate the fee. (default transaction = 10000000)</param>
        public GetFeeEstimate_RPC(ulong[] target_times, ulong cost = 10000000)
        {
            this.cost = cost;
            this.target_times = target_times;
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_times">an array of the targeted times for transaction inclusion, in seconds.</param>
        /// <param name="spend_bundle">The spend bundle file (in json format) for which to estimate the fee.</param>
        public GetFeeEstimate_RPC(ulong[] target_times, string spend_bundle)
        {
            this.spend_bundle = spend_bundle;
            this.target_times = target_times;
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_times">an array of the targeted times for transaction inclusion, in seconds.</param>
        /// <param name="spend_bundle">The spend bundle file (in json format) for which to estimate the fee.</param>
        public GetFeeEstimate_RPC(TimeSpan[] target_times, string spend_bundle)
        {
            this.spend_bundle = spend_bundle;
            List<ulong> targets = new List<ulong>();
            foreach (TimeSpan targetTime in target_times)
            {
                targets.Add((ulong)targetTime.TotalSeconds);
            }
            this.target_times = targets.ToArray();
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_times">an array of the targeted times for transaction inclusion, in seconds.</param>
        /// <param name="cost">The CLVM cost for which to estimate the fee. (default transaction = 10000000)</param>
        public GetFeeEstimate_RPC(TimeSpan[] target_times, ulong cost = 10000000)
        {
            this.cost = cost;
            List<ulong> targets = new List<ulong>();
            foreach (TimeSpan targetTime in target_times)
            {
                targets.Add((ulong)targetTime.TotalSeconds);
            }
            this.target_times = targets.ToArray();
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_time">the targeted time for transaction inclusion, in seconds.</param>
        /// <param name="cost">The CLVM cost for which to estimate the fee. (default transaction = 10000000)</param>
        public GetFeeEstimate_RPC(ulong target_time, ulong cost = 10000000)
        {
            this.cost = cost;
            this.target_times = new ulong[] { target_time };
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_time">the targeted time for transaction inclusion, in seconds.</param>
        /// <param name="spend_bundle">The spend bundle file (in json format) for which to estimate the fee.</param>
        public GetFeeEstimate_RPC(ulong target_time, string spend_bundle)
        {
            this.spend_bundle = spend_bundle;
            this.target_times = new ulong[] { target_time };
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_time">the timespan in which the transaction should be executed</param>
        /// <param name="spend_bundle">The spend bundle file (in json format) for which to estimate the fee.</param>
        public GetFeeEstimate_RPC(TimeSpan target_time, string spend_bundle)
        {
            this.spend_bundle = spend_bundle;
            List<ulong> targets = new List<ulong>();
            targets.Add((ulong)target_time.TotalSeconds);
            this.target_times = targets.ToArray();
        }
        /// <summary>
        /// Contains the request parameters for the get_fee_estimate RPC method. 
        /// </summary>
        /// <remarks><b><u>Minimum</u></b> target time is roughly <b><u>30 seconds</u></b></remarks>
        /// <param name="target_time">the timespan in which the transaction should be executed</param>
        /// <param name="cost">The CLVM cost for which to estimate the fee. (default transaction = 10000000)</param>
        public GetFeeEstimate_RPC(TimeSpan target_time, ulong cost = 10000000)
        {
            this.cost = cost;
            List<ulong> targets = new List<ulong>();
            targets.Add((ulong)target_time.TotalSeconds);
            this.target_times = targets.ToArray();
        }

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
        /// <summary>
        /// automatically converts a targettime into the rpc
        /// </summary>
        /// <param name="target_time">the requested time</param>
        public static explicit operator GetFeeEstimate_RPC(TimeSpan target_time)
        {
            return new GetFeeEstimate_RPC(target_time);
        }
        /// <summary>
        /// automatically converts target times into the rpc
        /// </summary>
        /// <param name="target_times">the requested times</param>
        public static explicit operator GetFeeEstimate_RPC(TimeSpan[] target_times)
        {
            return new GetFeeEstimate_RPC(target_times);
        }
    }
}
