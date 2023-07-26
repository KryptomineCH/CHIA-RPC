using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.KeyManagement
{
    /// <summary>
    /// Create/add a new key (wallet/fingerprint) from a given mnemonic seed phrase
    /// </summary>
    /// <remarks>
    /// first run GenerateMnemonic <br/>
    /// <see href="https://docs.chia.net/wallet-rpc#add_key"/>
    /// </remarks>
    /// <returns><see cref="General_NS.FingerPrint_RPC"/></returns>
    public class AddKey_RPC : RPCTemplate<AddKey_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public AddKey_RPC() { /* for serialisation*/ }
        /// <summary>
        /// Create/add a new key (wallet/fingerprint) from a given mnemonic seed phrase
        /// </summary>
        /// <param name="mnemonic">24 word passphrase</param>
        public AddKey_RPC(string[] mnemonic)
        {
            this.mnemonic = mnemonic;
        }

        /// <summary>
        /// 24 word passphrase
        /// </summary>
        public string[]? mnemonic { get; set; }
    }
}
