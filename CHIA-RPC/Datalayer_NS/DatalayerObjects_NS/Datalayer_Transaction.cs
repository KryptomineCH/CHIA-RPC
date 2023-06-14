using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.DatalayerObjects_NS
{
    /// <summary>
    /// a general transaction
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/><br/>
    /// </remarks>
    public class Datalayer_Transaction : ObjectTemplate<Datalayer_Transaction>
    {
        /// <summary>
        /// The coins which are (or will be) created by this transaction.
        /// </summary>
        /// <remarks>For a standard chia transaction, these are 1-2 coins (1 to the recipient and 1 to yourself with the change if needed)<br/>
        /// The hash values in the Coins can be used to look the transactions up in Blockchain explorers</remarks>
        public Coin[] additions { get; set; }
        /// <summary>
        /// the transaction amount in mojos
        /// </summary>
        public ulong amount { get; set; }
        /// <summary>
        /// the transaction amount in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Indicates that a Transaction has been submitted and Processed by a Full Node
        /// </summary>
        public bool confirmed { get; set; }
        /// <summary>
        /// The block in which the transaction was included
        /// </summary>
        public ulong confirmed_at_height { get; set; }
        /// <summary>
        /// probably a unix timestamp of the Block in which the transaction was included
        /// </summary>
        public ulong created_at_time { get; set; }
        /// <summary>
        /// the fee amount in mojos
        /// </summary>
        public ulong fee_amount { get; set; }
        /// <summary>
        /// the transaction amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal fee_amount_in_xch
        {
            get { return fee_amount / GlobalVar.OneChiaInMojos; }
            set { fee_amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// note: could not be validated yet
        /// </summary>
        public string[] memos { get; set; }
        /// <summary>
        /// This is the transaction ID!!!
        /// </summary>
        /// <remarks>This is NOT what you will find from Blockchain explorers. Get the Hashes from the Coins (additions) instead!</remarks>
        public string name { get; set; }
        /// <summary>
        /// The Coins which are removed from your wallet to create the new coins
        /// </summary>
        public Coin[] removals { get; set; }
        public ulong sent { get; set; }
        public dynamic[] sent_to { get; set; }
        public SpendBundle spend_bundle { get; set; }
        /// <summary>
        /// the address/recipient of this transaction
        /// </summary>
        public string to_address { get; set; }
        public string to_puzzle_hash { get; set; }
        public string trade_id { get; set; }
        public ulong type { get; set; }
        /// <summary>
        /// the wallet ID which this transaction was sent from
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
