using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.DatalayerObjects_NS
{
    /// <summary>
    /// Represents a general transaction within the Chia data layer.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class is used to encapsulate all information related to a Chia transaction.
    /// It includes details about the coins that are created and removed during the transaction, the amount, fee, confirmations, the transaction ID and the associated wallet ID.
    /// It also provides methods to retrieve and set the amount and fee in XCH (the native currency of Chia).
    /// </para>
    /// <see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/>
    /// </remarks>
    public class Datalayer_Transaction : ObjectTemplate<Datalayer_Transaction>
    {
        /// <summary>
        /// The coins which are (or will be) created by this transaction.
        /// </summary>
        /// <remarks>For a standard chia transaction, these are 1-2 coins (1 to the recipient and 1 to yourself with the change if needed)<br/>
        /// The hash values in the Coins can be used to look the transactions up in Blockchain explorers</remarks>
        public Coin[]? additions { get; set; }
        /// <summary>
        /// the transaction amount in mojos
        /// </summary>
        public ulong? amount { get; set; }
        /// <summary>
        /// the transaction amount in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// Indicates that a Transaction has been submitted and Processed by a Full Node
        /// </summary>
        public bool? confirmed { get; set; }
        /// <summary>
        /// The block in which the transaction was included
        /// </summary>
        public ulong? confirmed_at_height { get; set; }
        /// <summary>
        /// probably a unix timestamp of the Block in which the transaction was included
        /// </summary>
        public ulong? created_at_time { get; set; }
        /// <summary>
        /// The timestamp as DateTime.
        /// </summary>
        [JsonIgnore]
        public DateTime? created_at_time_dateTime
        {
            get
            {
                if (created_at_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)created_at_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }
        /// <summary>
        /// the fee amount in mojos
        /// </summary>
        public ulong? fee_amount { get; set; }
        /// <summary>
        /// the transaction amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_amount_in_xch
        {
            get { return fee_amount / GlobalVar.OneChiaInMojos; }
            set { fee_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// note: could not be validated yet
        /// </summary>
        public string[]? memos { get; set; }
        /// <summary>
        /// This is the transaction ID!!!
        /// </summary>
        /// <remarks>This is NOT what you will find from Blockchain explorers. Get the Hashes from the Coins (additions) instead!</remarks>
        public string? name { get; set; }
        /// <summary>
        /// The Coins which are removed from your wallet to create the new coins
        /// </summary>
        public Coin[]? removals { get; set; }
        /// <summary>
        /// Represents the total value in mojos sent in this transaction.
        /// </summary>
        public ulong? sent { get; set; }

        /// <summary>
        /// List of destination addresses to which the transaction amount was sent.
        /// </summary>
        /// <remarks>
        /// This is typically used in multi-output transactions. Each address in the array represents a recipient of the transaction.
        /// </remarks>
        public dynamic[]? sent_to { get; set; }

        /// <summary>
        /// Represents the bundle of information required to spend Chia coins.
        /// </summary>
        /// <remarks>
        /// A SpendBundle is a basic unit of a transaction in Chia. It includes the spend conditions (puzzles and their solutions) and signatures needed to spend coins.
        /// </remarks>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// Represents the recipient address of the transaction.
        /// </summary>
        /// <remarks>
        /// This is the address to which the transaction amount was sent.
        /// </remarks>
        public string? to_address { get; set; }

        /// <summary>
        /// Represents the puzzle hash of the recipient's address.
        /// </summary>
        /// <remarks>
        /// In Chia, an address is essentially a hash of a puzzle. This property stores the hash of the puzzle corresponding to the recipient's address.
        /// </remarks>
        public string? to_puzzle_hash { get; set; }

        /// <summary>
        /// Represents the unique identifier of the trade associated with this transaction, if any.
        /// </summary>
        public string? trade_id { get; set; }

        /// <summary>
        /// Represents the type of the transaction.
        /// </summary>
        /// <remarks>
        /// This could be used to differentiate between different kinds of transactions (e.g., regular transfer, trade, etc.)
        /// </remarks>
        public ulong? type { get; set; }

        /// <summary>
        /// the wallet ID which this transaction was sent from
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
}
