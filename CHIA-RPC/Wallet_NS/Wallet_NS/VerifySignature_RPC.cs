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
        /// Given a public key, message, and signature, verify if it is valid.
        /// </summary>
        /// <param name="pubkey">The public key of the signature to verify.</param>
        /// <param name="message">The message to verify.</param>
        /// <param name="signature">The signature to verify.</param>
        /// <param name="address">The address, which must be derived from `pubkey`.</param>
        /// <param name="signing_mode">Specify the type of signature to verify. Default is `BLS_SIG_BLS12381G2_XMD:SHA-256_SSWU_RO_AUG:hexinput_`</param>
        public VerifySignature_RPC(string pubkey, string message, string signature, string address, string? signing_mode = null)
        {
            this.pubkey = pubkey;
            this.message = message;
            this.signature = signature;
            this.address = address;
            this.signing_mode = signing_mode;
        }

        /// <summary>
        /// Gets or sets the signing mode used to verify the signature.
        /// </summary>
        /// <remarks>
        /// The signing mode strings are stored in an enum <see href="https://github.com/Chia-Network/chia-blockchain/blob/main/chia/types/signing_mode.py"/>.<br/><br/>
        /// As of Chia 2.0.0, valid signing mode strings include:<br/>
        /// `BLS_SIG_BLS12381G2_XMD:SHA-256_SSWU_RO_AUG:hexinput_` * Default signing mode<br/>
        /// Describes the standard BLS signatures used by Chia<br/>
        /// Uses a hex input<br/>
        /// Taken from [ietf.org] <see href="https://datatracker.ietf.org/doc/html/draft-irtf-cfrg-bls-signature-05#name-sign"/><br/>
        /// Cipher suites used for BLS signatures are also defined at <see href="https://datatracker.ietf.org/doc/html/draft-irtf-cfrg-bls-signature-05#name-ciphersuites"/><br/><br/>
        /// `BLS_SIG_BLS12381G2_XMD:SHA-256_SSWU_RO_AUG:utf8input_`<br/>
        /// Same as above, but uses UTF-8 instead of hex<br/><br/>
        /// `BLS_SIG_BLS12381G2_XMD:SHA-256_SSWU_RO_AUG:CHIP-0002_`<br/>
        /// [CHIP-0002] <see href="https://github.com/Chia-Network/chips/blob/main/CHIPs/chip-0002.md"/> signs the result of `sha256tree(cons("Chia Signed Message", message))` 
        /// using the BLS message augmentation scheme
        /// </remarks>
        public string? signing_mode { get; set; }


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
