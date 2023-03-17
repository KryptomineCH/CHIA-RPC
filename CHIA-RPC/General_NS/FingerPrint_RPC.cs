using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// contains the fingerprint (unique ID of a wallet)
    /// </summary>
    public class FingerPrint_Response : ResponseTemplate<FingerPrint_Response>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
    }

    public class FingerPrint_RPC : RPCTemplate<FingerPrint_RPC>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
    }
}
