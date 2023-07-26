using System.ComponentModel.DataAnnotations;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Append one or more IDs to be used for recovery of a DID wallet. The current list can be obtained with the did_get_recovery_list endpoint
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_update_recovery_ids"/> </remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class DidUpdateRecoveryIDs_RPC : RPCTemplate<DidUpdateRecoveryIDs_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DidUpdateRecoveryIDs_RPC() { /* for serialisation */ }
        /// <summary>
        /// Append one or more IDs to be used for recovery of a DID wallet. The current list can be obtained with the did_get_recovery_list endpoint
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="new_list">The new recovery ID list. Each item from this list will be appended to the existing list</param>
        /// <param name="num_verifications_required">Optionally set the number of IDs required for wallet recovery. If not set, then the entire updated list will be required by default</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        /// <param name="reuse_puzzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public DidUpdateRecoveryIDs_RPC(ulong wallet_id, string[] new_list, ulong? num_verifications_required = null, ulong? fee = null, bool? reuse_puzzhash = null)
        {
            this.wallet_id = wallet_id;
            this.new_list = new_list;
            this.num_verifications_required = num_verifications_required;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzzhash;
        }
        /// <summary>
        /// Append one or more IDs to be used for recovery of a DID wallet. The current list can be obtained with the did_get_recovery_list endpoint
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="new_list">The new recovery ID list. Each item from this list will be appended to the existing list</param>
        /// <param name="num_verifications_required">Optionally set the number of IDs required for wallet recovery. If not set, then the entire updated list will be required by default</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        /// <param name="reuse_puzzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public DidUpdateRecoveryIDs_RPC(WalletID_RPC wallet_id, string[] new_list, ulong? num_verifications_required = null, ulong? fee = null, bool? reuse_puzzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.new_list = new_list;
            this.num_verifications_required = num_verifications_required;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzzhash;
        }
        /// <summary>
        /// Append one or more IDs to be used for recovery of a DID wallet. The current list can be obtained with the did_get_recovery_list endpoint
        /// </summary>
        /// <param name="wallet_id">the id of the wallet which should be updated</param>
        /// <param name="new_list">The new recovery ID list. Each item from this list will be appended to the existing list</param>
        /// <param name="num_verifications_required">Optionally set the number of IDs required for wallet recovery. If not set, then the entire updated list will be required by default</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        /// <param name="reuse_puzzhash">If `true`, will not generate a new puzzle hash / address for this transaction only. </param>
        public DidUpdateRecoveryIDs_RPC(WalletID_Response wallet_id, string[] new_list, ulong? num_verifications_required = null, ulong? fee = null, bool? reuse_puzzhash = null)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.new_list = new_list;
            this.num_verifications_required = num_verifications_required;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzzhash;
        }

        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong? wallet_id { get; set; }
        /// <summary>
        /// The new recovery ID list. Each item from this list will be appended to the existing list
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[]? new_list { get; set; }
        /// <summary>
        /// Optionally set the number of IDs required for wallet recovery. If not set, then the entire updated list will be required by default
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_verifications_required { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// If `true`, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
