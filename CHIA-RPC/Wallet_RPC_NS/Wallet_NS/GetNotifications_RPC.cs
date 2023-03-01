using CHIA_RPC.Objects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetNotifications_Response : ResponseTemplate<GetNotifications_Response>
    {
        public Notification[] notifications { get; set; }
    }
    public class GetNotifications_RPC : RPCTemplate<GetNotifications_RPC>
    {
        /// <summary>
        /// Set to receive notifications only from the specified IDs. [Default: receive from all IDs]
        /// </summary>
        /// <remarks>optional</remarks>
        public string ids { get; set; }
        /// <summary>
        /// The number corresponding to the first notification to list. [Default: the first notification]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong start { get; set; }
        /// <summary>
        /// The number corresponding to the last notification to list. [Default: the last notification]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong end { get; set; }
    }
}
