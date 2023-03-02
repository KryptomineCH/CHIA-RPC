using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class FungibleAsset : ObjectTemplate<FungibleAsset>
    {
        /// <summary>
        /// The name of the asset for which to trade one or more NFTs
        /// </summary>
        public string asset { get; set; }

        /// <summary>
        /// The amount (in mojos) to trade the NFT(s) for
        /// </summary>
        public ulong amount { get; set; }
    }
}
