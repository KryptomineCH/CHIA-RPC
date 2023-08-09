using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;
using System.Transactions;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// a general transaction
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#create_data_store"/><br/>
    /// </remarks>
    public class Transaction_NoMemo : ObjectTemplate<Transaction_NoMemo>
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
        /// the fee amount in mojos
        /// </summary>
        public ulong? fee_amount { get; set; }
        /// <summary>
        /// the transaction fee in full chia
        /// </summary>
        /// <remarks>This value is derived from the mojos fee_amount</remarks>
        [JsonIgnore]
        public decimal? fee_amount_in_xch 
        { 
            get { return fee_amount / GlobalVar.OneChiaInMojos; } 
            set { fee_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
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
        public TransactionType? type { get; set; }

        /// <summary>
        /// Represents the unique identifier of the wallet from which this transaction was sent.
        /// </summary>
        /// <remarks>
        /// This ID helps identify which wallet made the transaction in scenarios where a single user has multiple wallets.
        /// </remarks>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// Implicitly converts a Transaction_NoMemo object to a TransactionID_RPC object.
        /// </summary>
        /// <param name="response">The Transaction_NoMemo object to convert.</param>
        /// <returns>A new TransactionID_RPC object initialized with the name of the Transaction_NoMemo object.</returns>
        public static implicit operator TransactionID_RPC(Transaction_NoMemo response)
        {
            if (string.IsNullOrEmpty( response.name))
            {
                throw new NullReferenceException(nameof(response.name));
            }
            return new TransactionID_RPC(response.name);
        }

        /// <summary>
        /// identifies the primary coin which can be used to find a transaction on blockchain explorers
        /// </summary>
        /// <returns></returns>
        /// <exception cref="AggregateException">could not identify apropriate coin!</exception>
        public Coin GetPrimaryCoin()
        {
            if (additions == null)
            {
                throw new NullReferenceException(nameof(additions));
            }
                if (amount == 0 && additions.Length > 0)
            {
                // this is a workaround for the api returning an amount of 0 in unknown circumstances
                return additions[0];
            }
            foreach(Coin addition in additions)
            {
                if (addition.amount == amount)
                {
                    return addition;
                }
            }
            throw new AggregateException("could not identify apropriate coin!");
        }
    }
    /// <summary>
    /// Represents a transaction that includes an array of memos.
    /// </summary>
    /// <remarks>
    /// A memo is an optional data field that can be included in a Chia transaction. 
    /// This class extends Transaction_NoMemo, which represents a basic transaction, by adding an array of string memos.
    /// </remarks>
    public class Transaction_StringMemos : Transaction_NoMemo
    {
        /// <summary>
        /// Represents the array of memos associated with the transaction.
        /// </summary>
        /// <remarks>
        /// Memos can be used for a variety of purposes, such as adding notes or extra information to a transaction.
        /// Each string in the array is a separate memo.
        /// </remarks>
        public string[]? memos { get; set; }
    }

    /// <summary>
    /// Represents a transaction that includes a dictionary of memos.
    /// </summary>
    /// <remarks>
    /// This class extends Transaction_NoMemo by adding a dictionary of memos. 
    /// This allows for more structured data to be included with a transaction compared to the array of strings in Transaction_StringMemos.
    /// </remarks>
    public class Transaction_DictMemos : Transaction_NoMemo
    {
        /// <summary>
        /// Represents a dictionary of memos associated with the transaction.
        /// </summary>
        /// <remarks>
        /// Each key-value pair in the dictionary represents a separate memo. 
        /// The keys can be used to categorize or label the memos, while the values hold the actual content of the memos.
        /// Please note that this field could not be validated yet.
        /// </remarks>
        public Dictionary<string, string>? memos { get; set; }
    }

}
