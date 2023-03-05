using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Update the metadata for a DID wallet. The current metadata can be obtained with the did_get_metadata endpoint
    /// </summary>
    /// <remarks>
    /// returns a success response
    /// </remarks>
    public class DidUpdateMetadata_RPC : RPCTemplate<DidUpdateMetadata_RPC>
    {
        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The new metadata
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string metadata { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong fee { get; set; }
    }
}
