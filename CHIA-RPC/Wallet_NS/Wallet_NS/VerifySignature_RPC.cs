using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// Given a public key, message and signature, verify if it is valid.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#verify_signature"/></remarks>
    /// <returns>?</returns>
    public class VerifySignature_RPC : RPCTemplate<VerifySignature_RPC>
    {
        /// <summary>
        /// Parameterless Constructor, for serialisation
        /// </summary>
        public VerifySignature_RPC() { /* for serialisation */ }
        /// <summary>
        /// Given a public key, message and signature, verify if it is valid.
        /// </summary>
        /// <param name="pubkey">The public key of the signature to verify</param>
        /// <param name="message">The message to verify</param>
        /// <param name="signature">The signature to verify</param>
        /// <param name="address">The address, which must be derived from pubkey</param>
        public VerifySignature_RPC(string pubkey, string message, string signature, string address)
        {
            this.pubkey = pubkey;
            this.message = message;
            this.signature = signature;
            this.address = address;
        }

        /// <summary>
        /// The public key of the signature to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? pubkey { get; set; }
        /// <summary>
        /// The message to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? message { get; set; }
        /// <summary>
        /// The signature to verify
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? signature { get; set; }
        /// <summary>
        /// The address, which must be derived from pubkey
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? address { get; set; }
    }
}
