using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the request parameters for adding a new private key from a mnemonic word list.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/daemon-rpc#add_private_key"/><br/>
    /// <br/>
    /// <b>Remarks:</b><br/>
    /// Requirements for the mnemonic word list:
    /// <list type="bullet">
    /// <item><description>Must be input as a single string</description></item>
    /// <item><description>Order is important</description></item>
    /// <item><description>Must be delineated by spaces</description></item>
    /// <item><description>Must be either 12 or 24 words long</description></item>
    /// <item><description>Each word must be in the BIP-39 word list</description></item>
    /// <item><description>The mnemonic must form a valid private key</description></item>
    /// </list>
    /// <br/>
    /// </remarks>
    /// 
    /// <returns>
    /// <see cref="FingerPrint_Response"/>.
    /// </returns>
    public class AddPrivateKey_RPC : RPCTemplate<AddPrivateKey_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public AddPrivateKey_RPC() { /* for serialisation */ }

        /// <summary>
        /// initializes a new AddPrivateKey_RPC in order to create / import a primary wallet
        /// </summary>
        /// <param name="mnemonic"></param>
        /// <param name="label"></param>
        public AddPrivateKey_RPC(string mnemonic, string label) {
            this.mnemonic = mnemonic;
            this.label = label;
        }

        /// <summary>
        /// The mnemonic word list.
        /// </summary>
        public string mnemonic { get; set; }

        /// <summary>
        /// The label to assign for this key. Default is None.
        /// </summary>
        public string label { get; set; }
    }

}
