using CHIA_RPC.FullNode_NS.Simulator_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.WalletNode_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// height RPC containt a specific height in the blockchain (point in time) for lookups
    /// </summary>
    public class Height_RPC : RPCTemplate<Height_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public Height_RPC() { /* for serialisation */ }
        /// <summary>
        /// height RPC containt a specific height in the blockchain (point in time) for lookups
        /// </summary>
        /// <param name="height">The height.</param>
        public Height_RPC(ulong height)
        {
            this.height = height;
        }
        /// <summary>
        /// height RPC containt a specific height in the blockchain (point in time) for lookups
        /// </summary>
        /// <param name="height">The height.</param>
        public Height_RPC(GetHeightInfo_Response heightInfo)
        {
            this.height = heightInfo.height;
        }
        /// <summary>
        /// height RPC containt a specific height in the blockchain (point in time) for lookups
        /// </summary>
        /// <param name="height">The height.</param>
        public Height_RPC(NewPeakHeight_Response heightInfo)
        {
            if (heightInfo.new_peak_height == null) throw new InvalidOperationException("NewPeakHeight_Response.new_peak_height == null!");
            this.height = (ulong) heightInfo.new_peak_height;
        }

        /// <summary>
        /// The height.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong height { get; set; }

        /// <summary>
        /// Implicit conversion from GetHeightInfo_Response to Height_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator Height_RPC(GetHeightInfo_Response response)
        {
            return new Height_RPC(response);
        }

        /// <summary>
        /// Implicit conversion from NewPeakHeight_Response to Height_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator Height_RPC(NewPeakHeight_Response response)
        {
            return new Height_RPC(response);
        }
    }
}
