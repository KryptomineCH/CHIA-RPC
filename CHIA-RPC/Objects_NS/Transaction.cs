using CHIA_RPC.ErrorInterface_NS;
using CHIA_RPC.FullNode_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// a general transaction
    /// </summary>
    /// <remarks>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
    /// <br/><br/> 
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
        /// Derived value from additions (in mojo)<br/>
        /// WARNINGS:<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the additions after calculating it.
        /// </remarks>
        [JsonIgnore]
        public ulong? AdditionsAmount
        {
            get
            {
                if (_AdditionsAmount == null)
                {
                    lock (_lock)
                    {
                        if (_AdditionsAmount == null)
                        {
                            ulong sum = 0;
                            foreach (Coin addition in additions)
                            {
                                if (addition.amount.HasValue)
                                {
                                    sum += addition.amount.Value;
                                }
                            }
                            _AdditionsAmount = sum;
                        }
                    }
                }
                return _AdditionsAmount;
            }
        }
        private ulong? _AdditionsAmount;
        private readonly object _lock = new object();
        /// <summary>
        /// Derived value from additions (in xch)<br/>
        /// WARNINGS:<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions use <see cref="amount_in_xch"/> instead!
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the additions after calculating it.
        /// </remarks>
        [JsonIgnore]
        public decimal? AdditionsAmount_XCH
        {
            get
            {
                if (_AdditionsAmount_XCH == null)
                {
                    lock (_lock)
                    {
                        if (_AdditionsAmount_XCH == null)
                        {
                            decimal sum = 0;
                            foreach (Coin addition in additions)
                            {
                                if (addition.amount_in_xch.HasValue)
                                {
                                    sum += addition.amount_in_xch.Value;
                                }
                            }
                            _AdditionsAmount_XCH = sum;
                        }
                    }
                }
                return _AdditionsAmount_XCH;
            }
        }
        private decimal? _AdditionsAmount_XCH;
        /// <summary>
        /// Derived value from additions (in cat)<br/>
        /// WARNINGS:<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the additions after calculating it.
        /// </remarks>
        [JsonIgnore]
        public decimal? AdditionsAmount_CAT
        {
            get
            {
                if (_AdditionsAmount_CAT == null)
                {
                    lock (_lock)
                    {
                        if (_AdditionsAmount_CAT == null)
                        {
                            decimal sum = 0;
                            foreach (Coin addition in additions)
                            {
                                if (addition.amount_in_cat.HasValue)
                                {
                                    sum += addition.amount_in_cat.Value;
                                }
                            }
                            _AdditionsAmount_CAT = sum;
                        }
                    }
                }
                return _AdditionsAmount_CAT;
            }
        }
        private decimal? _AdditionsAmount_CAT;

        /// <summary>
        /// the transaction amount in mojos<br/>
        /// </summary>
        public ulong? amount { get; set; }
        /// <summary>
        /// the transaction amount in full chia<br/>
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
        /// <summary>
        /// the transaction amount in cat token amount.<br/><br/>
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal? amount_in_cat
        {
            get { return amount / GlobalVar.OneCatInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneCatInMojos); }
        }
        /// <summary>
        /// Indicates that a Transaction has been submitted and Processed by a Full Node
        /// </summary>
        public bool? confirmed { get; set; }
        /// <summary>
        /// The block in which the transaction was included
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> NOT deterministic. Information such WILL CHANGE when resynching the wallet!
        /// </remarks>
        public ulong? confirmed_at_height { get; set; }
        /// <summary>
        /// probably a unix timestamp of the Block in which the transaction was included
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> NOT deterministic. Information such WILL CHANGE when resynching the wallet!
        /// </remarks>
        public ulong? created_at_time { get; set; }
        /// <summary>
        /// The timestamp as DateTime.
        /// </summary>
        /// <remarks>
        /// <b>WARNING:</b> NOT deterministic. Information such WILL CHANGE when resynching the wallet!
        /// </remarks>
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
        /// The Coins which are removed from your wallet (destroyed) to create the new coins
        /// </summary>
        public Coin[]? removals { get; set; }
        /// <summary>
        /// The sum of chia coins which get "destroyed". <br/>
        /// Note, new coins with the same value are beeing created. <br/>
        /// WARNINGS:<br/>
        /// - The removals amount is usually not visible on incoming standard transactions<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the removals after calculating it.
        /// </remarks>
        [JsonIgnore]
        public ulong? RemovalsAmount
        {
            get
            {
                if (_RemovalsAmount == null)
                {
                    lock (_lock)
                    {
                        if (_RemovalsAmount == null)
                        {
                            ulong sum = 0;
                            foreach (Coin removal in removals)
                            {
                                if (removal.amount.HasValue)
                                {
                                    sum += removal.amount.Value;
                                }
                            }
                            _RemovalsAmount = sum;
                        }
                    }
                }
                return _RemovalsAmount;
            }
        }
        private ulong? _RemovalsAmount;

        /// <summary>
        /// Derived value from removals (in xch)<br/>
        /// WARNINGS:<br/>
        /// - The removals amount is usually not visible on incoming standard transactions<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the removals after calculating it.
        /// </remarks>
        [JsonIgnore]
        public decimal? RemovalsAmount_XCH
        {
            get
            {
                if (_RemovalsAmount_XCH == null)
                {
                    lock (_lock)
                    {
                        if (_RemovalsAmount_XCH == null)
                        {
                            decimal sum = 0;
                            foreach (Coin removal in removals)
                            {
                                if (removal.amount_in_xch.HasValue)
                                {
                                    sum += removal.amount_in_xch.Value;
                                }
                            }
                            _RemovalsAmount_XCH = sum;
                        }
                    }
                }
                return _RemovalsAmount_XCH;
            }
        }
        private decimal? _RemovalsAmount_XCH;
        /// <summary>
        /// Derived value from removals (in cat)<br/>
        /// WARNINGS:<br/>
        /// - The removals amount is usually not visible on incoming standard transactions<br/>
        /// - the transaction value CANNOT be determined by calculating removals-additions
        /// </summary>
        /// <remarks>
        /// This value is cached. It will not be refreshed if you change the removals after calculating it.
        /// </remarks>
        [JsonIgnore]
        public decimal? RemovalsAmount_CAT
        {
            get
            {
                if (_RemovalsAmount_CAT == null)
                {
                    lock (_lock)
                    {
                        if (_RemovalsAmount_CAT == null)
                        {
                            decimal sum = 0;
                            foreach (Coin removal in removals)
                            {
                                if (removal.amount_in_cat.HasValue)
                                {
                                    sum += removal.amount_in_cat.Value;
                                }
                            }
                            _RemovalsAmount_CAT = sum;
                        }
                    }
                }
                return _RemovalsAmount_CAT;
            }
        }
        private decimal? _RemovalsAmount_CAT;
        /// <summary>
        /// Number of peers the tx was sent to.
        /// </summary>
        public ulong? sent { get; set; }

        /// <summary>
        /// The peers the tx has been sent to.
        /// </summary>
        public Peer[]? sent_to { get; set; }

        /// <summary>
        /// Specifies if a transaction is valid by checking properties such as sent_to replies.
        /// </summary>
        /// <remarks>
        /// this is just a preliminary check. There might be several reasons why a peer might refuse the transaction.<br/>
        /// Please check the peer reasoning if !is_valid
        /// </remarks>
        [JsonIgnore]
        public bool is_valid
        {
            get
            {
                /// trepca (discord community) if this is from the wallet, then confirmed = true and confirmed_at_height = 0 means transaction has failed
                if ((bool)confirmed && confirmed_at_height == 0)
                {
                    return false;
                }
                foreach (Peer peer in sent_to)
                {
                    if (peer.inclusionStatus == InclusionStatus.FAILED)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

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
        /// <b>WARNING:</b> <br/>
        /// - The transaction types are not fully functional. Specifically `INCOMING_TRADE` cannot be matched up on an offer you created and someone else accepted!
        /// <br/><br/> 
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
        /// this is an experimental property in an attempt to make transactions more clear for humans
        /// </summary>
        /// <remarks>
        /// if a transaction is denominated in a cat token and fees are applied, the fees are beeing deducted from the xch wallet! 
        /// this leads to the additions + fees > removals
        /// </remarks>
        [JsonIgnore]
        public CustomTransactionType? customTransactionType { get { return GetCustomTransactionType(); } }
        /// <summary>
        /// this is an experimental property in an attempt to make transactions more clear for humans
        /// </summary>
        /// <remarks>
        /// if a transaction is denominated in a cat token and fees are applied, the fees are beeing deducted from the xch wallet! 
        /// this leads to the additions + fees > removals
        /// </remarks>
        [Experimental("This function is still under testing and may change in future.")]
        public CustomTransactionType? GetCustomTransactionType()
        {
#warning This function is experimental and may change in the future
            if (amount == 0)
            {
                // assuming this is a null value transaction, (excluding fee? cancellation transaction?)

            }
            else
            {
                // the transaction has an amount, it could be a standard transfer, or an offer

            }
            //if ()
            //if (AdditionsAmount > 0 && RemovalsAmount == 0)
            //{ // assumption: an incoming transaction (wallet balance increases) never consumes coins as this would be a creation out of thin air
            //    return CustomTransactionType.Incoming;
            //}
            //if (AdditionsAmount + fee_amount < RemovalsAmount )
            //{ // less cons are added than removed: the added amount is the change. RemovalsAmount - (AdditionsAmount + fee_amount) equals the sent amount
            //    return CustomTransactionType.Outgoing;
            //}
            //if (AdditionsAmount + fee_amount == RemovalsAmount || AdditionsAmount == RemovalsAmount)
            //{
            //    return CustomTransactionType.Neutral;
            //}
            //
            return CustomTransactionType.Unknown;
        }

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
        /// tries to identify the primary relevant coin(s) if this transaction which can be used to find the transaction in the blockchain explorer
        /// </summary>
        /// <remarks>
        /// the logic how transactions are beeing calculated is very complex, since multiple coins and recipients can be involved<br/>
        /// This function is still experimental.
        /// </remarks>
        /// <returns></returns>
        /// <exception cref="AggregateException">could not identify apropriate coin!</exception>
        [Experimental("This function is still under testing and may change in future.")]
        public Coin[] GetPrimaryCoins()
        {
#warning This function is experimental and may change in the future
            // invalidity checks
            if (additions == null && removals == null)
            {
                throw new NullReferenceException(nameof(additions));
            }
            // fixes for single null value
            if (additions == null) additions = new Coin[0];
            if (removals == null) removals = new Coin[0];
            if (additions.Length == 0 && removals.Length == null)
            {
                throw new InvalidOperationException("there are no additions & removals assigned to the transaction!");
            }
            
            // Trivial transactions
            if (additions.Length == 1 && removals.Length == 0)
            {
                return additions;
            }
            if (removals.Length == 1 && additions.Length == 0)
            {
                return removals;
            }

            // extended logic
            /// Preparations
            CustomTransactionType? transactionType = GetCustomTransactionType();
            if (this.type == TransactionType.OUTGOING)
            {
                // in an outgoing transaction, the coin beeing created at the recipient is in the additions.
                // HOWEVER:
                // TODO: in a cancellation transaction (outgoing) the primary coins are in the removals (identifier)
                Coin? primaryCoin = null;
                foreach (Coin coin in additions)
                {
                    if (coin.amount == this.amount)
                    {
                        primaryCoin = coin;
                        break;
                    }
                }
                if (primaryCoin != null)
                {
                    return new[] { primaryCoin }; 
                }
                return additions;
            }
            if (this.type == TransactionType.INCOMING)
            {
                return additions;
            }
            if (transactionType == CustomTransactionType.Neutral && additions.Length == removals.Length)
            {
                // this is likely a cancellation transaction
                return removals;
            }
            if (Settings.ReportErrors)
            {
                Error error = new Error(
                    objectJson: this.ToString(),
                    objectName: "Transaction_DictMemos",
                    errorDescription: "could not identify apropriate coin!",
                    function: "GetPrimaryCoins()");
                ReportError.UploadFileAsync(error);
            }
            throw new AggregateException("could not identify apropriate coin!");
        }
    }
    /// <summary>
    /// Represents a transaction that includes an array of memos.
    /// </summary>
    /// <remarks>
    /// A memo is an optional data field that can be included in a Chia transaction. <br/>
    /// This class extends Transaction_NoMemo, which represents a basic transaction, by adding an array of string memos.<br/><br/>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
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
    /// This class extends Transaction_NoMemo by adding a dictionary of memos. <br/>
    /// This allows for more structured data to be included with a transaction compared to the array of strings in Transaction_StringMemos.<br/><br/>
    /// <b>WARNING:</b> The transaction history is not deterministic due to heuristics we use to counter privacy features of the blockchain.<br/>
    /// this means, a couple of details cannot be fetched fully:<br/>
    /// - The transaction IDs can and will change if you resync the wallet<br/>
    /// - The transaction time is a <b>rough</b> estimate. When an offer is accepted, the individual offer transactions have different created times
    /// - For your offers that a 3rd Party accepted, the incoming coins are beeing marked as incoming transaction, not as incoming coin<br/>
    /// - When cancelling offers, the cancellation Transactions are beeing shown as transaction, not as trade<br/>
    /// - Offers are split into multiple transactions on the corresponding wallets.<br/>
    /// - Offer Transactions do not share the same ids. To match them up, it is best to keep the offer files.<br/>
    /// - Transactions which are not kept in XCH and have a fee will cause a second Transaction in the XCH Wallet<br/>
    /// For accurate records, you should keep a local record of transactions (TXs) and the Offer files made. <br/><br/>
    /// <br/><br/> 
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