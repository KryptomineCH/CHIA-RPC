using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Retrieve a the asset ID from a CAT wallet
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#cat_get_asset_id"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class CatGetAssetId_Response : ResponseTemplate<CatGetAssetId_Response>
    {
        /// <summary>
        /// The asset ID of the CAT wallet
        /// </summary>
        public string asset_id { get; set; }

        /// <summary>
        /// The wallet ID of the CAT whose ID was retrieved
        /// </summary>
        public ulong wallet_id { get; set; }
    }

}
