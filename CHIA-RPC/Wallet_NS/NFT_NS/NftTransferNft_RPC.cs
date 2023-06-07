using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Transfer an NFT to a new wallet address
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_transfer_nft"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_Response"/></returns>
    public class NftTransferNft_RPC : RPCTemplate<NftTransferNft_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftTransferNft_RPC() { /* for serialisation */ }
        /// <summary>
        /// Transfer an NFT to a new wallet address
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the NFT to transfer</param>
        /// <param name="target_address">The address to transfer the NFT to. For NFT0 this must be an XCH address. For NFT1 this could also be a DID address</param>
        /// <param name="nft_coin_id">The coin ID of the NFT to transfer</param>
        /// <param name="fee">The one-time blockchain fee (in mojos) to be used upon transferring the NFT</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only.   </param>
        public NftTransferNft_RPC(ulong wallet_id, string target_address, string nft_coin_id, ulong? fee, bool? reuse_puzhash)
        {
            this.wallet_id = wallet_id;
            this.target_address = target_address;
            this.nft_coin_id = nft_coin_id;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }


        /// <summary>
        /// The Wallet ID of the NFT to transfer
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The address to transfer the NFT to. For NFT0 this must be an XCH address. For NFT1 this could also be a DID address
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string target_address { get; set; }

        /// <summary>
        /// The coin ID of the NFT to transfer
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string nft_coin_id { get; set; }

        /// <summary>
        /// The one-time blockchain fee (in mojos) to be used upon transferring the NFT
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
