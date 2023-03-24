using CHIA_RPC.HelperFunctions_NS;


namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Class to represent a JSON RPC response for checking offer validity.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#check_offer_validity"/><br/><br/>
    /// Uses:<br/><see cref="CheckOfferValidity_RPC"/>
    /// </remarks>
    public class CheckOfferValidity_Response : ResponseTemplate<CheckOfferValidity_Response>
    {
        /// <summary>
        /// Whether the offer is valid or not.
        /// </summary>
        public bool valid { get; set; }
    }


    /// <summary>
    /// Class to represent a JSON RPC request for checking offer validity.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#check_offer_validity"/></remarks>
    /// <returns><see cref="CheckOfferValidity_Response"/></returns>
    public class CheckOfferValidity_RPC : RPCTemplate<CheckOfferValidity_RPC>
    {
        /// <summary>
        /// The contents of the offer to check.
        /// </summary>
        public string offer { get; set; }
    }

}
