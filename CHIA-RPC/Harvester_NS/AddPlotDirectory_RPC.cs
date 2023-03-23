using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Represents the add_plot_directory JSON RPC request.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/harvester-rpc/#add_plot_directory"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class AddPlotDirectory_RPC : RPCTemplate<AddPlotDirectory_RPC>
    {
        /// <summary>
        /// Gets or sets the directory name.
        /// </summary>
        public string dirname { get; set; }
    }
}
