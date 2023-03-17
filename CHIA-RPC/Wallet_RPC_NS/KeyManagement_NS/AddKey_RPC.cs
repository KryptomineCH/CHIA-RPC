using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    /// <summary>
    /// Create/add a new key (wallet/fingerprint) from a given mnemonic seed phrase
    /// </summary>
    /// <remarks>first run GenerateMnemonic</remarks>
    public class AddKey_RPC : RPCTemplate<AddKey_RPC>
    {
        /// <summary>
        /// 24 word passphrase
        /// </summary>
        public string[] mnemonic { get; set; }
    }
}
