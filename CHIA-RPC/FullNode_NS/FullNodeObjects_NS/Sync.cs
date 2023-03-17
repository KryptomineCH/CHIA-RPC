using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// contains full node sync information
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/></remarks>
    public class Sync : ObjectTemplate<Sync>
    {
        /// <summary>
        /// indicates wether the wallet is currently syncing or not
        /// </summary>
        public bool sync_mode { get; set; }
        public ulong sync_progress_height { get; set; }
        public ulong sync_tip_height { get; set; }
        /// <summary>
        /// indicates that the node is fully in sync
        /// </summary>
        public bool synced { get; set; }
    }
}
