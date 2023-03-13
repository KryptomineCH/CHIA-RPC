using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Represents the RPC request to set the farmer and/or pool reward target address(es).
    /// </summary>
    /// <remarks>returns a success response object</remarks>
    public class SetRewardTargets_RPC : RPCTemplate<SetRewardTargets_RPC>
    {
        /// <summary>
        /// Gets or sets the farmer reward target.
        /// </summary>
        public string? farmer_target { get; set; }

        /// <summary>
        /// Gets or sets the pool reward target.
        /// </summary>
        public string? pool_target { get; set; }
    }
}
