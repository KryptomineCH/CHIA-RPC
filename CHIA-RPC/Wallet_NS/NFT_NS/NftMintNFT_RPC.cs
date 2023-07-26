using Chia_Metadata;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using NFT.Storage.Net;
using NFT.Storage.Net.API;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Represents a response received after minting a Non-Fungible Token (NFT) in the Chia network.
    /// </summary>
    /// <remarks>
    /// This response is generated after a successful NFT minting operation and includes details about the SpendBundle and the wallet ID involved in the operation.
    /// <br/>
    /// <see href="https://docs.chia.net/nft-rpc#nft_mint_nft"/><br/><br/>
    /// Uses:<br/><see cref="NftMintNFT_RPC"/>
    /// </remarks>
    public class NftMintNFT_Response : ResponseTemplate<NftMintNFT_Response>
    {
        /// <summary>
        /// The SpendBundle associated with the NFT minting operation.
        /// </summary>
        /// <remarks>
        /// A SpendBundle represents a transaction in the Chia network. In this context, it represents the NFT minting transaction.
        /// </remarks>
        public SpendBundle? spend_bundle { get; set; }

        /// <summary>
        /// The ID of the wallet used for the NFT minting operation.
        /// </summary>
        /// <remarks>
        /// Each Chia wallet has a unique ID, and this attribute indicates the wallet that was used for the minting operation.
        /// </remarks>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// Constructs a NftGetInfo_RPC request based on this response.
        /// </summary>
        /// <returns>An NftGetInfo_RPC request if a SpendBundle exists, null otherwise.</returns>
        /// <remarks>
        /// This method uses the SpendBundle from the minting operation to construct a new request for information about the minted NFT.
        /// </remarks>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="InvalidDataException"></exception>
        public NftGetInfo_RPC? Get_NftGetInfo_RPC()
        {
            if (spend_bundle == null)
            {
                throw new NullReferenceException(nameof(spend_bundle));
            }
            if (spend_bundle.coin_solutions == null)
            {
                throw new NullReferenceException(nameof(spend_bundle.coin_solutions));
            }
            if (spend_bundle.coin_solutions.Length == 0)
            {
                throw new InvalidDataException("spend_bundle.coin_solutions is empty!");
            }
            if (spend_bundle.coin_solutions[0].coin == null)
            {
                throw new NullReferenceException("spend_bundle.coin_solutions.coin is null!");
            }
            string? coinID = spend_bundle.coin_solutions[0].coin!.GetCoinID();
            if (string.IsNullOrEmpty(coinID))
            {
                throw new InvalidDataException("coin id could not be fetched!");
            }
            NftGetInfo_RPC nftRequest = new NftGetInfo_RPC
            {
                coin_id = coinID,
                wallet_id = wallet_id
            };
            return nftRequest;
        }

        /// <summary>
        /// Implicit conversion from a NftMintNFT_Response to a NftGetInfo_RPC.
        /// </summary>
        /// <param name="response">The NftMintNFT_Response to convert.</param>
        /// <returns>An NftGetInfo_RPC request based on the NftMintNFT_Response.</returns>
        /// <remarks>
        /// This operator allows an NftMintNFT_Response to be used where an NftGetInfo_RPC request is expected, simplifying code when making follow-up requests based on a response.
        /// </remarks>
        public static implicit operator NftGetInfo_RPC?(NftMintNFT_Response response)
        {
            return response.Get_NftGetInfo_RPC();
        }
    }

    /// <summary>
    /// Mint a new NFT
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_mint_nft"/></remarks>
    /// <returns><see cref="NftMintNFT_Response"/></returns>
    public class NftMintNFT_RPC : RPCTemplate<NftMintNFT_RPC>
    {
        /// <summary>
        /// Mint a new Non-Fungible Token (NFT).
        /// </summary>
        /// <param name="walletID">The unique identifier of the wallet that will own the minted NFT.</param>
        /// <param name="nftLinks">An array of links associated with the NFT. Typically, these would be links to images or other digital assets that the NFT represents.</param>
        /// <param name="metadataLinks">An array of links to the metadata associated with the NFT. This metadata can contain a variety of information, including details about the NFT's creation, information about the asset it represents, and more.</param>
        /// <param name="licenseLinks">An optional array of links to licenses associated with the NFT. If the NFT is related to copyrighted material, this could include links to information about the copyright or licenses for use of the asset.</param>
        /// <param name="royaltyFee">The royalty fee for the NFT, expressed as a percentage of the sale price. This fee will be paid to the original creator of the NFT any time the NFT is sold. The default value is 190, or 19.0%.</param>
        /// <param name="royaltyAddress">The address where royalty payments should be sent. This would typically be the address of the original creator of the NFT.</param>
        /// <param name="targetAddress">The optional address where the NFT will be sent after it is minted. If no address is specified, the NFT will remain in the wallet that minted it.</param>
        /// <param name="mintingFee_Mojos">The fee for minting the NFT, expressed in mojos. The default fee is 5000 mojos.</param>

        public NftMintNFT_RPC(
            ulong walletID,
            string[] nftLinks, string[] metadataLinks, string[]? licenseLinks = null,
            ulong royaltyFee = 190, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string? targetAddress = null,
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
            if (licenseLinks != null)
            {
                license_uris = licenseLinks.ToList();
                license_hash = Sha256.ValidateChecksums(licenseLinks);
            }
            // generate sha256sums for validation
            hash = Sha256.ValidateChecksums(nftLinks);
            meta_hash =Sha256.ValidateChecksums(metadataLinks);
            
        }
        /// <summary>
        /// Mint a new Non-Fungible Token (NFT).
        /// </summary>
        /// <param name="walletID">The unique identifier of the wallet that will own the minted NFT.</param>
        /// <param name="nftLinks">An array of links associated with the NFT. Typically, these would be links to images or other digital assets that the NFT represents.</param>
        /// <param name="metadataLinks">An array of links to the metadata associated with the NFT. This metadata can contain a variety of information, including details about the NFT's creation, information about the asset it represents, and more.</param>
        /// <param name="licenseLinks">An optional array of links to licenses associated with the NFT. If the NFT is related to copyrighted material, this could include links to information about the copyright or licenses for use of the asset.</param>
        /// <param name="royaltyFee">The royalty fee for the NFT, expressed as a percentage of the sale price. This fee will be paid to the original creator of the NFT any time the NFT is sold. The default value is 190, or 19.0%.</param>
        /// <param name="royaltyAddress">The address where royalty payments should be sent. This would typically be the address of the original creator of the NFT.</param>
        /// <param name="targetAddress">The optional address where the NFT will be sent after it is minted. If no address is specified, the NFT will remain in the wallet that minted it.</param>
        /// <param name="mintingFee_Mojos">The fee for minting the NFT, expressed in mojos. The default fee is 5000 mojos.</param>
        public NftMintNFT_RPC(
            WalletID_RPC walletID,
            string[] nftLinks, string[] metadataLinks, string[]? licenseLinks = null,
            ulong royaltyFee = 190, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string? targetAddress = null,
            ulong mintingFee_Mojos = 5000
            )
        {
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
            // payment data
            wallet_id = walletID.wallet_id;
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
            if (licenseLinks != null)
            {
                license_uris = licenseLinks.ToList();
                license_hash = Sha256.ValidateChecksums(licenseLinks);
            }
            // generate sha256sums for validation
            hash = Sha256.ValidateChecksums(nftLinks);
            meta_hash = Sha256.ValidateChecksums(metadataLinks);
        }
        /// <summary>
        /// Mint a new Non-Fungible Token (NFT).
        /// </summary>
        /// <param name="walletID">The unique identifier of the wallet that will own the minted NFT.</param>
        /// <param name="nftLinks">An array of links associated with the NFT. Typically, these would be links to images or other digital assets that the NFT represents.</param>
        /// <param name="metadataLinks">An array of links to the metadata associated with the NFT. This metadata can contain a variety of information, including details about the NFT's creation, information about the asset it represents, and more.</param>
        /// <param name="licenseLinks">An optional array of links to licenses associated with the NFT. If the NFT is related to copyrighted material, this could include links to information about the copyright or licenses for use of the asset.</param>
        /// <param name="royaltyFee">The royalty fee for the NFT, expressed as a percentage of the sale price. This fee will be paid to the original creator of the NFT any time the NFT is sold. The default value is 190, or 19.0%.</param>
        /// <param name="royaltyAddress">The address where royalty payments should be sent. This would typically be the address of the original creator of the NFT.</param>
        /// <param name="targetAddress">The optional address where the NFT will be sent after it is minted. If no address is specified, the NFT will remain in the wallet that minted it.</param>
        /// <param name="mintingFee_xch">The fee for minting the NFT, expressed in xch. The default fee is 0.0000005m xch.</param>
        public NftMintNFT_RPC(
            ulong walletID,
            string[] nftLinks, string[] metadataLinks, string[]? licenseLinks = null,
            double royaltyFee = 1.9, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string? targetAddress = null,
            decimal mintingFee_xch = 0.0000005m
            )
        {
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
            // payment data
            wallet_id = walletID;
            royalty_address = royaltyAddress;
            royalty_in_percent = royaltyFee;
            target_address = targetAddress;
            fee_in_xch = mintingFee_xch;
            // other information
            Task<byte[]> metadata = Task.Run(() => DownloadClient.DownloadAsync(metadataLinks[0]));
            metadata.Wait();
            Chia_Metadata.Metadata meta = IO.LoadFromByteArray(metadata.Result);
            edition_number = meta.series_number;
            edition_total = meta.series_total;
            // weblinks
            uris = nftLinks.ToList();
            meta_uris = metadataLinks.ToList();
            if (licenseLinks != null)
            {
                license_uris = licenseLinks.ToList();
                license_hash = Sha256.ValidateChecksums(licenseLinks);
            }
            // generate sha256sums for validation
            hash = Sha256.ValidateChecksums(nftLinks);
            meta_hash = Sha256.ValidateChecksums(metadataLinks);
        }
        /// <summary>
        /// Mint a new Non-Fungible Token (NFT).
        /// </summary>
        /// <param name="walletID">The unique identifier of the wallet that will own the minted NFT.</param>
        /// <param name="nftLinks">An array of links associated with the NFT. Typically, these would be links to images or other digital assets that the NFT represents.</param>
        /// <param name="metadataLinks">An array of links to the metadata associated with the NFT. This metadata can contain a variety of information, including details about the NFT's creation, information about the asset it represents, and more.</param>
        /// <param name="licenseLinks">An optional array of links to licenses associated with the NFT. If the NFT is related to copyrighted material, this could include links to information about the copyright or licenses for use of the asset.</param>
        /// <param name="royaltyFee">The royalty fee for the NFT, expressed as a percentage of the sale price. This fee will be paid to the original creator of the NFT any time the NFT is sold. The default value is 190, or 19.0%.</param>
        /// <param name="royaltyAddress">The address where royalty payments should be sent. This would typically be the address of the original creator of the NFT.</param>
        /// <param name="targetAddress">The optional address where the NFT will be sent after it is minted. If no address is specified, the NFT will remain in the wallet that minted it.</param>
        /// <param name="mintingFee_xch">The fee for minting the NFT, expressed in xch. The default fee is 0.0000005m xch.</param>
        public NftMintNFT_RPC(
            WalletID_RPC walletID,
            string[] nftLinks, string[] metadataLinks, string[]? licenseLinks = null,
            double royaltyFee = 1.9, string royaltyAddress = "xch1548hhy66czjf026cc9a3efsu2mrjh9he3w5rna3rsrenlyhpe9dq5u7f4g", string? targetAddress = null,
            decimal mintingFee_xch = 0.0000005m
            )
        {
            uris = new List<string>();
            meta_uris = new List<string>();
            license_uris = new List<string>();
            // payment data
            wallet_id = walletID.wallet_id;
            royalty_address = royaltyAddress;
            royalty_in_percent = royaltyFee;
            target_address = targetAddress;
            fee_in_xch = mintingFee_xch;
            // other information
            Task<byte[]> metadata = Task.Run(() => DownloadClient.DownloadAsync(metadataLinks[0]));
            metadata.Wait();
            Chia_Metadata.Metadata meta = IO.LoadFromByteArray(metadata.Result);
            edition_number = meta.series_number;
            edition_total = meta.series_total;
            // weblinks
            uris = nftLinks.ToList();
            meta_uris = metadataLinks.ToList();
            if (licenseLinks != null)
            {
                license_uris = licenseLinks.ToList();
                license_hash = Sha256.ValidateChecksums(licenseLinks);
            }
            // generate sha256sums for validation
            hash = Sha256.ValidateChecksums(nftLinks);
            meta_hash = Sha256.ValidateChecksums(metadataLinks);
        }
        /// <summary>
        /// this one is used for serialisation / deserialisation
        /// </summary>
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
        /// <remarks>mandatory</remarks>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// set of urls for the image, document or whatever file is beeing uploaded
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal<br/><br/>
        /// mandatory
        /// </remarks>
        public List<string>? uris { get; set; }

        /// <summary>
        /// The hash of the NFT's data. This should use sha256 for proper verification against the URI list 
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? hash { get; set; }

        /// <summary>
        /// Optionally specify the DID to be associated with this NFT
        /// </summary>
        /// <remarks>
        /// If not specified and mint with did is choosen, automatically uses the wallets did<br/><br/>
        /// optional
        /// </remarks>
        public string? did_id { get; set; }

        /// <summary>
        /// urls for the metadata information json file
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal<br/><br/>
        /// optional
        /// </remarks>
        public List<string>? meta_uris { get; set; }

        /// <summary>
        /// sha256 hashsum for the metadata file
        /// </summary>
        /// <remarks>mandatory if meta uris are provided</remarks>
        public string? meta_hash { get; set; }

        /// <summary>
        /// urls to the license file
        /// </summary>
        /// <remarks>
        /// Multiple backup links have to be provided but all data needs to be equal<br/><br/>
        /// optional
        /// </remarks>
        public List<string>? license_uris { get; set; }

        /// <summary>
        /// sha256 hashsum for the license file
        /// </summary>
        /// <remarks>mandatory, if license links are provided</remarks>
        public string? license_hash { get; set; }

        /// <summary>
        /// future transactions will pay a royalty fee to this address
        /// </summary>
        /// <remarks>optional</remarks>
        public string? royalty_address { get; set; }

        /// <summary>
        /// the royalty amount in rpc format.
        /// </summary>
        /// <remarks>
        /// 100 = 1% <br/>
        /// 150 = 1.5% <br/>
        /// 1250 = 12.5%<br/><br/>
        /// optional
        /// </remarks>
        public ulong? royalty_percentage { get; set; }
        /// <summary>
        /// the royalty amount in floating point format.
        /// </summary>
        /// <remarks>100 = 100%<br/>
        /// 1.5 = 1.5%</remarks>
        [JsonIgnore]
        public double? royalty_in_percent
        {
            get { return royalty_percentage / 100.0; }
            set { royalty_percentage = (ulong?)(value * 100); }
        }

        /// <summary>
        /// The target address which will be the first owner of the nft
        /// </summary>
        /// <remarks>optional, defaults to the wallet wich the nft was minted with</remarks>
        public string? target_address { get; set; }

        /// <summary>
        /// the edition number specifies the number of the nft in the whole collection. 
        /// Every number should be unique for each collection
        /// </summary>
        /// <remarks>
        /// please set this correctly in the json metadata! it will be pulled from there<br/><br/>
        /// optional
        /// </remarks>
        public ulong? edition_number { get; set; }

        /// <summary>
        /// the edition total specifies ho many images there are within one collection
        /// </summary>
        /// <remarks>
        /// please set this correctly in the json metadata! it will be pulled from there<br/><br/>
        /// optional
        /// </remarks>
        public ulong? edition_total { get; set; }

        /// <summary>
        /// the fee (in mojos) which should be spent for minting.
        /// </summary>
        /// <remarks>
        /// a fee under 1000 mojos won't even be included into hpool's mempool.<br/><br/>
        /// optional
        /// </remarks>
        public ulong? fee { get; set; }
        /// <summary>
        /// the amount of xch to set as fee
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonIgnore]
        public decimal? fee_in_xch
        {
            get { return fee / General_NS.GlobalVar.OneChiaInMojos; }
            set { fee = (ulong?)(value * General_NS.GlobalVar.OneChiaInMojos); }
        }

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
