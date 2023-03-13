using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class WalletID_Response : ResponseTemplate<WalletID_Response>
    {
        public ulong wallet_id { get; set; }
    }
    public class WalletID_RPC : RPCTemplate<WalletID_RPC>
    {
        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>MUST BE larges than 0 <br/>
        /// eg. 5</remarks>
        public ulong wallet_id { get; set; }
    }
}
