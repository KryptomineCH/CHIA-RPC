using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class GenerateMnemonic_Response : ResponseTemplate<GenerateMnemonic_Response>
    {
        /// <summary>
        /// 24 word mnemonic passphrase for the wallet
        /// </summary>
        public string[] mnemonic { get; set; }
    }
}
