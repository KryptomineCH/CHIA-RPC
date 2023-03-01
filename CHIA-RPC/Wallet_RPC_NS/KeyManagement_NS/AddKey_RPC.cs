using System.Text.Json;
using System.Text;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class AddKey_RPC : RPCTemplate<AddKey_RPC>
    {
        /// <summary>
        /// 24 word passphrase
        /// </summary>
        public string[] mnemonic { get; set; }
    }
}
