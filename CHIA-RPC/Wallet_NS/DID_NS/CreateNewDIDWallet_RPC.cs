using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.HelperFunctions_NS.JsonConverters_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// a did wallet is a digital identity
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#create_new_wallet"/><br/><br/>
    /// Uses:<br/><see cref="CreateNewDIDWallet_RPC"/>
    /// </remarks>
    public class CreateNewDIDWallet_Response : ResponseTemplate<CreateNewDIDWallet_Response>
    {
        /// <summary>
        /// dhe did id of the created wallet
        /// </summary>
        public string my_did { get; set; }
        /// <summary>
        /// the type of the created wallet (did)
        /// </summary>
        public WalletType type { get; set; }
        /// <summary>
        /// the wallet id identifier
        /// </summary>
        public ulong wallet_id { get; set; }
    }
    /// <summary>
    /// Create a new DID wallet (From the Chia wallet RPC endpoint)
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#create_new_wallet"/></remarks>
    /// <returns><see cref="CreateNewDIDWallet_Response"/></returns>
    public class CreateNewDIDWallet_RPC : RPCTemplate<CreateNewDIDWallet_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateNewDIDWallet_RPC() { /* for serialisation */ }
        /// <summary>
        /// Create a new DID wallet (From the Chia wallet RPC endpoint)
        /// </summary>
        /// <param name="backupDids">*Required if did_type is new. An array of backup DID IDs to be used for recovery. Must match actual DIDs</param>
        /// <param name="numOfBackupIdsNeeded">*Required if did_type is new. The number of backup DIDs required for recovery. Minimum value is 1, maximum value is the number of DIDs in backup_dids</param>
        /// <param name="didType">Must be either new or recovery. If recovery, then each of the following parameters will be ignored</param>
        /// <param name="walletName">The name of the DID wallet [Default: None]</param>
        /// <param name="amount">*Required if mode is new. Specify the value, in mojos, of this wallet</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public CreateNewDIDWallet_RPC(string[] backupDids, ulong numOfBackupIdsNeeded, string didType = "new", string walletName = null, ulong amount = 1, ulong? fee = null)
        {
            this.did_type = didType;
            this.wallet_name = walletName;
            this.amount = amount;
            this.backup_dids = backupDids;
            this.num_of_backup_ids_needed = numOfBackupIdsNeeded;
            this.fee = fee;
        }

        /// <summary>
        /// The type of wallet to create. Must be one of cat_wallet, did_wallet, nft_wallet, or pool_wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        [JsonConverter(typeof(StringToEnumConverter<WalletType>))]
        public WalletType wallet_type { get; set; } = WalletType.did_wallet;
        /// <summary>
        /// Must be either new or recovery. If recovery, then each of the following parameters will be ignored
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string did_type { get; set; } = "new";
        /// <summary>
        /// The name of the DID wallet [Default: None]
        /// </summary>
        /// <remarks>optional</remarks>
        public string? wallet_name { get; set; }
        /// <summary>
        /// *Required if mode is new. Specify the value, in mojos, of this wallet
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong amount { get; set; } = 1;
        /// <summary>
        /// *Required if did_type is new. An array of backup DID IDs to be used for recovery. Must match actual DIDs
        /// </summary>
        /// <remarks>*conditional mandatory*</remarks>
        public string[] backup_dids { get; set; }
        /// <summary>
        /// *Required if did_type is new. The number of backup DIDs required for recovery. Minimum value is 1, maximum value is the number of DIDs in backup_dids
        /// </summary>
        /// <remarks>*conditional mandatory*</remarks>
        public ulong num_of_backup_ids_needed { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
