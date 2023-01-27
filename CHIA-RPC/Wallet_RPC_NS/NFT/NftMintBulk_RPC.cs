using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftMintBulk_RPC
    {
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
        public List<Metadata> metadata_list { get; set; }

        /// <summary>
        /// The royalty that will go to the original artist each time the NFT is sold
        /// </summary>
        public ulong royalty_percentage { get; set; }

        /// <summary>
        /// The wallet address of the NFT's artist. This is where royalties will be sent.
        /// </summary>
        public string royalty_address { get; set; }

        /// <summary>
        /// A list of wallet addresses where the NFTs will be sent upon minting
        /// </summary>
        public List<string> target_address_list { get; set; }

        /// <summary>
        /// The starting point for mint number used in intermediate launcher puzzle
        /// </summary>
        public ulong mint_number_start { get; set; }

        /// <summary>
        /// The total number of NFTs being minted
        /// </summary>
        public ulong mint_total { get; set; }

        /// <summary>
        /// A list of coins to be used for funding the minting spend
        /// </summary>
        /// <remarks>
        /// this is required if no fee is set. You may obtain it with the select coins by amont command
        /// </remarks>
        public List<string> xch_coin_list { get; set; }

        /// <summary>
        /// For use with bulk minting, so we can specify the puzzle hash that the change from the funding transaction goes to
        /// </summary>
        public string xch_change_target { get; set; }

        /// <summary>
        /// The new inner puzzle hash for the DID once it is spent
        /// </summary>
        public string new_innerpuzhash { get; set; }

        /// <summary>
        /// The new p2 puzzle hash for the DID once it is spent
        /// </summary>
        public string new_p2_puzhash { get; set; }

        /// <summary>
        /// The did coin to use for minting
        /// </summary>
        public object did_coin_dict { get; set; }

        /// <summary>
        /// The parent coin to use for the lineage proof in the DID spend
        /// </summary>
        public string did_lineage_parent_hex { get; set; }

        /// <summary>
        /// Boolean to determine whether to mint from a DID
        /// </summary>
        public bool? mint_from_did { get; set; }

        /// <summary>
        /// A blockchain fee (in mojos) to be deducted with each mint
        /// </summary>
        public ulong fee { get; set; }
        /// <summary>
        /// saves the rpc as rpc-file (json) to the specified path
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".rpc"))
            {
                path += ".rpc";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// loads an rpc file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static NftMintBulk_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftMintBulk_RPC rpc = JsonSerializer.Deserialize<NftMintBulk_RPC>(text);
            return rpc;
        }
        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string jsonString = JsonSerializer.Serialize(this, options: options);
            return jsonString;
        }
    }
    public class Metadata
    {
        public List<string> uris { get; set; }
        public List<string> meta_uris { get; set; }
        public List<string> license_uris { get; set; }
        public string hash { get; set; }
        public string meta_hash { get; set; }
        public string license_hash { get; set; }
        public ulong edition_number { get; set; }
        public ulong edition_total { get; set; }
    }
}
