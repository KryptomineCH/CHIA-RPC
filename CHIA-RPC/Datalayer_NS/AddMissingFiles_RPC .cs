using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Use the database to restore all files for one or more owned data stores
    /// Note: For subscribed stores, this command will do nothing. Use [unsubscribe](#unsubscribe) and [subscribe](#subscribe) instead
    /// Usage: chia rpc data_layer [OPTIONS] add_missing_files [REQUEST]
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc#add_missing_files"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class AddMissingFiles_RPC : RPCTemplate<AddMissingFiles_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public AddMissingFiles_RPC() { /* required for json serialisation */ }
        /// <summary>
        /// Use the database to restore all files for one or more owned data stores
        /// </summary>
        /// <param name="ids">A list of hexadecimal store IDs to restore (default: all subscribed stores)</param>
        /// <param name="override_files">If True, will overwrite files that already exist (default: False)</param>
        /// <param name="foldername">The name of the folder where the files to be restored are located (default: ~/.chia/mainnet/data_layer/db/server_files_location_{network})</param>
        public AddMissingFiles_RPC(string[]? ids = null, bool? override_files = null, string? foldername = null)
        {
            this.ids = ids;
            this.override_files = override_files;
            this.foldername = foldername;
        }

        /// <summary>
        /// A list of hexadecimal store IDs to restore (default: all subscribed stores)
        /// </summary>
        /// <remarks>optional</remarks>
        public string[]? ids { get; set; }

        /// <summary>
        /// If True, will overwrite files that already exist (default: False)
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? override_files { get; set; }

        /// <summary>
        /// The name of the folder where the files to be restored are located (default: ~/.chia/mainnet/data_layer/db/server_files_location_<network>)
        /// </summary>
        /// <remarks>optional</remarks>
        public string? foldername { get; set; }
    }
}
