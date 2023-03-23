using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// the name of a specific wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_wallet_name"/><br/><br/>
    /// uses:<br/>
    /// <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetWalletName_Response : ResponseTemplate<DidGetWalletName_Response>
    {
        /// <summary>
        /// the wallet ID which the request was for
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The name of the did wallet
        /// </summary>
        public string name { get; set; }
    }
}
