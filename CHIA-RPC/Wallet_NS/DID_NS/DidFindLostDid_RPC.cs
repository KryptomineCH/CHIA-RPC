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
        /// The DID ID, launcher ID, or latest coin ID of the DID you want to recover. The most time-efficient of these is the latest coin ID.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string coin_id { get; set; }
        /// <summary>
        /// The hash of the recovery list
        /// </summary>
        /// <remarks>optional</remarks>
        public string? recovery_list_hash { get; set; }
        /// <remarks>optional</remarks>
        public ulong? num_verification { get; set; }
        /// <remarks>optional</remarks>
        public string? metadata { get; set; }
    }
}
