using CHIA_RPC.HelperFunctions_NS;
using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.General
{
    internal class HeaderHash_RPC : RPCTemplate<HeaderHash_RPC>
    {
        /// <summary>
        /// The header hash of the block to look up
        /// </summary>
        [Required]
        public string header_hash { get; set; }
    }
}
