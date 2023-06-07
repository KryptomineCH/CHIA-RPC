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
        /// parameterless constructor, for serializer
        /// </summary>
        public DeletePlot_RPC() { /* for serialisaton */ }
        /// <summary>
        /// Delete a single plot
        /// </summary>
        /// <param name="filename">The file name of the plot to delete</param>
        public DeletePlot_RPC(string filename)
        {
            this.filename = filename;
        }
        /// <summary>
        /// Delete a single plot
        /// </summary>
        /// <param name="file">The file of the plot to delete</param>
        public DeletePlot_RPC(FileInfo file)
        {
            this.filename = file.FullName;
        }

        /// <summary>
        /// The file name of the plot to delete
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string filename { get; set; }
    }
}
