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
        /// the wallet number of the wallet in the chia client (eg. 2)
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// specifies if a new address should be generated or the last one used
        /// </summary>
        public bool new_address { get; set; }
    }
}
