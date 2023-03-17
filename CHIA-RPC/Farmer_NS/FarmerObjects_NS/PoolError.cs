using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/farmer-rpc#get_pool_state"/></remarks>
    public class PoolError : ObjectTemplate<PoolError>
    {
        /// <summary>
        /// The error code.
        /// </summary>
        public uint error_code { get; set; }
        /// <summary>
        /// The error message.
        /// </summary>
        public string error_message { get; set; }
    }
}
