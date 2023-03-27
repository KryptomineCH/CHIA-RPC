using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response  class for the did_transfer_did API method
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_transfer_did"/><br/><br/>
    /// uses:<br/> <see cref="DidTransferDid_RPC"/>
    /// </remarks>
    public class DidTransferDid_Response : ResponseTemplate<DidTransferDid_Response>
    {
        /// <summary>
        /// The transaction object.
        /// </summary>
        public Transaction transaction { get; set; }
    }

    /// <summary>
    /// RPC class for the did_transfer_did API method
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_transfer_did"/></remarks>
    /// <returns><see cref="DidTransferDid_Response"/></returns>
    public class DidTransferDid_RPC : RPCTemplate<DidTransferDid_RPC>
    {
        /// <summary>
        /// The Wallet ID of the DID wallet to transfer
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The address of the inner puzzle to which to transfer the DID
        /// </summary>
        public string inner_address { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong fee { get; set; }
    }

}
