using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Harvester_NS
{
    /// <summary>
    /// Remove a directory from the harvester's list of plot directories
    /// </summary>
    /// <remarks> <see href="https://docs.chia.net/harvester-rpc/#remove_plot_directory"/> </remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class RemovePlotDirectory_RPC : RPCTemplate<RemovePlotDirectory_RPC>
    {
        /// <summary>
        /// The full path of the directory to remove
        /// </summary>
        public string dirname { get; set; }
    }
}
