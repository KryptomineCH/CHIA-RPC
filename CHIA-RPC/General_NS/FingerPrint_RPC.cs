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

    /// <summary>
    /// used for a variety of wallet management and wallet selection tasks
    /// </summary>
    public class FingerPrint_RPC : RPCTemplate<FingerPrint_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public FingerPrint_RPC() { /* for serialisation */ }
        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrint_RPC(ulong fingerprint)
        {
            this.fingerprint = fingerprint;
        }
        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrint_RPC(FingerPrint_Response fingerprint)
        {
            this.fingerprint = fingerprint.fingerprint;
        }

        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// Implicit conversion from FingerPrint_Response to DidIFingerPrint_RPCD_RPC.
        /// </summary>
        /// <param name="response">FingerPrint_RPC object</param>
        public static implicit operator FingerPrint_RPC(FingerPrint_Response response)
        {
            return new FingerPrint_RPC(response);
        }
    }
}
