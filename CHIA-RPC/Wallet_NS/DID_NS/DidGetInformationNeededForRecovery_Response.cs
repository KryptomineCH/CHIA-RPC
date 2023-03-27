using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response class for the did_get_information_needed_for_recovery API method
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_information_needed_for_recovery"/><br/><br/>
    /// uses: <br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetInformationNeededForRecovery_Response : ResponseTemplate<DidGetInformationNeededForRecovery_Response>
    {
        /// <summary>
        /// List of backup DIDs
        /// </summary>
        public string[] backup_dids { get; set; }

        /// <summary>
        /// Coin name
        /// </summary>
        public string coin_name { get; set; }

        /// <summary>
        /// My DID
        /// </summary>
        public string my_did { get; set; }

        /// <summary>
        /// New puzzle hash
        /// </summary>
        public string newpuzhash { get; set; }

        /// <summary>
        /// Public key
        /// </summary>
        public string pubkey { get; set; }

        /// <summary>
        /// Wallet ID
        /// </summary>
        public ulong wallet_id { get; set; }
    }

}
