using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents a fungible asset in the Chia blockchain which can be traded for one or more non-fungible tokens (NFTs).
    /// </summary>
    /// <remarks>
    /// This class captures key properties of a fungible asset including its name and amount (both in mojos and xch). 
    /// This asset is to be traded for one or more NFTs in a transaction. The value of this asset is expressed in both 
    /// mojos (the smallest unit of currency in Chia) and xch (the primary unit of currency), and the conversion between 
    /// these units is handled internally.
    /// </remarks>
    public class FungibleAsset : ObjectTemplate<FungibleAsset>
    {
        /// <summary>
        /// The name of the fungible asset to be traded. This can be an arbitrary string but typically 
        /// identifies the asset in a way that is meaningful to users of the application.
        /// </summary>
        public string? asset { get; set; }

        /// <summary>
        /// The amount of the fungible asset to be traded, expressed in mojos. This is the smallest unit of 
        /// currency in the Chia network and is used to allow precise transactions without the need for fractional values.
        /// </summary>
        public ulong? amount { get; set; }

        /// <summary>
        /// The amount of the fungible asset to be traded, expressed in xch. This is the primary unit of currency in 
        /// the Chia network. The value is derived from the 'amount' field expressed in mojos.
        /// </summary>
        /// <remarks>
        /// The value in xch is derived from the mojos amount. This allows the value of the asset to be 
        /// expressed in the primary unit of currency used in the Chia network.
        /// </remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }
    }
}
