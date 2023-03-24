using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// Delete notifications, with the option to specify IDs from which to delete
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#delete_notifications"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class DeleteNotifications_RPC : RPCTemplate<DeleteNotifications_RPC>
    {
        /// <summary>
        /// Set to delete notifications only from the specified IDs. [Default: delete from all IDs]
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] ids { get; set; }
    }
}
