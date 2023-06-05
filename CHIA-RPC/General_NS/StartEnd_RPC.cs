using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// the start ent rpc is used for a variety of tasks where a start and end needs to be specified
    /// </summary>
    public class StartEnd_RPC : RPCTemplate<StartEnd_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public StartEnd_RPC() { /* for serialisation */ }
        /// <summary>
        /// the start ent rpc is used for a variety of tasks where a start and end needs to be specified
        /// </summary>
        /// <param name="start">The start height to include</param>
        /// <param name="end">the end height to include</param>
        public StartEnd_RPC(ulong start, ulong end)
        {
            this.start = start;
            this.end = end;
        }

        /// <summary>
        /// The start height to include
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong start { get; set; }
        /// <summary>
        /// the end height to include
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong end { get; set; }
    }
}
