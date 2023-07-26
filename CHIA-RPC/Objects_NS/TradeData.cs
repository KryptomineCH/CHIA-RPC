using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// The TradeData class is used to represent the data necessary for a trade transaction. 
    /// It encapsulates the address of the trading party, the amount of fungible asset to be traded (represented in two forms: mojos and xch), 
    /// and the type of fungible asset to be traded. 
    /// </summary>
    /// <remarks>
    /// A fungible asset is a type of asset that can be mutually interchanged with another identical asset. 
    /// It's commonly used in the blockchain industry to represent digital assets like tokens or coins. 
    /// The class provides a way to interchangeably represent the trading amount in two units: mojos and xch.
    /// Mojos are the smallest unit of account in the blockchain. 
    /// The 'amount_in_xch' property allows for a more human-friendly way of dealing with the trading amounts, 
    /// as it represents the amount in a higher unit (xch) that is more familiar to most users.
    /// </remarks>
    public class TradeData : ObjectTemplate<TradeData>
    {
        /// <summary>
        /// The address property represents the blockchain address of the trading party. 
        /// This is typically the public key, or a derived representation of the public key, that identifies a participant within the blockchain network.
        /// </summary>
        public string? address { get; set; }

        /// <summary>
        /// The amount property represents the quantity of the fungible asset that is being traded, in mojos.
        /// Mojos are the smallest unit of account in the blockchain.
        /// </summary>
        public ulong? amount { get; set; }

        /// <summary>
        /// The amount_in_xch property represents the quantity of the fungible asset that is being traded, in xch. 
        /// The xch unit is a larger unit of account in the blockchain, and is more commonly used in user interfaces due to its similarity to familiar currency systems.
        /// </summary>
        /// <remarks>
        /// This property is calculated from the 'amount' property and does not need to be manually set. 
        /// It provides a convenient way to handle the trading amount in a more human-friendly unit. 
        /// </remarks>
        [JsonIgnore]
        public decimal? amount_in_xch
        {
            get { return amount / GlobalVar.OneChiaInMojos; }
            set { amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// The asset property represents the type of fungible asset that is being traded. 
        /// This could be any kind of token or coin that exists on the blockchain.
        /// </summary>
        public string? asset { get; set; }
    }

}
