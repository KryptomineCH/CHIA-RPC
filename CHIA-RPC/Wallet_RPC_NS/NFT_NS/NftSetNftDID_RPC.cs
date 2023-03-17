using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    public class NftSetNftDID_Response : ResponseTemplate<NftSetNftDID_Response>
    {
        public SpendBundle spend_bundle { get; set; }
        public ulong wallet_id { get; set; }
    }
    public class NftSetNftDID_RPC : RPCTemplate<NftSetNftDID_RPC>
    {
        /// <summary>
        /// The Wallet ID that holds the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// Optionally: DID to be associated with this NFT. 
        /// If this parameter is not specified, the DID will be Unassigned
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public string did_id { get; set; }

        /// <summary>
        /// optional: The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public ulong? fee { get; set; }
    }
}
