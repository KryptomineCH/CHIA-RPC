using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// The Sync class provides information about the current synchronization state of the full node. 
    /// This is crucial information in blockchain-based systems, as nodes need to constantly synchronize with the network to maintain the latest state of the blockchain.
    /// </summary>
    /// <remarks>
    /// Nodes in a blockchain network maintain the state of the blockchain by continuously synchronizing with other nodes. 
    /// The properties of this class provide key details about this synchronization process. 
    /// This includes whether the node is currently in sync mode, the progress of the sync, the height of the sync tip, 
    /// and whether the node is fully synchronized or not.
    /// <br/>
    /// More info about the blockchain state can be found here: <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>.
    /// </remarks>
    public class Sync : ObjectTemplate<Sync>
    {
        /// <summary>
        /// Indicates whether the full node is currently in sync mode or not. 
        /// When in sync mode, the node is actively trying to catch up with the latest state of the blockchain network.
        /// </summary>
        public bool? sync_mode { get; set; }

        /// <summary>
        /// Represents the height of the blockchain at which the node is currently synchronized. 
        /// This value increases as the node continues to synchronize with the network until it matches the sync_tip_height.
        /// </summary>
        public ulong? sync_progress_height { get; set; }

        /// <summary>
        /// Represents the latest known height of the blockchain network. 
        /// The node tries to reach this height during the synchronization process.
        /// </summary>
        public ulong? sync_tip_height { get; set; }

        /// <summary>
        /// Indicates whether the node has finished synchronizing with the network. 
        /// If true, it means the node is fully in sync, i.e., the sync_progress_height has reached the sync_tip_height.
        /// </summary>
        public bool? synced { get; set; }
    }

}
