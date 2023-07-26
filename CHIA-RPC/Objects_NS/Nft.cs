using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// represents all blockchain stored data of an nft
    /// </summary>
    public class Nft : ObjectTemplate<Nft>
    {
        /// <summary>
        /// Represents non-human readable data related to the chain and a logo associated with the chain.
        /// Converted using the ChainInfoConverter.
        /// </summary>
        [JsonConverter(typeof(ChainInfoConverter))]
        public string? chain_info { get; set; }

        /// <summary>
        /// A SHA-256 hash used for validating the data fetched from the NFT's data URI.
        /// </summary>
        public string? data_hash { get; set; }

        /// <summary>
        /// A list of URIs that point to the NFT's data, typically images or other digital assets associated with the NFT.
        /// </summary>
        public List<string>? data_uris { get; set; }

        /// <summary>
        /// The launcher's identifier, unique to the entity that launched the NFT.
        /// </summary>
        public string? launcher_id { get; set; }

        /// <summary>
        /// The launcher's puzzle hash, which is a unique representation of the puzzle (or program) that controls the NFT.
        /// </summary>
        public string? launcher_puzhash { get; set; }

        /// <summary>
        /// A SHA-256 hash used for validating the license file associated with the NFT.
        /// </summary>
        public string? license_hash { get; set; }

        /// <summary>
        /// A list of URIs that point to the NFT's license file. The license file typically describes the rights and restrictions associated with the NFT.
        /// </summary>
        public List<string>? license_uris { get; set; }

        /// <summary>
        /// A SHA-256 hash used for validating the metadata JSON files associated with the NFT.
        /// </summary>
        public string? metadata_hash { get; set; }

        /// <summary>
        /// A list of URIs that point to the metadata JSON files associated with the NFT. These files describe the NFT in detail and are in line with the CHIP-0007 standard.
        /// </summary>
        public List<string>? metadata_uris { get; set; }

        /// <summary>
        /// The block height at which the NFT was minted. This represents the position of the block in the blockchain that recorded the minting of the NFT.
        /// </summary>
        public ulong mint_height { get; set; }

        /// <summary>
        /// The unique coin ID of the NFT represented as a SHA-256 hash. This is unique for each NFT and helps identify it on the blockchain.
        /// </summary>
        public string? nft_coin_id { get; set; }

        /// <summary>
        /// The Decentralized Identifier (DID) of the minter. This identifies the entity that minted the NFT.
        /// </summary>
        public string? minter_did { get; set; }

        /// <summary>
        /// The Decentralized Identifier (DID) of the owner. This identifies the current owner of the NFT.
        /// </summary>
        public string? owner_did { get; set; }

        /// <summary>
        /// Indicates if a transaction involving the NFT is still pending.
        /// </summary>
        public bool pending_transaction { get; set; }

        /// <summary>
        /// The royalty percentage to be paid when the NFT is sold. A royalty percentage of 1000 equals 1%.
        /// </summary>
        /// <remarks>
        /// a royalty percentage of 1000 = 1%
        /// </remarks>
        public ulong royalty_percentage { get; set; }

        /// <summary>
        /// The puzzle hash (similar to a blockchain address) that should receive the royalties when the NFT is sold.
        /// </summary>
        public string? royalty_puzzle_hash { get; set; }

        /// <summary>
        /// The edition number of the NFT. This represents the position of the NFT in a series or collection.
        /// </summary>
        public ulong edition_number { get; set; }

        /// <summary>
        /// The total number of NFTs in the series or collection to which this NFT belongs.
        /// </summary>
        public ulong edition_total { get; set; }

        /// <summary>
        /// Indicates if the NFT supports DIDs (Decentralized Identifiers) which provide a way to verify that a specific entity has control over the NFT.
        /// </summary>
        public bool supports_did { get; set; }

        /// <summary>
        /// The puzzle hash of the updater. The updater is responsible for updating the state of the NFT.
        /// </summary>
        public string? updater_puzhash { get; set; }
    }
}
