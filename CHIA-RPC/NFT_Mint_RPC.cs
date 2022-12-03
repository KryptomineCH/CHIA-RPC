using Chia_Metadata;
using NFT.Storage.Net.API;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC
{
    public class NFT_Mint_RPC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="walletID">the wallet number with which the nft should be minted (select the correct nft did wallet)</param>
        /// <param name="royaltyFee">(the fee to be payed on future transactiont. 1.9 == 1.9%)</param>
        /// <param name="royaltyAddress">the address where future royaltyfees should be payed to</param>
        /// <param name="targetAddress">the address where the nft should be minted to</param>
        /// <param name="mintingFee_Mojos">the fee in mojos to be used for the minting transaction</param>
        public NFT_Mint_RPC(
            int walletID,
            string[] nftLinks, string[] metadataLinks, string[] licenseLinks = null,
            int royaltyFee = 190, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string targetAddress = null,
            int mintingFee_Mojos = 5000
            )
        {
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
            // payment data
            wallet_id = walletID;
            royalty_address = royaltyAddress;
            royalty_percentage = royaltyFee;
            target_address = targetAddress;
            fee = mintingFee_Mojos;
            // other information
            Task<byte[]> metadata = Task.Run(() => DownloadClient.DownloadAsync(metadataLinks[0]));
            metadata.Wait();
            Metadata meta = IO.LoadFromByteArray(metadata.Result);
            edition_number = meta.series_number;
            edition_total = meta.series_total;
            // weblinks
            uris = nftLinks.ToList();
            meta_uris = metadataLinks.ToList();
            license_uris = licenseLinks.ToList();
            // generate sha256sums for validation
            hash = NFT.Storage.Net.Sha256.ValidateChecksums(nftLinks);
            meta_hash = NFT.Storage.Net.Sha256.ValidateChecksums(metadataLinks);
            license_hash = NFT.Storage.Net.Sha256.ValidateChecksums(licenseLinks);
        }
        public NFT_Mint_RPC()
        {
            // required for json deserializer
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
        }
        /// <summary>
        ///  the NFT wallet which should be used for minting
        /// </summary>
        public int wallet_id { get; set; }
        /// <summary>
        /// set of urls for the image, document or whatever file is beeing uploaded
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal
        /// </remarks>
        public List<string> uris { get; set; }
        /// <summary>
        /// sha256 hashsum for the image, document or whatever file is beeing uploaded
        /// </summary>
        public string hash { get; private set;}
        /// <summary>
        /// urls for the metadata information json file
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal
        /// </remarks>
        public List<string> meta_uris { get; set; }
        /// <summary>
        /// sha256 hashsum for the metadata file
        /// </summary>
        public string meta_hash { get; private set; }
        /// <summary>
        /// urls to the license file
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal
        /// </remarks>
        public List<string> license_uris { get; set; }
        /// <summary>
        /// sha256 hashsum for the license file
        /// </summary>
        public string license_hash { get; private set; }
        /// <summary>
        /// future transactions will pay a royalty fee to this address
        /// </summary>
        public string royalty_address { get; set; }
        /// <summary>
        /// the royalty amount in rpc format.
        /// </summary>
        /// <remarks>
        /// 100 = 1% <br/>
        /// 150 = 1.5% <br/>
        /// 1250 = 12.5%
        /// </remarks>
        public int royalty_percentage { get; private set; }
        /// <summary>
        /// The target address which will be the first owner of the nft
        /// </summary>
        public string target_address { get; set; }
        /// <summary>
        /// the edition number specifies the number of the nft in the whole collection. 
        /// Every number should be unique for each collection
        /// </summary>
        /// <remarks>
        /// please set this correctly in the json metadata! it will be pulled from there
        /// </remarks>
        public int edition_number { get; private set; }
        /// <summary>
        /// the edition total specifies ho many images there are within one collection
        /// </summary>
        /// <remarks>
        /// please set this correctly in the json metadata! it will be pulled from there
        /// </remarks>
        public int edition_total { get; private set; }
        /// <summary>
        /// the fee (in mojos) which should be spent for minting.
        /// </summary>
        /// <remarks>
        /// a fee under 1000 mojos won't even be included into hpool's mempool.
        /// </remarks>
        public int fee { get; set; }
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
            File.WriteAllText(path, testText, Encoding.UTF8);
        }

        public static NFT_Mint_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NFT_Mint_RPC rpc = JsonSerializer.Deserialize<NFT_Mint_RPC>(text);
            return rpc;
        }
    }
}
