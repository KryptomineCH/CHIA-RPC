namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetAllMempoolTxIDs_Response
    {
        public string[] tx_ids { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
}
