using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftTransferNft_RPC : RPCTemplate<NftTransferNft_RPC>
    {
        /// <summary>
        /// The Wallet ID of the NFT to transfer
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The address to transfer the NFT to. For NFT0 this must be an XCH address. For NFT1 this could also be a DID address
        /// </summary>
        public string target_address { get; set; }

        /// <summary>
        /// The coin ID of the NFT to transfer
        /// </summary>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon transferring the NFT
        /// </summary>
        public ulong fee { get; set; }
    }
}
