
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
{
    /// <summary>
    /// a did wallet is a digital identity
    /// </summary>
    public class CreateNewDIDWallet_RPC
    {
        public CreateNewDIDWallet_RPC()
        {
            wallet_type = "did_wallet";
            did_type = "new";
        }
        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; }
        /// <summary>
        /// Must be either new or recovery. If recovery, then each of the following parameters will be ignored
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string did_type { get; set; }
        /// <summary>
        /// TThe name of the DID wallet [Default: None]
        /// </summary>
        /// <remarks>optional</remarks>
        public string wallet_name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong amount { get; set; }
        /// <summary>
        /// *Required if did_type is new. An array of backup DID IDs to be used for recovery. Must match actual DIDs
        /// </summary>
        public string[] backup_dids { get; set; }
        /// <summary>
        /// *Required if did_type is new. The number of backup DIDs required for recovery. Minimum value is 1, maximum value is the number of DIDs in backup_dids
        /// </summary>
        public ulong num_of_backup_ids_needed { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
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
        public static CreateNewDIDWallet_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            CreateNewDIDWallet_RPC rpc = JsonSerializer.Deserialize<CreateNewDIDWallet_RPC>(text);
            return rpc;
        }
        /// <summary>
        /// serializes this object into a json string
        /// </summary>
        /// <returns>json formatted string</returns>
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
