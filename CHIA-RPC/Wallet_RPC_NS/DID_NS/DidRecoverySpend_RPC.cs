using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    public class DidRecoverySpend_Response : ResponseTemplate<DidRecoverySpend_Response>
    {
        /// <summary>
        /// the validation data for the recovery
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
    }
    /// <summary>
    /// Recover a DID to a new DID by using an attest file
    /// </summary>
    /// <remarks>
    /// returns spendbundle
    /// </remarks>
    public class DidRecoverySpend_RPC : RPCTemplate<DidRecoverySpend_RPC>
    {
        /// <summary>
        /// The Wallet ID of the DID wallet to recover
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// A list of attest files to be used for recovery
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string[] attest_data { get; set; }
        /// <summary>
        /// The public key of the wallet to recover. If this is not provided, a temporary public key will be used instead
        /// </summary>
        public string pubkey { get; set; }
        /// <summary>
        /// The puzzle hash of the wallet to recover. If this is not provided, a temporary puzzle hash will be used instead
        /// </summary>
        public string puzhash { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong fee { get; set; }
    }
}
