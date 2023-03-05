using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// For a given wallet, fetch the recovery list, as well as the number of IDs required for recovery
    /// </summary>
    /// <remarks>
    /// uses a wllet id rpc
    /// </remarks>
    public class DidGetRecoveryList_Response : ResponseTemplate<DidGetRecoveryList_Response>
    {
        /// <summary>
        /// the amount of recovery dids required
        /// </summary>
        public ulong num_required { get; set; }
        /// <summary>
        /// the list of dids which can be used for recovery
        /// </summary>
        public string[] recovery_list { get; set; }
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
