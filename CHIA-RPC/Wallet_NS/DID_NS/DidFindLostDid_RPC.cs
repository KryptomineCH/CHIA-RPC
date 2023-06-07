using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Represents the response object for the did_find_lost_did RPC command.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_find_lost_did"/><br/><br/>
    /// Uses:<br/><see cref="DidFindLostDid_RPC"/>
    /// </remarks>
    public class DidFindLostDid_Response : ResponseTemplate<DidFindLostDid_Response>
    {
        /// <summary>
        /// The latest coin ID of the recovered DID wallet.
        /// </summary>
        public string latest_coin_id { get; set; }
    }

    /// <summary>
    /// RPC request for recovering a missing or unspendable DID wallet by submitting a coin id of the DID
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_find_lost_did"/></remarks>
    /// <returns><see cref="DidFindLostDid_Response"/></returns>
    public class DidFindLostDid_RPC : RPCTemplate<DidFindLostDid_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DidFindLostDid_RPC() { /* for serialisation */ }

        /// <summary>
        /// RPC request for recovering a missing or unspendable DID wallet by submitting a coin id of the DID
        /// </summary>
        /// <param name="coin_id">The DID ID, launcher ID, or latest coin ID of the DID you want to recover. The most time-efficient of these is the latest coin ID.</param>
        /// <param name="recovery_list_hash">Override the recovery list hash of the DID. Only set this if your last DID spend updated the recovery list</param>
        /// <param name="num_verification">Override the required verification number of the DID. Only set this if your last DID spend updated the required verification number</param>
        /// <param name="metadata">The new whole metadata in json format</param>
        public DidFindLostDid_RPC(string coin_id, string? recovery_list_hash, ulong? num_verification, string? metadata)
        {
            this.coin_id = coin_id;
            this.recovery_list_hash = recovery_list_hash;
            this.num_verification = num_verification;
            this.metadata = metadata;
        }



        /// <summary>
        /// The DID ID, launcher ID, or latest coin ID of the DID you want to recover. The most time-efficient of these is the latest coin ID.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// Override the recovery list hash of the DID. Only set this if your last DID spend updated the recovery list   
        /// </summary>
        /// <remarks>optional</remarks>
        public string? recovery_list_hash { get; set; }

        /// <summary>
        /// Override the required verification number of the DID. Only set this if your last DID spend updated the required verification number
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? num_verification { get; set; }

        /// <summary>
        /// The new whole metadata in json format 
        /// </summary>
        /// <remarks>optional</remarks>
        public string? metadata { get; set; }
    }
}
