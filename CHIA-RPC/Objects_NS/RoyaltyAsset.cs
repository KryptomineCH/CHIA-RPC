using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Represents an NFT asset that is associated with a royalty fee. Royalty fees are a way for original creators 
    /// of NFTs to earn a commission every time their work is sold or transferred. The commission is calculated 
    /// based on the `royalty_percentage` property and is sent to the `royalty_address`.
    /// </summary>
    public class RoyaltyAsset : ObjectTemplate<RoyaltyAsset>
    {
        /// <summary>
        /// Represents the unique asset ID of the NFT that is being traded. Each NFT is represented by a unique 
        /// asset ID in the blockchain. This asset ID allows the NFT to be distinguished from all other tokens 
        /// in the network and is used to track its ownership and trading history.
        /// </summary>
        public string? asset { get; set; }

        /// <summary>
        /// Represents the blockchain address where the royalties from the sales of the NFT will be sent. 
        /// When the NFT is sold or transferred, a commission based on the `royalty_percentage` property 
        /// is calculated and sent to this address as a royalty payment. This allows the original creator 
        /// of the NFT to earn from secondary sales of their work.
        /// </summary>
        public string? royalty_address { get; set; }

        /// <summary>
        /// This property specifies the royalty fee as a percentage of the sale price of the NFT. The value 
        /// is expressed in basis points, where 1 basis point equals 0.01%. Therefore, a `royalty_percentage` 
        /// of 1000 would correspond to a 10% royalty fee. Whenever the NFT is sold or transferred, this 
        /// percentage of the sale price is sent to the `royalty_address` as a royalty payment.
        /// </summary>
        public ulong? royalty_percentage { get; set; }
    }

}
