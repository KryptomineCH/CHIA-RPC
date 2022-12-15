
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text;

namespace CHIA_RPC.Wallet_RPC_NS.WalletManagement_NS
{
    public class CreateNewPoolWallet_RPC
    {
        public CreateNewPoolWallet_RPC()
        {
            wallet_type = "pool_wallet";
            mode = "new";
        }
        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string wallet_type { get; set; }
        /// <summary>
        /// Must be either new of recovery. However, recovery has not been implemented, so currently (version 1.6) it will automatically fail
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string mode { get; set; }
        /// <summary>
        /// This info should be sent from the daemon. 
        /// <list type="bullet">
        /// <item>PoolState is a type that is serialized to the blockchain to track the state of the user's pool singleton.</item>
        /// <item>target_puzzle_hash is either the pool address, or the self-pooling address that pool rewards will be paid to.</item>
        /// <item>target_puzzle_hash is NOT the p2_singleton puzzle that block rewards are sent to.</item>
        /// <item>The p2_singleton address is the initial address, and the target_puzzle_hash is the final destination.</item>
        /// <item>relative_lock_height is zero when in SELF_POOLING state</item>
        /// </list>
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public string initial_target_state { get; set; }
        /// <summary>
        /// *Required if mode is new. This is the puzzle hash to which payouts will go
        /// </summary>
        public string p2_singleton_delayed_ph { get; set; }
        /// <summary>
        /// The time (in seconds) to delay payments [Default: None ]
        /// </summary>
        public string p2_singleton_delay_time { get; set; }

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
        public static CreateNewPoolWallet_RPC Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            CreateNewPoolWallet_RPC rpc = JsonSerializer.Deserialize<CreateNewPoolWallet_RPC>(text);
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
