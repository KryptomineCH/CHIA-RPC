using CHIA_RPC.Objects_NS;
using System;
using System.Collections.Generic;
namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetAllMempoolItems_Response
    {
        public MempoolItem[] mempool_items { get; set; }
        public bool success { get; set; }
        public string error { get; set; }

    }
}
