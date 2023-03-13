using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Warning: Gets a list of full blocks by height. Important note: there might be multiple blocks at each height. To find out which one is in the blockchain, use get_block_record_by_height.
    /// </summary>
    public class Height_RPC : RPCTemplate<Height_RPC>
    {
        /// <summary>
        /// The height.
        /// </summary>
        public ulong height { get; set; }
    }
}
