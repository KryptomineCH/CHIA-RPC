using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.DaemonObjects_NS
{
    /// <summary>
    /// Represents the address information for a particular wallet identifier.
    /// </summary>
    public class AddressInfo : ObjectTemplate<AddressInfo>
    {
        /// <summary>
        /// Represents the wallet address.
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Represents the hierarchical deterministic path for the wallet address.
        /// </summary>
        public string hd_path { get; set; }
    }
}
