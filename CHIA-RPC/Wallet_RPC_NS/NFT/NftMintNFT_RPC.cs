using Chia_Metadata;
using CHIA_RPC.Objects_NS;
using NFT.Storage.Net;
using NFT.Storage.Net.API;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.Wallet_RPC_NS.NFT
{
    public class NftMintNFT_Response
    {
        public SpendBundle spend_bundle { get; set; }
        public ulong wallet_id { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
        /// <summary>
        /// this function converts the spendbundle into a coin-id.
        /// </summary>
        /// <returns>the resulting NftGetInfo_RPC can be used to look up the minted nft</returns>
        public NftGetInfo_RPC Get_NftGetInfo_Rpc()
        {
            NftGetInfo_RPC nftRequest = new NftGetInfo_RPC()
            {
                wallet_id = wallet_id,
                coin_id = spend_bundle.coin_solutions[0].coin.GetCoinID()
            };
            return nftRequest;
        }
        /// <summary>
        /// saves the NftMintNFT_Response as mint-file (json) to the specified path
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".mint"))
            {
                path += ".mint";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// loads a mint file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static NftMintNFT_Response Load(string path)
        {
            if (!path.EndsWith(".mint"))
            {
                path += ".mint";
            }
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftMintNFT_Response rpc = JsonSerializer.Deserialize<NftMintNFT_Response>(text);
            return rpc;
        }
    }
    public class NftMintNFT_RPC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="walletID">the wallet number with which the nft should be minted (select the correct nft did wallet)</param>
        /// <param name="royaltyFee">(the fee to be payed on future transactiont. 1.9 == 1.9%)</param>
        /// <param name="royaltyAddress">the address where future royaltyfees should be payed to</param>
        /// <param name="targetAddress">the address where the nft should be minted to</param>
        /// <param name="mintingFee_Mojos">the fee in mojos to be used for the minting transaction</param>
        public NftMintNFT_RPC(
            ulong walletID,
            string[] nftLinks, string[] metadataLinks, string[] licenseLinks = null,
            ulong royaltyFee = 190, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string targetAddress = null,
            ulong mintingFee_Mojos = 5000
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
            Chia_Metadata.Metadata meta = IO.LoadFromByteArray(metadata.Result);
            edition_number = meta.series_number;
            edition_total = meta.series_total;
            // weblinks
            uris = nftLinks.ToList();
            meta_uris = metadataLinks.ToList();
            license_uris = licenseLinks.ToList();
            // generate sha256sums for validation
            hash = Sha256.ValidateChecksums(nftLinks);
            meta_hash =Sha256.ValidateChecksums(metadataLinks);
            license_hash = Sha256.ValidateChecksums(licenseLinks);
        }
        public NftMintNFT_RPC()
        {
            // required for json deserializer
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
        }
        /// <summary>
        ///  the NFT wallet which should be used for minting
        /// </summary>
        public ulong wallet_id { get; set; }
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
        public string hash { get; private set; }
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
        public ulong royalty_percentage { get; private set; }
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
        public ulong edition_number { get; private set; }
        /// <summary>
        /// the edition total specifies ho many images there are within one collection
        /// </summary>
        /// <remarks>
        /// please set this correctly in the json metadata! it will be pulled from there
        /// </remarks>
        public ulong edition_total { get; private set; }
        /// <summary>
        /// the fee (in mojos) which should be spent for minting.
        /// </summary>
        /// <remarks>
        /// a fee under 1000 mojos won't even be included into hpool's mempool.
        /// </remarks>
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
        public static NftMintNFT_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            NftMintNFT_RPC rpc = JsonSerializer.Deserialize<NftMintNFT_RPC>(text);
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
}
