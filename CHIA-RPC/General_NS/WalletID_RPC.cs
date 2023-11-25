using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;
using NFT.Storage.Net.ClientResponse;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Represents a response object that contains a wallet ID which is required as an identifier for many requests.
    /// </summary>
    /// <remarks>
    /// Implicit conversions exist for ease of use with rpcs:<br/>
    /// - <see cref="WalletID_RPC"/><br/>
    /// - <see cref="GetNextAddress_RPC"/>
    /// </remarks>
    public class WalletID_Response : ResponseTemplate<WalletID_Response>
    {
        /// <summary>
        /// The wallet ID.
        /// </summary>
        public ulong wallet_id { get; set; }
    }
    /// <summary>
    /// The wallet_ID RPC is used for a variety of tasks which require a wallet id as only request parameter such as <see cref="GetNextAddress_RPC"/><br/>
    /// WalletID starts at 1(!)
    /// </summary>
    /// <remarks>
    /// Implicit conversions exist for other requests:<br/>
    /// - <see cref="GetNextAddress_RPC"/>
    /// </remarks>
    public class WalletID_RPC : RPCTemplate<WalletID_RPC>
    {
        /// <summary>
        /// this constructor is parameterless, for serialisation
        /// </summary>
        public WalletID_RPC() { /* for serialisation */ }
        /// <summary>
        ///  The wallet_ID RPC is used for a variety of tasks which require a wallet id as only request parameter such as <see cref="GetNextAddress_RPC"/>
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the wallet from which to obtain the balance (starts at 1)</param>
        public WalletID_RPC(ulong wallet_id)
        {
            this.wallet_id = wallet_id;
        }
        /// <summary>
        ///  The wallet_ID RPC is used for a variety of tasks which require a wallet id as only request parameter such as <see cref="GetNextAddress_RPC"/>
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the wallet from which to obtain the balance (starts at 1)</param>
        public WalletID_RPC(WalletID_Response wallet_id)
        {
            this.wallet_id = wallet_id.wallet_id;
        }

        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance (starts at 1)
        /// </summary>
        /// <remarks>MUST BE larger than 0 <br/>
        /// eg. 5</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// Implicitly converts a WalletID_Response object to a WalletID_RPC object.
        /// </summary>
        /// <param name="response">The WalletID_Response object to convert.</param>
        /// <returns>A new WalletID_RPC object initialized with the wallet ID.</returns>
        public static implicit operator WalletID_RPC(WalletID_Response response)
        {
            return new WalletID_RPC(response.wallet_id);
        }
        /// <summary>
        /// Implicitly converts a WalletID_Response object to a numeric wallet id.
        /// </summary>
        /// <param name="response">The WalletID_Response object to convert.</param>
        /// <returns>A ulong initialized with the wallet ID.</returns>
        public static implicit operator ulong(WalletID_RPC response)
        {
            return response.wallet_id;
        }
        /// <summary>
        /// Implicitly converts a numeric wallet id to WalletID_Response
        /// </summary>
        /// <param name="walletID">The WalletID to convert.</param>
        /// <returns>A WalletID_RPC initialized with the wallet ID.</returns>
        public static implicit operator WalletID_RPC(ulong walletID)
        {
            return new WalletID_RPC(walletID);
        }
    }
}
