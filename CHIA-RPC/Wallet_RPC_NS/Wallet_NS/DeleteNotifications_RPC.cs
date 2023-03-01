using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class DeleteNotifications_RPC : RPCTemplate<DeleteNotifications_RPC>
    {
        /// <summary>
        /// Set to delete notifications only from the specified IDs. [Default: delete from all IDs]
        /// </summary>
        /// <remarks>optional</remarks>
        public string[] ids { get; set; }
    }
}
