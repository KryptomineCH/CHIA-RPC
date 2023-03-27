using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents a response from the get_cat_list command, which returns the default CAT list.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#get_cat_list"/><br/><br/>
    /// Uses:<br/>The request does not have any parameters
    /// </remarks>
    public class GetCatList_Response : ResponseTemplate<GetCatList_Response>
    {
        /// <summary>
        /// Represents an individual CAT item in the response.
        /// </summary>
        public class CatItem
        {
            /// <summary>
            /// Gets or sets the asset ID of the CAT item.
            /// </summary>
            public string asset_id { get; set; }

            /// <summary>
            /// Gets or sets the name of the CAT item.
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// Gets or sets the symbol of the CAT item.
            /// </summary>
            public string symbol { get; set; }
        }

        /// <summary>
        /// Gets or sets the array of CAT items in the response.
        /// </summary>
        public CatItem[] cat_list { get; set; }
    }
}
