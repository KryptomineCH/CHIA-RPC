using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// specifying the host information
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/farmer-rpc#get_harvesters"/><br/>
    /// <see href="https://docs.chia.net/farmer-rpc#get_harvesters_summary"/>
    /// </remarks>
    public class HarvesterConnection : ObjectTemplate<HarvesterConnection>
    {
        /// <summary>
        /// the hostname or ip
        /// </summary>
        public string host { get; set; }
        /// <summary>
        /// the unique identifier of the node
        /// </summary>
        public string node_id { get; set; }
        /// <summary>
        /// the port which is used for communication
        /// </summary>
        public ulong port { get; set; }
    }
}
