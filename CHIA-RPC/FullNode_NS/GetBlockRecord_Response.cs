using CHIA_RPC.FullNode_NS.FullNodeObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// a block record.
    /// </summary>
    /// <remarks>
    /// is used for multiple endpoints such as: <br/>
    /// get_block_record_by_height <see href="https://docs.chia.net/full-node-rpc#get_block_record_by_height"/><br/>
    /// get_block_record <see href="https://docs.chia.net/full-node-rpc#get_block_record"/>
    /// </remarks>
    public class GetBlockRecord_Response : ResponseTemplate<GetBlockRecord_Response>
    {
        /// <summary>
        /// the block record which is returned
        /// </summary>
        public BlockRecord block_record { get; set; }
    }
    /// <summary>
    ///  block records in a range.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block_records"/>
    /// </remarks>
    public class GetBlockRecords_Response : ResponseTemplate<GetBlockRecords_Response>
    {
        /// <summary>
        /// the block records which are returned
        /// </summary>
        public BlockRecord[] block_records { get; set; }
    }
}
