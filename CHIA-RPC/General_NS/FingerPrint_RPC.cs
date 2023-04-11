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
        public FingerPrint_RPC Get_RPC ()
        {
            return new FingerPrint_RPC
            {
                fingerprint = fingerprint
            };
        }
        /// <summary>
        /// Define the implicit conversion operator
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator FingerPrint_RPC(FingerPrint_Response response)
        {
            return response.Get_RPC();
        }
    }

    public class FingerPrint_RPC : RPCTemplate<FingerPrint_RPC>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
    }
}
