using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class RoyaltyAsset : ObjectTemplate<RoyaltyAsset>
    {
        /// <summary>
        /// The asset ID of the NFT to be traded
        /// </summary>
        public string asset { get; set; }

        /// <summary>
        /// The address where the royalties will be sent
        /// </summary>
        public string royalty_address { get; set; }

        /// <summary>
        /// The number of basis points in the royalty, with three significant digits.
        /// </summary>
        public ulong royalty_percentage { get; set; }
    }
}
