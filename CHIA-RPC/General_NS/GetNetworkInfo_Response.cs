using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// Show the current network (eg mainnet) and network prefix (eg XCH)
    /// </summary>
    /// <remarks>
    /// the request is parameterless<br/>
    /// used in:<br/>
    /// - wallet <see href="https://docs.chia.net/wallet-rpc#get_network_info"/><br/>
    /// - full node <see href="https://docs.chia.net/full-node-rpc#get_network_info"/>
    /// </remarks>
    public class GetNetworkInfo_Response : ResponseTemplate<GetNetworkInfo_Response>
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
