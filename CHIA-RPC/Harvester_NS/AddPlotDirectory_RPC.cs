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
        /// parameterless constructor, for serializer
        /// </summary>
        public AddPlotDirectory_RPC() { /* for serialisation */ }
        /// <summary>
        /// Gets or sets the directory name.
        /// </summary>
        /// <param name="dirname">the directory which shold be added</param>
        public AddPlotDirectory_RPC(string dirname)
        {
            this.dirname = dirname;
        }
        /// <summary>
        /// Gets or sets the directory name.
        /// </summary>
        /// <param name="dir">the directory which shold be added</param>
        public AddPlotDirectory_RPC(DirectoryInfo dir)
        {
            this.dirname = dir.FullName;
        }

        /// <summary>
        /// the directory which shold be added
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? dirname { get; set; }
    }
}
