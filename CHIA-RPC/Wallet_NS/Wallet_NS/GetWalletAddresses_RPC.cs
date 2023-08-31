using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{/*
    /// <summary>
    /// An adress which can be used for receiving
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_next_address"/><br/><br/>
    /// Uses:<br/><see cref="GetNextAddress_RPC"/>
    /// </remarks>
    public class GetWalletAddress_Response : ResponseTemplate<GetWalletAddress_Response>
    {
        /// <summary>
        /// chia adress, eg <br/>
        /// xch1jxe8yfq8xem0e8ty5dq9hp86ududys96n6ugy2q4fextr0pplw9qwpfru9
        /// </summary>
        public string[]? addresses { get; set; }
        /// <summary>
        /// the wallet number which this request was made for (eg. 2)
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
    /// <summary>
    /// Get specific address(es) from the address tree, this is mainly used to validate if an address is an own address
    /// </summary>
    /// <remarks>not documented yet</remarks>
    /// <returns><see cref="GetWalletAddress_Response"/></returns>
    public class GetWalletAddresses_RPC : RPCTemplate<GetWalletAddresses_RPC>
    {
        /// <summary>
        /// this constructor is parameterless, primairly used for serialisation purposes
        /// </summary>
        public GetWalletAddresses_RPC() { /* required for serialisation *//* }
        /// <summary>
        /// Get specific address(es) from the address tree, this is mainly used to validate if an address is an own address
        /// </summary>
        /// <param name="walletID">the sub wallet which to retrieve an address from</param>
        /// <param name="index">the start index of the wallet addaress to retrieve. 0 Based. Defaults to 0</param>
        /// <param name="count">the amount of adresses to generate. Defaults to 1. </param>
        public GetWalletAddresses_RPC(ulong walletID, ulong? index, ulong? count)
        {
            this.wallet_id = walletID;
            this.index = index;
            this.count = count;
        }
        /// <summary>
        /// Get specific address(es) from the address tree, this is mainly used to validate if an address is an own address
        /// </summary>
        /// <param name="derivation">the wallet which to retrieve an address from</param>
        /// <param name="index">the start index of the wallet addaress to retrieve. 0 Based. Defaults to 0</param>
        /// <param name="count">the amount of adresses to generate. Defaults to 1.</param>
        public GetWalletAddresses_RPC(WalletID_RPC derivation, ulong? index, ulong? count)
        {
            this.wallet_id = derivation.wallet_id;
            this.index = index;
            this.count = count;
        }
        /// <summary>
        /// the wallet number of the wallet in the chia client (eg. 2)
        /// </summary>
        public ulong? wallet_id { get; set; }
        /// <summary>
        /// the start index of the wallet addaress to retrieve. 0 Based. Defaults to 0
        /// </summary>
        public ulong? index { get; set; }
        /// <summary>
        /// the amount of adresses to generate. Defaults to 1
        /// </summary>
        public ulong? count { get; set; }
    }
*/
}
