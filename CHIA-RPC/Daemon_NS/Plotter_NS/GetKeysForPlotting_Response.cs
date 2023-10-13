using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Daemon_NS.Plotter_NS.PlotterObjects_NS;


namespace CHIA_RPC.Daemon_NS.Plotter_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the 'get_keys_for_plotting' functionality in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_keys_for_plotting"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Shows the farmer_public_key and pool_public_key for one or more wallet fingerprints.<br/>
    /// <br/>
    /// <b>Implicit Conversions To:</b><br/>
    /// - None.<br/>
    /// <br/>
    /// <b>Implicit Conversions From:</b><br/>
    /// - None.<br/>
    /// </remarks>
    public class GetKeysForPlotting_Response : ResponseTemplate<GetKeysForPlotting_Response>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public GetKeysForPlotting_Response() { /* for serialization */ }

        /// <summary>
        /// A dictionary where the key is the fingerprint and the value is an instance of <see cref="KeyInfo"/> containing 
        /// the farmer_public_key and pool_public_key.
        /// </summary>
        public Dictionary<ulong, KeyInfo> keys { get; set; }
    }
}