using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    /// <summary>
    /// The block height to which the current wallet is synced
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_height_info"/>
    /// </remarks>
    public class GetHeightInfo_Response : ResponseTemplate<GetHeightInfo_Response>
    {
        /// <summary>
        /// the currently synced height
        /// </summary>
        public ulong height { get; set; }
    }
}
