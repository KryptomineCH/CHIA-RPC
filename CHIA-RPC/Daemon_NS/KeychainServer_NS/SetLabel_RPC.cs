using CHIA_RPC.Daemon_NS.KeychainServer_NS.KeychainServer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Daemon_NS.KeychainServer_NS
{
    /// <summary>
    /// Represents the JSON RPC request for the set_label function.<br/>
    /// This RPC sets the label for the specified key.
    /// </summary>
    /// <remarks>
    /// returns a <see cref="Success_Response"/>
    /// <see href="https://docs.chia.net/daemon-rpc#set_label"/><br/>
    /// </remarks>
    public class SetLabel_RPC : RPCTemplate<SetLabel_RPC>
    {
        /// <summary>
        /// Parameterless constructor, used for serialization.
        /// </summary>
        public SetLabel_RPC() { /* for serialisation */ }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetLabel_RPC"/> class with fingerprint and label.
        /// </summary>
        /// <param name="fingerprint">The fingerprint of the key whose label you want to set.</param>
        /// <param name="label">The new label to set for the key.</param>
        public SetLabel_RPC(ulong fingerprint, string label)
        {
            this.fingerprint = fingerprint;
            this.label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetLabel_RPC"/> class using an instance of <see cref="FingerPrint_RPC"/>.
        /// </summary>
        /// <param name="fingerprint">An instance of <see cref="FingerPrint_RPC"/> containing the fingerprint.</param>
        /// <param name="label">The new label to set for the key.</param>
        public SetLabel_RPC(FingerPrint_RPC fingerprint, string label)
        {
            this.fingerprint = fingerprint.fingerprint;
            this.label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetLabel_RPC"/> class using an instance of <see cref="FingerPrint_Response"/>.
        /// </summary>
        /// <param name="fingerprint">An instance of <see cref="FingerPrint_Response"/> containing the fingerprint.</param>
        /// <param name="label">The new label to set for the key.</param>
        public SetLabel_RPC(FingerPrint_Response fingerprint, string label)
        {
            this.fingerprint = fingerprint.fingerprint;
            this.label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetLabel_RPC"/> class using an instance of <see cref="Key"/>.
        /// </summary>
        /// <param name="key">An instance of <see cref="Key"/> containing the fingerprint.</param>
        /// <param name="label">The new label to set for the key.</param>
        public SetLabel_RPC(Key key, string label)
        {
            this.fingerprint = key.fingerprint;
            this.label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetLabel_RPC"/> class using an instance of <see cref="GetKey_Response"/>.
        /// </summary>
        /// <param name="keyResponse">An instance of <see cref="GetKey_Response"/> containing the key information.</param>
        /// <param name="label">The new label to set for the key.</param>
        public SetLabel_RPC(GetKey_Response keyResponse, string label)
        {
            this.fingerprint = keyResponse.key.fingerprint;
            this.label = label;
        }

        /// <summary>
        /// The fingerprint whose label you want to set.
        /// </summary>
        public ulong fingerprint { get; set; }

        /// <summary>
        /// The new label for the specified key.
        /// </summary>
        public string label { get; set; }
    }

}
