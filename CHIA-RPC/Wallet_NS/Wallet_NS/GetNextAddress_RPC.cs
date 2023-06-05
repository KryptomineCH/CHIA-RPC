using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// An adress which can be used for receiving
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_next_address"/><br/><br/>
    /// Uses:<br/><see cref="GetNextAddress_RPC"/>
    /// </remarks>
    public class GetNextAddress_Response : ResponseTemplate<GetNextAddress_Response>
    {
        /// <summary>
        /// chia adress, eg <br/>
        /// xch1jxe8yfq8xem0e8ty5dq9hp86ududys96n6ugy2q4fextr0pplw9qwpfru9
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// the wallet number which this request was made for (eg. 2)
        /// </summary>
        public ulong wallet_id { get; set; }
    }
    /// <summary>
    /// Get the next address in the HD tree, with the option to show the latest address
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#get_next_address"/></remarks>
    /// <returns><see cref="GetNextAddress_Response"/></returns>
    public class GetNextAddress_RPC : RPCTemplate<GetNextAddress_RPC>
    {
        /// <summary>
        /// this constructor is parameterless, primairly used for serialisation purposes
        /// </summary>
        public GetNextAddress_RPC() { /* required for serialisation */ }
        /// <summary>
        /// generates the request for retrieving a wallets adress
        /// </summary>
        /// <param name="walletID">the sub wallet which to retrieve an address from</param>
        /// <param name="generateNewAddress">specifies if a new random address should be generated for privacy purposes</param>
        public GetNextAddress_RPC(ulong walletID, bool generateNewAddress = false)
        {
            this.wallet_id = walletID;
            this.new_address = generateNewAddress;
        }
        /// <summary>
        /// derives the request for retrieving a wallets adress from a wallet id rpc
        /// </summary>
        /// <param name="derivation">the wallet id rpc which to derive the request from</param>
        /// <param name="generateNewAddress">specifies if a new random address should be generated for privacy purposes</param>
        public GetNextAddress_RPC(WalletID_RPC derivation, bool generateNewAddress = false)
        {
            this.wallet_id = derivation.wallet_id;
            this.new_address = generateNewAddress;
        }
        /// <summary>
        /// derives the request for retrieving a wallets adress from a wallet id response
        /// </summary>
        /// <param name="derivation">the wallet id rpc which to derive the request from</param>
        /// <param name="generateNewAddress">specifies if a new random address should be generated for privacy purposes</param>
        public GetNextAddress_RPC(WalletID_Response derivation, bool generateNewAddress)
        {
            this.wallet_id = derivation.wallet_id;
            this.new_address = generateNewAddress;
        }
        /// <summary>
        /// the wallet number of the wallet in the chia client (eg. 2)
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// specifies if a new address should be generated or the last one used
        /// </summary>
        public bool new_address { get; set; } = false;
        /// <summary>
        /// Implicit conversion from WalletID_RPC to DidID_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator GetNextAddress_RPC(WalletID_RPC response)
        {
            return new GetNextAddress_RPC(response);
        }
        /// <summary>
        /// Implicit conversion from WalletID_Response to DidID_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator GetNextAddress_RPC(WalletID_Response response)
        {
            return new GetNextAddress_RPC(response);
        }
    }
}
