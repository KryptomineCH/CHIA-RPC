using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Plotter_NS.PlotterObjects_NS
{
    /// <summary>
    /// Represents key information including farmer_public_key and pool_public_key.
    /// </summary>
    public class KeyInfo : ObjectTemplate<KeyInfo>
    {
        /// <summary>
        /// The public key used for farming.
        /// </summary>
        public string farmer_public_key { get; set; }

        /// <summary>
        /// The public key used for pooling.
        /// </summary>
        public string pool_public_key { get; set; }
    }
}
