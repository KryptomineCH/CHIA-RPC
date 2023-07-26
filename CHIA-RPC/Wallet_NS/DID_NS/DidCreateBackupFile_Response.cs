using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response class for the did_create_backup_file API method
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_create_backup_file"/><br/><br/>
    /// uses: <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidCreateBackupFile_Response : ResponseTemplate<DidCreateBackupFile_Response>
    {
        /// <summary>
        /// Backup data of a DID wallet's metadata
        /// </summary>
        public string? backup_data { get; set; }

        /// <summary>
        /// Wallet ID
        /// </summary>
        public ulong? wallet_id { get; set; }
    }

}
