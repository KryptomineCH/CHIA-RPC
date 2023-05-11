using System.ComponentModel.DataAnnotations;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Update the metadata for a DID wallet. The current metadata can be obtained with the did_get_metadata endpoint
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_update_metadata"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class DidUpdateMetadata_RPC : RPCTemplate<DidUpdateMetadata_RPC>
    {
        public DidUpdateMetadata_RPC() { /* for serialisation purposes */ }
        public DidUpdateMetadata_RPC(ulong wallet_id, Dictionary<string, object> metadata, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.metadata = metadata;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// the id of the wallet which should be updated
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The new metadata
        /// </summary>
        /// <remarks>mandatory</remarks>
        public Dictionary<string, object> metadata { get; set; }
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
