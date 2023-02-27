using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetAdditionsAndRemovals_Response
    {
        public CoinTransaction[] additions { get; set; }
        public CoinTransaction[] removals { get; set; }
        /// <summary>
        /// indicates if the rpc was executed successfully
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// in case of rpc failure, there might be an error message attached
        /// </summary>
        public string error { get; set; }
    }
}
