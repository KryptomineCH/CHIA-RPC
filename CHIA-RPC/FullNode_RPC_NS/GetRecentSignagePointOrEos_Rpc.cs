using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    /// <summary>
    /// Warning: Gets a list of full blocks by height. 
    /// </summary>
    /// <remarks>
    /// Important note: there might be multiple blocks at each height. 
    /// To find out which one is in the blockchain, use get_block_record_by_height.
    /// </remarks>
    public class GetRecentSignagePointOrEos_Rpc : RPCTemplate<GetRecentSignagePointOrEos_Rpc>
    {
        /// <summary>
        /// Gets or sets the hash of the output for a signage point (if it's in the middle of a sub slot).
        /// </summary>
        public string sp_hash { get; set; }
        /// <summary>
        /// Gets or sets the challenge_hash for the subslot (if it's an end of sub slot challenge).
        /// </summary>
        public string challenge_hash { get; set; }
    }
}
