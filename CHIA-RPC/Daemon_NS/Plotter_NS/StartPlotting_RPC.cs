using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.Plotter_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the request parameters for starting a new plot or plots in a blockchain network.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#start_plotting"/><br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `service`: The plotting service to use. Type: <see cref="string"/>.<br/>
    /// - `plotter`: The plotter to use. Default is "chiapos". Type: <see cref="string"/>.<br/>
    /// - `delay`: The number of seconds to delay before starting to plot. Default is 0. Type: <see cref="int?"/>.<br/>
    /// - `parallel`: Set to create multiple plots in parallel. Default is false. Type: <see cref="bool?"/>.<br/>
    /// - `k`: The k-size of the plot to create. Type: <see cref="int"/>.<br/>
    /// - `overrideK`: Set to true to create a plot smaller than k-32. Type: <see cref="bool"/>.<br/>
    /// - `r`: The number of threads to use for creating the plot(s). Type: <see cref="int"/>.<br/>
    /// - `b`: Size of the buffer, in MB. Type: <see cref="int"/>.<br/>
    /// - `u`: Number of buckets. Type: <see cref="int"/>.<br/>
    /// - `e`: Set to true to disable bitfield. Type: <see cref="bool"/>.<br/>
    /// - `t`: The temporary directory where the plot will be created. Type: <see cref="string"/>.<br/>
    /// - `d`: The destination where the plot will be moved after it has been created. Type: <see cref="string"/>.<br/>
    /// - `x`: Set to true to skip moving the plot after it has been created. Type: <see cref="bool"/>.<br/>
    /// - `n`: The number of plots to create. Default is 1. Type: <see cref="int?"/>.<br/>
    /// - `queue`: The type of plotting queue. Default is "default". Type: <see cref="string"/>.<br/>
    /// </remarks>

    public class StartPlotting_RPC : RPCTemplate<StartPlotting_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public StartPlotting_RPC() { /* for serialisation */ }
        /// <summary>
        /// Initializes a new instance of StartPlotting_RPC with all available parameters.
        /// </summary>
        /// <param name="service">The plotting service to use. Type: <see cref="string"/>.</param>
        /// <param name="plotter">The plotter to use. Default is "chiapos". Type: <see cref="string"/>.</param>
        /// <param name="delay">The number of seconds to delay before starting to plot. Default is 0. Type: <see cref="int?"/>.</param>
        /// <param name="parallel">Set to create multiple plots in parallel. Default is false. Type: <see cref="bool?"/>.</param>
        /// <param name="k">The k-size of the plot to create. Type: <see cref="int"/>.</param>
        /// <param name="overrideK">Set to true to create a plot smaller than k-32. Type: <see cref="bool"/>.</param>
        /// <param name="r">The number of threads to use for creating the plot(s). Type: <see cref="int"/>.</param>
        /// <param name="b">Size of the buffer, in MB. Type: <see cref="int"/>.</param>
        /// <param name="u">Number of buckets. Type: <see cref="int"/>.</param>
        /// <param name="e">Set to true to disable bitfield. Type: <see cref="bool"/>.</param>
        /// <param name="t">The temporary directory where the plot will be created. Type: <see cref="string"/>.</param>
        /// <param name="d">The destination where the plot will be moved after it has been created. Type: <see cref="string"/>.</param>
        /// <param name="x">Set to true to skip moving the plot after it has been created. Type: <see cref="bool"/>.</param>
        /// <param name="n">The number of plots to create. Default is 1. Type: <see cref="int?"/>.</param>
        /// <param name="queue">The type of plotting queue. Default is "default". Type: <see cref="string"/>.</param>
        public StartPlotting_RPC(string service, string plotter, int? delay, bool? parallel, int k, bool overrideK, int r, int b, int u, bool e, string t, string d, bool x, int? n, string queue)
        {
            this.service = service;
            this.plotter = plotter;
            this.delay = delay;
            this.parallel = parallel;
            this.k = k;
            this.overrideK = overrideK;
            this.r = r;
            this.b = b;
            this.u = u;
            this.e = e;
            this.t = t;
            this.d = d;
            this.x = x;
            this.n = n;
            this.queue = queue;
        }
        /// <summary>
        /// The plotting service to use.
        /// </summary>
        public string service { get; set; }

        /// <summary>
        /// The plotter to use. Default is "chiapos".
        /// </summary>
        public string plotter { get; set; }

        /// <summary>
        /// The number of seconds to delay before starting to plot. Default is 0.
        /// </summary>
        public int? delay { get; set; }

        /// <summary>
        /// Set to create multiple plots in parallel. Default is false.
        /// </summary>
        public bool? parallel { get; set; }

        /// <summary>
        /// The k-size of the plot to create.
        /// </summary>
        public int k { get; set; }

        /// <summary>
        /// Set to true to create a plot smaller than k-32.
        /// </summary>
        public bool overrideK { get; set; }

        /// <summary>
        /// The number of threads to use for creating the plot(s).
        /// </summary>
        public int r { get; set; }

        /// <summary>
        /// Size of the buffer, in MB.
        /// </summary>
        public int b { get; set; }

        /// <summary>
        /// Number of buckets.
        /// </summary>
        public int u { get; set; }

        /// <summary>
        /// Set to true to disable bitfield.
        /// </summary>
        public bool e { get; set; }

        /// <summary>
        /// The temporary directory where the plot will be created.
        /// </summary>
        public string t { get; set; }

        /// <summary>
        /// The destination where the plot will be moved after it has been created.
        /// </summary>
        public string d { get; set; }

        /// <summary>
        /// Set to true to skip moving the plot after it has been created.
        /// </summary>
        public bool x { get; set; }

        /// <summary>
        /// The number of plots to create. Default is 1.
        /// </summary>
        public int? n { get; set; }

        /// <summary>
        /// The type of plotting queue. Default is "default".
        /// </summary>
        public string queue { get; set; }
    }

}
