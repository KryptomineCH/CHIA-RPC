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
        /// parameterless constructor, for serializer
        /// </summary>
        public RemovePlotDirectory_RPC() { /* for serialisation */ }
        /// <summary>
        /// Remove a directory from the harvester's list of plot directories
        /// </summary>
        /// <param name="dirname">The full path of the directory to remove</param>
        public RemovePlotDirectory_RPC(string dirname)
        {
            this.dirname = dirname;
        }
        /// <summary>
        /// Remove a directory from the harvester's list of plot directories
        /// </summary>
        /// <param name="dir">The full path of the directory to remove</param>
        public RemovePlotDirectory_RPC(DirectoryInfo dir)
        {
            this.dirname = dir.FullName;
        }

        /// <summary>
        /// The full path of the directory to remove
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? dirname { get; set; }
    }
}
