using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Delete a single plot
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/harvester-rpc/#delete_plot"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class DeletePlot_RPC : RPCTemplate<DeletePlot_RPC>
    {
        /// <summary>
        /// The file name of the plot to delete
        /// </summary>
        public string filename { get; set; }
    }
}
