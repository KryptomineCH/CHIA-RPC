using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// For a given wallet, fetch the recovery list, as well as the number of IDs required for recovery
    /// </summary>
    /// <remarks
    /// <see href="https://docs.chia.net/did-rpc#did_get_recovery_list"/><br/><br/>
    /// uses:<br/> <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetRecoveryList_Response : ResponseTemplate<DidGetRecoveryList_Response>
    {
        /// <summary>
        /// the amount of recovery dids required
        /// </summary>
        public ulong num_required { get; set; }
        /// <summary>
        /// the list of dids which can be used for recovery
        /// </summary>
        public string[] recovery_list { get; set; }
        /// <summary>
        /// the wallet ID which the request was for
        /// </summary>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// The name of the did wallet
        /// </summary>
        public string name { get; set; }
    }
}
