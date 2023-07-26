using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.WalletNode_NS
{
    /// <summary>
    /// Represents the synchronization status of a wallet in a Chia network node.
    /// </summary>
    /// <remarks>
    /// This class is used as a response to the GetSyncStatus RPC command, which retrieves the current sync status of the wallet.
    /// Refer to Chia's wallet RPC documentation for more details:<br/>
    /// <see href="https://docs.chia.net/wallet-rpc#get_sync_status"/>
    /// The GetSyncStatus request does not have any parameters.
    /// </remarks>
    public class GetWalletSyncStatus_Response : ResponseTemplate<GetWalletSyncStatus_Response>
    {
        /// <summary>
        /// Indicates whether the genesis block has been initialized for this wallet.
        /// </summary>
        /// <remarks>
        /// In the context of blockchain, the genesis block is the first block of a block chain. Modern versions of Bitcoin number it as block 0.
        /// This property is true if the genesis block has been initialized, and false otherwise.
        /// </remarks>
        public bool genesis_initialized { get; set; }

        /// <summary>
        /// Indicates whether the wallet has finished synchronizing with the latest blocks of the blockchain.
        /// </summary>
        /// <remarks>
        /// This property is true if the wallet is synchronized up to the newest block of the blockchain. 
        /// If it's still synchronizing with past blocks, this property is false.
        /// </remarks>
        public bool synced { get; set; }

        /// <summary>
        /// Indicates whether the wallet is currently in the process of synchronizing with the blockchain.
        /// </summary>
        /// <remarks>
        /// This property is true if the wallet is currently synchronizing with the blockchain, and false otherwise.
        /// A wallet may not be syncing if it's already fully synced, or if there's an issue preventing it from syncing.
        /// </remarks>
        public bool syncing { get; set; }
    }

}
