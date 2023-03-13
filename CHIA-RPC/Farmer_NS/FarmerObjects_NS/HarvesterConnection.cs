using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS.FarmerObjects_NS
{
    /// <summary>
    /// specifying the host information
    /// </summary>
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
        public string port { get; set; }
    }
}
