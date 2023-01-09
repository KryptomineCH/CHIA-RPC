namespace CHIA_RPC.Objects_NS
{
    public class Nft
    {
        /// <summary>
        /// some non human readable data and a chain logo
        /// </summary>
        public string chain_info { get; set; }
        /// <summary>
        /// a sha256sum to validate data from the nft data-uri
        /// </summary>
        public string data_hash { get; set; }
        /// <summary>
        /// the nft data uris (eg, images)
        /// </summary>
        public List<string> data_uris { get; set; }
        public string launcher_id { get; set; }
        public string launcher_puzhash { get; set; }
        /// <summary>
        /// the sha256 hash of the license file for validation
        /// </summary>
        public string license_hash { get; set; }
        /// <summary>
        /// the license uris by which to find the license file
        /// </summary>
        public List<object> license_uris { get; set; }
        /// <summary>
        /// the sha256sum of the metadata jason files to validate them
        /// </summary>
        public string metadata_hash { get; set; }
        /// <summary>
        /// uris to metadata json files (by chip-0007 std.) to describe the NFT
        /// </summary>
        public List<object> metadata_uris { get; set; }
        /// <summary>
        /// the block height at which the NFT was Minted
        /// </summary>
        public int mint_height { get; set; }
        /// <summary>
        /// the sha256 unique coin id of the nft
        /// </summary>
        public string nft_coin_id { get; set; }
        /// <summary>
        /// the digital identity of the owner
        /// </summary>
        public string owner_did { get; set; }
        /// <summary>
        /// is the transaction still pending
        /// </summary>
        public bool pending_transaction { get; set; }
        /// <summary>
        /// how much royalty should be payed
        /// </summary>
        /// <remarks>
        /// a royalty percentage of 1000 = 1%
        /// </remarks>
        public int royalty_percentage { get; set; }
        /// <summary>
        /// the puzzlehash (address?) which should receive the loyalties
        /// </summary>
        public string royalty_puzzle_hash { get; set; }
        /// <summary>
        /// the number of the series which this nft has
        /// </summary>
        public int edition_number { get; set; }
        /// <summary>
        /// how many nfts the series/collection has in total
        /// </summary>
        public int edition_total { get; set; }
        public bool supports_did { get; set; }
        public string updater_puzhash { get; set; }
    }
}
