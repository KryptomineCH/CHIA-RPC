using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
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
