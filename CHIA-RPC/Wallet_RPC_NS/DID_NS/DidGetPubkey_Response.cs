using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// returns the public key of a did wallet.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_pubkey"/><br/><br/>
    /// uses: <br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetPubkey_Response : ResponseTemplate<DidGetPubkey_Response>
    {
        /// <summary>
        /// The public key of the requested wallet
        /// </summary>
        public string pubkey { get; set; }
    }
}
