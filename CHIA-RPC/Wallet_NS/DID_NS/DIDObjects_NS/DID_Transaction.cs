using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.DID_NS.DIDObjects_NS
{
    /// <summary>
    /// Represents a Decentralized Identifier (DID) transaction in the Chia blockchain.
    /// </summary>
    /// <remarks>
    /// For more information, see: <see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/><br/>
    /// </remarks>
    public class DID_Transaction : ObjectTemplate<DID_Transaction>
    {
        /// <summary>
        /// The coins which are (or will be) created by this transaction.
        /// </summary>
        /// <remarks>
        /// These coins are represented by the Coin class, which includes properties such as the coin's parent coin info, puzzle hash, and amount.
        /// </remarks>
        public Coin[]? additions { get; set; }

        /// <summary>
        /// The transaction amount in mojos.
        /// </summary>
        /// <remarks>
        /// Chia's smallest unit is mojo. 1 XCH (Chia) is equivalent to 1,000,000,000,000 mojos.
        /// </remarks>
        public ulong? amount { get; set; }
        /// <summary>
        /// the amount of xch to send
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Indicates that a Transaction has been submitted and Processed by a Full Node.
        /// </summary>
        public bool? confirmed { get; set; }

        /// <summary>
        /// The block in which the transaction was included.
        /// </summary>
        public ulong? confirmed_at_height { get; set; }

        /// <summary>
        /// The timestamp when the transaction was created, likely represented as a Unix timestamp.
        /// </summary>
        public ulong? created_at_time { get; set; }

        /// <summary>
        /// The fee amount for the transaction, in mojos.
        /// </summary>
        public ulong? fee_amount { get; set; }
        /// <summary>
        /// the amount of xch to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? fee_amount_in_xch
        {
            get { return fee_amount / GlobalVar.OneChiaInMojos; }
            set { fee_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Dictionary to store memo information in a key-value pair format. The details and validation of this property are still unclear.
        /// </summary>
        public Dictionary<string, string>? memos { get; set; }

        /// <summary>
        /// The unique identifier of the transaction.
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// The coins that are spent from the wallet to create the new coins (additions).
        /// </summary>
        public Coin[]? removals { get; set; }
        /// <summary>
        /// The total amount of Chia (XCH) sent in this transaction.
        /// </summary>
        public ulong? sent { get; set; }

        /// <summary>
        /// Represents the addresses to which the XCH was sent.
        /// </summary>
        /// <remarks>
        /// This is a dynamic array and can accommodate multiple recipient addresses.
        /// </remarks>
        public dynamic[]? sent_to { get; set; }

        /// <summary>
        /// Represents the spend bundle associated with this transaction.
        /// </summary>
        /// <remarks>
        /// The SpendBundle is a fundamental concept in Chia's blockchain, containing the information needed to validate and include a transaction in a block.
        /// </remarks>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// The recipient's address in the transaction.
        /// </summary>
        public string? to_address { get; set; }

        /// <summary>
        /// Represents the hash of the puzzle related to the recipient's address.
        /// </summary>
        /// <remarks>
        /// In Chia, addresses are not stored directly on the blockchain. Instead, they are hashed into a puzzle hash.
        /// </remarks>
        public string? to_puzzle_hash { get; set; }

        /// <summary>
        /// An identifier for the trade associated with the transaction.
        /// </summary>
        public string? trade_id { get; set; }

        /// <summary>
        /// The type of the transaction.
        /// </summary>
        /// <remarks>
        /// The value here represents the transaction type as per Chia's transaction format.
        /// </remarks>
        public ulong? type { get; set; }

        /// <summary>
        /// The identifier for the wallet from which the transaction was sent.
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
}
