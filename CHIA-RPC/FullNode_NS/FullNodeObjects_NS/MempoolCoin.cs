using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents a coin in the memory pool (mempool) of a Chia blockchain network node.
    /// </summary>
    /// <remarks>
    /// The memory pool (or mempool) is a collection of transactions that are waiting to be confirmed by the network.
    /// This class encapsulates the necessary properties for a coin in the mempool, including its value, memo, and associated puzzle hash.
    /// </remarks>
    public class MempoolCoin : ObjectTemplate<MempoolCoin>
    {
        /// <summary>
        /// The value of the coin in smallest units of the currency, i.e., mojos.
        /// </summary>
        /// <remarks>
        /// This property is used by both full nodes and wallet nodes.
        /// Refer to Chia's full node RPC documentation for more details:<br/>
        /// <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/>
        /// </remarks>
        public ulong amount { get; set; }

        /// <summary>
        /// The value of the coin in the base units of the currency, i.e., XCH (Chia).
        /// </summary>
        /// <remarks>
        /// This value is derived from the 'amount' property, which is expressed in mojos.
        /// It provides a more user-friendly representation of the coin's value.
        /// </remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The memo associated with the coin.
        /// </summary>
        /// <remarks>
        /// Memos are optional metadata associated with a coin.
        /// If the first value is a 32 bytes long, it is treated as a hint.
        /// </remarks>
        public string? memos { get; set; }

        /// <summary>
        /// The puzzle hash of this coin.
        /// </summary>
        /// <remarks>
        /// Puzzle hashes are part of the Chia protocol and are associated with coin creation and spending.
        /// When a coin is in the mempool or in the process of creation, its own puzzle hash can be unknown because the coin is yet to be minted.
        /// </remarks>
        public string? puzzle_hash { get; set; }
    }

}
