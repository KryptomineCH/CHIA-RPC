using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Represents the add_plot_directory JSON RPC request.
    /// </summary>
    public class AddPlotDirectory_RPC : RPCTemplate<AddPlotDirectory_RPC>
    {
        /// <summary>
        /// Gets or sets the directory name.
        /// </summary>
        public string dirname { get; set; }
    }
}
