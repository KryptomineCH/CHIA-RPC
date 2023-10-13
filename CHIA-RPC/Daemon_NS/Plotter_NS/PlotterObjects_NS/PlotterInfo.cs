using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Plotter_NS.PlotterObjects_NS
{
    /// <summary>
    /// Interface defining the mandatory attributes of a plotter.
    /// </summary>
    public interface IPlotterInfo
    {
        /// <summary>
        /// The display name of the plotter.
        /// </summary>
        string display_name { get; }

        /// <summary>
        /// Indicates if the plotter is installed.
        /// </summary>
        bool installed { get; }

        /// <summary>
        /// The version of the plotter.
        /// </summary>
        string version { get; }
    }

    /// <summary>
    /// Base class implementing IPlotterInfo with mandatory fields.
    /// </summary>
    public class PlotterInfo : ObjectTemplate<PlotterInfo>, IPlotterInfo
    {
        public string display_name { get; set; }
        public bool installed { get; set; }
        public string version { get; set; }
    }

    /// <summary>
    /// Derived class for BladeBit plotter, including specific optional attributes.
    /// </summary>
    public class BladeBitInfo : PlotterInfo
    {
        /// <summary>
        /// Warning related to the required memory for BladeBit.
        /// </summary>
        public string bladebit_memory_warning { get; set; }

        /// <summary>
        /// Indicates if BladeBit has CUDA support.
        /// </summary>
        public bool? cuda_support { get; set; }
    }
}
