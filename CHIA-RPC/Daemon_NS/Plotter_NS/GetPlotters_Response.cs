using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Daemon_NS.Plotter_NS.PlotterObjects_NS;

namespace CHIA_RPC.Daemon_NS.Plotter_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the server response for the 'get_plotters' functionality in a blockchain network. Lists all available plotters.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#get_plotters"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// This is a parameterless request that lists all available plotters and their attributes.<br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <b>Returns:</b><br/>
    /// Instance of <see cref="GetPlotters_Response"/> containing the plotters.
    /// </returns>
    public class GetPlotters_Response : ResponseTemplate<GetPlotters_Response>
    {
        /// <summary>
        /// A dictionary where the key is the plotter name and the value is an instance of <see cref="PlotterInfo"/> containing 
        /// various attributes like memory warning, CUDA support, display name, installation status, and version.
        /// </summary>
        public Dictionary<string, IPlotterInfo> plotters { get; set; }
    }
}
