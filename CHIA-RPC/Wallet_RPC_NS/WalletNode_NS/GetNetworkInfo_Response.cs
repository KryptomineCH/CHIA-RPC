using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.WalletNode_NS
{
    /// <summary>
    /// Show the current network (eg mainnet) and network prefix (eg XCH)
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_network_info"/>
    /// </remarks>
    public class GetNetworkInfo_Response: ResponseTemplate<GetNetworkInfo_Response>
    {
        /// <summary>
        /// eg mainnet or testnet
        /// </summary>
        public string network_name { get; set; }
        /// <summary>
        /// eg xch or txch
        /// </summary>
        public string network_prefix { get; set; }
    }
}
