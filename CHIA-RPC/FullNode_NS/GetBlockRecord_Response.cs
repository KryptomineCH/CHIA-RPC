using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
namespace CHIA_RPC.FullNode_NS
{
    /// <summary>
    /// a block record.
    /// </summary>
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
    public class GetBlockRecords_Response : ResponseTemplate<GetBlockRecords_Response>
    {
        /// <summary>
        /// the block records which are returned
        /// </summary>
        public BlockRecord[] block_records { get; set; }
    }
}
