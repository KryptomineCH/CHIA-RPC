
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Wallet_NS.VerifiableCredentials_NS.VerifiableCredentialsObjects_NS;
using CHIA_RPC.Wallet_NS.Wallet_NS;

namespace CHIA_RPC.Wallet_NS.VerifiableCredentials_NS
{
    /// <summary>
    /// <b>Summary:</b><br/>
    /// Represents the request for the `vc_revoke` command in the Chia RPC API.
    /// </summary>
    /// 
    /// <remarks>
    /// <b>Official Documentation:</b><br/>
    /// Refer to official API docs: <see href="https://docs.chia.net/wallet-rpc#vc_revoke"/><br/>
    /// <br/>
    /// <b>Functionality:</b><br/>
    /// Revoke an on chain VC provided the correct DID is available.<br/>
    /// <br/>
    /// <b>Parameters:</b><br/>
    /// - `vc_parent_id`: The parent ID of the VC coin. Type: <see cref="string"/>.
    /// - `reuse_puzhash`: If this flag is set, then send the VC back to the same puzzle hash it came from. Type: <see cref="bool"/>?.
    /// - `fee`: An optional blockchain fee, in mojos. Type: <see cref="ulong"/>?.<br/>
    /// </remarks>
    ///
    /// <returns>
    /// <see cref="GetTransactions_Response"/>
    /// </returns>
    public class VcRevoke_RPC : RPCTemplate<VcRevoke_RPC>
    {
        /// <summary>
        /// Parameterless constructor, for serializer
        /// </summary>
        public VcRevoke_RPC() { /* for serialisation */ }

        /// <summary>
        /// Revoke an on chain VC provided the correct DID is available.
        /// </summary>
        /// <param name="vc_parent_id">The parent ID of the VC coin.</param>
        /// <param name="reuse_puzhash">If this flag is set, then send the VC back to the same puzzle hash it came from.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public VcRevoke_RPC(string vc_parent_id, bool? reuse_puzhash = null, ulong? fee = null)
        {
            this.vc_parent_id = vc_parent_id;
            this.reuse_puzhash = reuse_puzhash;
            this.fee = fee;
        }
        /// <summary>
        /// Revoke an on chain VC provided the correct DID is available.
        /// </summary>
        /// <param name="verifiableCredential">the Vc to revoke.</param>
        /// <param name="reuse_puzhash">If this flag is set, then send the VC back to the same puzzle hash it came from.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public VcRevoke_RPC(Vc verifiableCredential, bool? reuse_puzhash = null, ulong? fee = null)
        {
            this.vc_parent_id = verifiableCredential.coin.parent_coin_info;
            this.reuse_puzhash = reuse_puzhash;
            this.fee = fee;
        }
        /// <summary>
        /// Revoke an on chain VC provided the correct DID is available.
        /// </summary>
        /// <param name="verifiableCredential">the Vc to revoke.</param>
        /// <param name="reuse_puzhash">If this flag is set, then send the VC back to the same puzzle hash it came from.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public VcRevoke_RPC(VcRecord verifiableCredential, bool? reuse_puzhash = null, ulong? fee = null)
        {
            this.vc_parent_id = verifiableCredential.vc.coin.parent_coin_info;
            this.reuse_puzhash = reuse_puzhash;
            this.fee = fee;
        }
        /// <summary>
        /// Revoke an on chain VC provided the correct DID is available.
        /// </summary>
        /// <param name="vcGetResponse">the Vc to revoke.</param>
        /// <param name="reuse_puzhash">If this flag is set, then send the VC back to the same puzzle hash it came from.</param>
        /// <param name="fee">An optional blockchain fee, in mojos.</param>
        public VcRevoke_RPC(VcGet_Response vcGetResponse, bool? reuse_puzhash = null, ulong? fee = null)
        {
            this.vc_parent_id = vcGetResponse.vc_record.vc.coin.parent_coin_info;
            this.reuse_puzhash = reuse_puzhash;
            this.fee = fee;
        }

        /// <summary>
        /// The parent ID of the VC coin.
        /// </summary>
        public string vc_parent_id { get; set; }

        /// <summary>
        /// If this flag is set, then send the VC back to the same puzzle hash it came from.
        /// </summary>
        public bool? reuse_puzhash { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }
    }

}
