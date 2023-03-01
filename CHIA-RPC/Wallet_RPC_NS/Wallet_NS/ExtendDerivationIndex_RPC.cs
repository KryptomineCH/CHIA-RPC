using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class ExtendDerivationIndex_Response : ResponseTemplate<ExtendDerivationIndex_Response>
    {
        /// <summary>
        /// The derivation index is the minimum number of addresses the wallet will examine. It's not possible to decrease this number.
        /// </summary>
        public ulong index { get; set; }
    }
    public class ExtendDerivationIndex_RPC : RPCTemplate<ExtendDerivationIndex_RPC>
    {
        /// <summary>
        /// The new derivation index. Must be larger than the previous index
        /// </summary>
        /// <remarks>The derivation index is the minimum number of addresses the wallet will examine. It's not possible to decrease this number.
        /// <br/>mandatory</remarks>
        [Required]
        public ulong index { get; set; }
    }
}
