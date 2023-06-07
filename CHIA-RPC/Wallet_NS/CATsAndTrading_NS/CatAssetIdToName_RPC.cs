

using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents a response for retrieving a CAT's name from its ID.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#cat_asset_id_to_name"/><br/><br/>
    /// Uses:<br/><see cref="CatAssetIdToName_RPC"/>
    /// </remarks>
    public class CatAssetIdToName_Response : ResponseTemplate<CatAssetIdToName_Response>
    {
        /// <summary>
        /// The name of the retrieved CAT.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The ID of the wallet whose name was changed.
        /// </summary>
        public ulong? wallet_id { get; set; }
    }

    /// <summary>
    /// Represents a request to retrieve a CAT's name from its ID.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#cat_asset_id_to_name"/></remarks>
    /// <returns><see cref="CatAssetIdToName_Response"/></returns>
    public class CatAssetIdToName_RPC : RPCTemplate<CatAssetIdToName_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CatAssetIdToName_RPC() { /* for searialisation */ }
        /// <summary>
        /// Represents a request to retrieve a CAT's name from its ID.
        /// </summary>
        /// <param name="asset_id">The ID of the CAT whose name you would like to retrieve. This CAT must be listed in your DEFAULT_CATS, ie the CATs your wallet recognizes.</param>
        public CatAssetIdToName_RPC(string asset_id)
        {
            this.asset_id = asset_id;
        }

        /// <summary>
        /// The ID of the CAT whose name you would like to retrieve. This CAT must be listed in your DEFAULT_CATS, ie the CATs your wallet recognizes.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string asset_id { get; set; }
    }
}
