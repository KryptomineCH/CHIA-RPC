using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Represents a response object that contains a wallet ID.
    /// </summary>
    public class WalletID_Response : ResponseTemplate<WalletID_Response>
    {
        /// <summary>
        /// The wallet ID.
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// Returns a new WalletID_RPC object initialized with the wallet ID.
        /// </summary>
        /// <returns>A new WalletID_RPC object.</returns>
        public WalletID_RPC GetWalletID_RPC()
        {
            return new WalletID_RPC(wallet_id);
        }

        /// <summary>
        /// Implicitly converts a WalletID_Response object to a WalletID_RPC object.
        /// </summary>
        /// <param name="response">The WalletID_Response object to convert.</param>
        /// <returns>A new WalletID_RPC object initialized with the wallet ID.</returns>
        public static implicit operator WalletID_RPC(WalletID_Response response)
        {
            return new WalletID_RPC(response.wallet_id);
        }
    }

    public class WalletID_RPC : RPCTemplate<WalletID_RPC>
    {
        public WalletID_RPC() { /* for serialisation */ }
        public WalletID_RPC(ulong wallet_id)
        {
            this.wallet_id = wallet_id;
        }

        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>MUST BE larger than 0 <br/>
        /// eg. 5</remarks>
        public ulong wallet_id { get; set; }
    }
}
