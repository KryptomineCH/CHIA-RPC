﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Use the database to restore all files for one or more local data stores
    /// Note: For remote stores, this command will do nothing. Use unsubscribe and subscribe instead
    /// Usage: chia rpc data_layer [OPTIONS] add_missing_files [REQUEST]
    /// </summary>
    /// <remarks>Request returns a Success_Response</remarks>
    public class AddMissingFiles_RPC : RPCTemplate<AddMissingFiles_RPC>
    {
        /// <summary>
        /// A list of hexadecimal store IDs to restore (default: all subscribed local stores)
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public string[]? ids { get; set; }

        /// <summary>
        /// If True, will overwrite files that already exist (default: False)
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public bool? override_files { get; set; }

        /// <summary>
        /// The name of the folder where the files to be restored are located (default: ~/.chia/mainnet/data_layer/db/server_files_location_<network>)
        /// </summary>
        /// <remarks>
        /// optional
        /// </remarks>
        public string? folder_name { get; set; }
    }
}