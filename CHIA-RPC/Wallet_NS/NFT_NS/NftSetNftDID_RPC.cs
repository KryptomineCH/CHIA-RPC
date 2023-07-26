using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Set the DID for a specific NFT (the NFT must support DIDs)
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/nft-rpc#nft_set_nft_did"/><br/><br/>
    /// Uses:<br/><see cref="NftSetNftDID_RPC"/>
    /// </remarks>
    public class NftSetNftDID_Response : ResponseTemplate<NftSetNftDID_Response>
    {
        /// <summary>
        /// The SpendBundle object associated with this operation. A SpendBundle includes the information about a spend operation, including the CoinSpends and an aggregated signature. This could be null if the operation hasn't been completed successfully.
        /// </summary>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// The unique identifier of the wallet involved in the operation. This could be null if the operation was not associated with a specific wallet.
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
    /// <summary>
    /// Set the DID for a specific NFT (the NFT must support DIDs)
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_set_nft_did"/></remarks>
    /// <returns><see cref="NftSetNftDID_Response"/></returns>
    public class NftSetNftDID_RPC : RPCTemplate<NftSetNftDID_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftSetNftDID_RPC() { /* for serialisation */ }
        /// <summary>
        /// Set the DID for a specific NFT (the NFT must support DIDs)
        /// </summary>
        /// <param name="wallet_id">The Wallet ID that holds the NFT on which to set the DID</param>
        /// <param name="nft_coin_id">The coin ID of the NFT on which to set the DID</param>
        /// <param name="did_id">Optionally: DID to be associated with this NFT. </param>
        /// <param name="fee">optional: The one-time blockchain fee (in mojos) to be used upon adding a URI</param>
        /// <param name="reuse_puzhash">Optionally: If true, will not generate a new puzzle hash / address for this transaction only. </param>
        public NftSetNftDID_RPC(ulong wallet_id, string nft_coin_id, string did_id, ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.nft_coin_id = nft_coin_id;
            this.did_id = did_id;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// The Wallet ID that holds the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// The coin ID of the NFT on which to set the DID
        /// </summary>
        /// <remarks>
        /// mandatory
        /// </remarks>
        public string? nft_coin_id { get; set; }

        /// <summary>
        /// Optionally: DID to be associated with this NFT. 
        /// If this parameter is not specified, the DID will be Unassigned
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public string? did_id { get; set; }

        /// <summary>
        /// optional: The one-time blockchain fee (in mojos) to be used upon adding a URI
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
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
