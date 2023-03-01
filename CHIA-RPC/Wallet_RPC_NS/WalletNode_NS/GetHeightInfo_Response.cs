using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    public class GetHeightInfo_Response : ResponseTemplate<GetHeightInfo_Response>
    {
        /// <summary>
        /// the currently synced height
        /// </summary>
        public ulong height { get; set; }
    }
}
