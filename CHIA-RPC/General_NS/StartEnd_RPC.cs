using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class StartEnd_RPC : RPCTemplate<StartEnd_RPC>
    {
        /// <summary>
        /// The start height to include
        /// </summary>
        public ulong start { get; set; }
        /// <summary>
        /// the end height to include
        /// </summary>
        public ulong end { get; set; }
    }
}
