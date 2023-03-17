using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// An object that contains the challenge VDF output data
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_record_by_height"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_record"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/>
    /// </remarks>
    public class VdfOutput : ObjectTemplate<VdfOutput>
    {
        /// <summary>
        /// The data value
        /// </summary>
        public string data { get; set; }
    }
}
