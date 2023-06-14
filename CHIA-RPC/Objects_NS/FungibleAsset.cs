using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

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

        /// <summary>
        /// The amount (in xch) to trade the NFT(s) for
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
