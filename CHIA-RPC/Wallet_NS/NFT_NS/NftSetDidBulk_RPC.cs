using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Bulk set DID for NFTs across different wallets.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_set_did_bulk"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_MultiWallet_Response"/></returns>
    public class NftSetDidBulk_RPC : RPCTemplate<NftSetDidBulk_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftSetDidBulk_RPC() { /* for serialisation */ }
        /// <summary>
        /// Bulk set DID for NFTs across different wallets.
        /// </summary>
        /// <param name="nft_coin_list">A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. </param>
        /// <param name="did_id">The ID of the DID to which to transfer the NFTs. [Default: no DID (reset the NFTs' DIDs)]</param>
        /// <param name="fee">An optional blockchain fee.</param>
        /// <param name="reuse_puzhash">Optionally: If true, will not generate a new puzzle hash / address for this transaction only.</param>
        public NftSetDidBulk_RPC(NftCoinIdAndWalletId[] nft_coin_list, string did_id, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.nft_coin_list = nft_coin_list;
            this.did_id = did_id;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// A list of coin IDs corresponding to the NFTs, along with the current wallet_ids. 
        /// </summary>
        public NftCoinIdAndWalletId[] nft_coin_list { get; set; }

        /// <summary>
        /// The ID of the DID to which to transfer the NFTs. [Default: no DID (reset the NFTs' DIDs)]
        /// </summary>
        public string did_id { get; set; }

        /// <summary>
        /// An optional blockchain fee.
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// Optionally: If true, will not generate a new puzzle hash / address for this transaction only. 
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
