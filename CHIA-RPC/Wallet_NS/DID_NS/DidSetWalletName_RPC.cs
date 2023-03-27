using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// renames a did wallet. Returns a wallet_id response
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_set_wallet_name"/></remarks>
    /// <returns><see cref="General_NS.WalletID_Response"/></returns>
    public class DidSetWalletName_RPC : RPCTemplate<DidSetWalletName_RPC>
    {
        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// TThe name which should be given to the did wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string name { get; set; }
    }
}
