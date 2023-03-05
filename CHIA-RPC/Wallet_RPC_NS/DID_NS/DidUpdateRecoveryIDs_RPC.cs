using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Append one or more IDs to be used for recovery of a DID wallet. The current list can be obtained with the did_get_recovery_list endpoint
    /// </summary>
    /// <remarks>
    /// returns a success response
    /// </remarks>
    public class DidUpdateRecoveryIDs_RPC : RPCTemplate<DidUpdateRecoveryIDs_RPC>
    {
        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The new recovery ID list. Each item from this list will be appended to the existing list
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string new_list { get; set; }
        /// <summary>
        /// Optionally set the number of IDs required for wallet recovery. If not set, then the entire updated list will be required by default
        /// </summary>
        public ulong num_verifications_required { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong fee { get; set; }
    }
}
