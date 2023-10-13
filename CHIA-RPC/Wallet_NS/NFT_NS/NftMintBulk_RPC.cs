using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Create a spend bundle to mint multiple NFTs. <br/>
    /// Note that this command does not push the spend bundle to the blockchain. 
    /// See documentation for <see href="https://docs.chia.net/wallet-rpc#push_tx"/> for info to accomplish this.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_mint_bulk"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_Response"/></returns>
    public class NftMintBulk_RPC : RPCTemplate<NftMintBulk_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftMintBulk_RPC() { /* for serialisation */ }
        /// <summary>
        /// Create a spend bundle to mint multiple NFTs.
        /// </summary>
        /// <param name="wallet_id">The ID of the NFT wallet to use for bulk minting</param>
        /// <param name="metadata_list">A list of dicts containing the metadata for each NFT to be minted</param>
        /// <param name="royalty_percentage">The royalty that will go to the original artist each time the NFT is sold</param>
        /// <param name="royalty_address">The wallet address of the NFT's artist. This is where royalties will be sent. It could be either an XCH address or a DID address</param>
        /// <param name="target_list">A list of wallet addresses where the NFTs will be sent upon minting</param>
        /// <param name="mint_number_start">The starting point for mint number used in intermediate launcher puzzle</param>
        /// <param name="mint_total">The total number of NFTs in the collection. </param>
        /// <param name="xch_coin_list">A list of coins to be used for funding the minting spend</param>
        /// <param name="xch_change_target">For use with bulk minting, so we can specify the puzzle hash that the change from the funding transaction goes to</param>
        /// <param name="new_innerpuzhash">The new inner puzzle hash for the DID once it is spent.</param>
        /// <param name="new_p2_puzhash">The new p2 puzzle hash for the DID once it is spent</param>
        /// <param name="did_coin_dict">The did coin to use for minting. </param>
        /// <param name="did_lineage_parent_hex">The parent coin to use for the lineage proof in the DID spend</param>
        /// <param name="mint_from_did">Boolean to determine whether to mint from a DID</param>
        /// <param name="fee">A blockchain fee (in mojos) to be deducted with each mint</param>
        /// <param name="reuse_puzhash">If true, will not generate a new puzzle hash / address for this transaction only. </param>
        public NftMintBulk_RPC(
            ulong wallet_id, MintMetadata[] metadata_list, 
            ulong? royalty_percentage = null, string? royalty_address = null, 
            string[]? target_list = null, ulong? mint_number_start = null, 
            ulong? mint_total = null, string[]? xch_coin_list = null, 
            string? xch_change_target = null, string? new_innerpuzhash = null, 
            string? new_p2_puzhash = null, object? did_coin_dict = null, 
            string? did_lineage_parent_hex = null, bool? mint_from_did = null, 
            ulong? fee = null, bool? reuse_puzhash = null)
        {
            this.wallet_id = wallet_id;
            this.metadata_list = metadata_list;
            this.royalty_percentage = royalty_percentage;
            this.royalty_address = royalty_address;
            this.target_list = target_list;
            this.mint_number_start = mint_number_start;
            this.mint_total = mint_total;
            this.xch_coin_list = xch_coin_list;
            this.xch_change_target = xch_change_target;
            this.new_innerpuzhash = new_innerpuzhash;
            this.new_p2_puzhash = new_p2_puzhash;
            this.did_coin_dict = did_coin_dict;
            this.did_lineage_parent_hex = did_lineage_parent_hex;
            this.mint_from_did = mint_from_did;
            this.fee = fee;
            this.reuse_puzhash = reuse_puzhash;
        }

        /// <summary>
        /// The ID of the NFT wallet to use for bulk minting
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// A list of dicts containing the metadata for each NFT to be minted
        /// </summary>
        /// <remarks>
        /// up to 25 nfts may be minted at a time. 
        /// You can set more but the bulkmint will chunk. 
        /// It is recommended to supply only up to 25 nfts at a time
        /// </remarks>
        public MintMetadata[]? metadata_list { get; set; }

        /// <summary>
        /// The royalty that will go to the original artist each time the NFT is sold
        /// </summary>
        /// <remarks>The percentage is multiplied by 100 -- for example, to set a 3% royalty, set this value to 300. The default value is 0</remarks>
        public ulong? royalty_percentage { get; set; }

        /// <summary>
        /// The wallet address of the NFT's artist. This is where royalties will be sent. It could be either an XCH address or a DID address
        /// </summary>
        public string? royalty_address { get; set; }

        /// <summary>
        /// A list of wallet addresses where the NFTs will be sent upon minting
        /// </summary>
        public string[]? target_list { get; set; }

        /// <summary>
        /// The starting point for mint number used in intermediate launcher puzzle
        /// </summary>
        public ulong? mint_number_start { get; set; }

        /// <summary>
        /// The total number of NFTs in the collection. 
        /// Note that this is not necessarily reflective of the number of NFTs this command will create in the spend bundle, which is derived based on the metadata_list. 
        /// For example, you could set mint_total to 1000 and pass only 10 dicts in metadata_list.
        /// </summary>
        public ulong? mint_total { get; set; }

        /// <summary>
        /// A list of coins to be used for funding the minting spend
        /// </summary>
        /// <remarks>
        /// this is required if no fee is set. You may obtain it with the select coins by amont command
        /// </remarks>
        public string[]? xch_coin_list { get; set; }

        /// <summary>
        /// For use with bulk minting, so we can specify the puzzle hash that the change from the funding transaction goes to
        /// </summary>
        /// <remarks>hex string</remarks>
        public string? xch_change_target { get; set; }

        /// <summary>
        /// The new inner puzzle hash for the DID once it is spent.
        /// </summary>
        /// <remarks>
        /// For bulk minting we generally don't provide this as the default behaviour is to re-use the existing inner puzzle hash<br/>
        /// hex string
        /// </remarks>
        public string? new_innerpuzhash { get; set; }

        /// <summary>
        /// The new p2 puzzle hash for the DID once it is spent
        /// </summary>
        /// <remarks>
        /// For bulk minting we generally don't provide this as the default behaviour is to re-use the existing inner puzzle hash<br/>
        /// hex string
        /// </remarks>
        public string? new_p2_puzhash { get; set; }

        /// <summary>
        /// The did coin to use for minting. 
        /// </summary>
        /// <remarks>Required for bulk minting when the DID coin will be created in the future</remarks>
        public object? did_coin_dict { get; set; }

        /// <summary>
        /// The parent coin to use for the lineage proof in the DID spend
        /// </summary>
        /// <remarks>Needed for bulk minting when the coin will be created in the future</remarks>
        public string? did_lineage_parent_hex { get; set; }

        /// <summary>
        /// Boolean to determine whether to mint from a DID
        /// </summary>
        /// <remarks>Default: false</remarks>
        public bool? mint_from_did { get; set; }

        /// <summary>
        /// A blockchain fee (in mojos) to be deducted with each mint
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        /// If true, will not generate a new puzzle hash / address for this transaction only. 
        /// </summary>
        /// <remarks>
        /// Note that setting this parameter to true will override the global default setting from config.yaml
        /// </remarks>
        public bool? reuse_puzhash { get; set; }
    }
    /// <summary>
    /// Contains all information which is required to mintd an nft
    /// </summary>
    /// <remarks>used by <see cref="NftMintBulk_RPC"/></remarks>
    public class MintMetadata
    {
        /// <summary>
        /// uri set to the image/media/documents
        /// </summary>
        public string[]? uris { get; set; }
        /// <summary>
        /// uri set to the nft metadata
        /// </summary>
        public string[]? meta_uris { get; set; }
        /// <summary>
        /// uri set to the nft license
        /// </summary>
        public string[]? license_uris { get; set; }
        /// <summary>
        /// valitadion hash from the image/media/document
        /// </summary>
        public string? hash { get; set; }
        /// <summary>
        /// valitadion hash from the nft metadata
        /// </summary>
        public string? meta_hash { get; set; }
        /// <summary>
        /// valitadion hash from the nft license
        /// </summary>
        public string? license_hash { get; set; }
        /// <summary>
        /// which position does the nft have in the collection?
        /// </summary>
        public ulong? edition_number { get; set; }
        /// <summary>
        /// how many nfts does the collection have in total?
        /// </summary>
        public ulong? edition_total { get; set; }
    }
}
