using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.WalletNode_NS
{
    /// <summary>
    /// Class to serialize and deserialize a JSON server response for "get_timestamp_for_height" RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#get_timestamp_for_height"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.Height_RPC"/>
    /// </remarks>
    public class GetTimestampForHeight_Response : ResponseTemplate<GetTimestampForHeight_Response>
    {
        /// <summary>
        /// Unix timestamp for the given block height.
        /// </summary>
        public ulong? timestamp { get; init; }
    }
}
