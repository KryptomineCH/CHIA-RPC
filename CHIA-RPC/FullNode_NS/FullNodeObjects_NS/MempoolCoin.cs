using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    public class MempoolCoin : ObjectTemplate<MempoolCoin>
    {
        /// <summary>
        /// the coins value in mojos
        /// </summary>
        /// <remarks>
        /// used by full node and wallet node<br/>
        /// <see href="https://docs.chia.net/full-node-rpc#get_coin_record_by_name"/>
        /// </remarks>
        public ulong amount { get; set; }
        /// <summary>
        /// the coins value in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The memos
        /// </summary>
        /// <remarks>if first value is a 32 bytes long, we treat it as a hint</remarks>
        public string memos { get; set; }

        /// <summary>
        /// the puzzle hash of this coin
        /// </summary>
        /// <remarks>When in the Mempool and for creation, the own puzzhash can be unknown (since the coin is yet to be minted)</remarks>
        public string puzzle_hash { get; set; }
    }
}
