using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Class to represent the response from a clear_pending_roots RPC call.
    /// Functionality: Clear pending roots that will not be published, associated data may not be recoverable.
    /// </summary>
    /// <remarks>
    /// Usage: chia rpc data_layer clear_pending_roots [REQUEST]
    /// </remarks>
    public class ClearPendingRoots_Response : ResponseTemplate<ClearPendingRoots_Response>
    {
        /// <summary>
        /// Represents the root data of the response.
        /// </summary>
        public RootInfo root { get; set; }

    }

    /// <summary>
    /// Class to represent the clear_pending_roots RPC call.
    /// Functionality: Clear pending roots that will not be published, associated data may not be recoverable.
    /// https://docs.chia.net/datalayer-rpc#clear_pending_roots
    /// </remarks>
    public class ClearPendingRoots_RPC : RPCTemplate<ClearPendingRoots_RPC>
    {
        /// <summary>
        /// The hexadecimal store ID.
        /// </summary>
        /// <remarks>
        /// This parameter is required.
        /// </remarks>
        public string store_id { get; set; }
    }

}
