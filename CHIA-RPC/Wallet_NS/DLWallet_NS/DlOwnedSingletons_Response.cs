using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Response from the `dl_owned_singletons` RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_owned_singletons"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class DlOwnedSingletons_Response : ResponseTemplate<DlOwnedSingletons_Response>
    {
        /// <summary>
        /// The number of singleton records returned.
        /// </summary>
        public ulong? count { get; init; }

        /// <summary>
        /// An array of singleton records.
        /// </summary>
        public Singleton[]? singletons { get; init; }
    }

}
