using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Delete a single plot
    /// </summary>
    /// <remarks>
    /// Returns a Success_Response
    /// </remarks>
    public class DeletePlot_RPC : RPCTemplate<DeletePlot_RPC>
    {
        /// <summary>
        /// The file name of the plot to delete
        /// </summary>
        public string filename { get; set; }
    }
}
