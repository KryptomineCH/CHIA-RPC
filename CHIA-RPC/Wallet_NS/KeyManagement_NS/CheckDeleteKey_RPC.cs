using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.KeyManagement
{
    /// <summary>
    /// Display whether a fingerprint has a balance, and whether it is used for farming or pool rewards. 
    /// This is helpful when determining whether it is safe to delete a key without first backing it up
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#check_delete_key"/><br/><br/>
    /// Uses:<br/><see cref="CheckDeleteKey_RPC"/>
    /// </remarks>
    public class CheckDeleteKey_Response : ResponseTemplate<CheckDeleteKey_Response>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// farm rewards go to this wallet
        /// </summary>
        public bool used_for_farmer_rewards { get; set; }
        /// <summary>
        /// pool rewards go to this wallet
        /// </summary>
        public bool used_for_pool_rewards { get; set; }
        /// <summary>
        /// wallet still contains a balance
        /// </summary>
        public bool wallet_balance { get; set; }
    }
    /// <summary>
    /// Display whether a fingerprint has a balance, and whether it is used for farming or pool rewards. 
    /// This is helpful when determining whether it is safe to delete a key without first backing it up
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#check_delete_key"/></remarks>
    /// <returns><see cref="CheckDeleteKey_Response"/></returns>
    public class CheckDeleteKey_RPC : RPCTemplate<CheckDeleteKey_RPC>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong fingerprint { get; set; }
        /// <summary>
        /// The maximum number of puzzle hashes to search [Default: 100]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? max_ph_to_search { get; set; }
    }
}
