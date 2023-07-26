using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get information about configured uploader/downloader plugins
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#check_plugins"/><br/><br/>
    /// Uses:<br/><see cref="GetKeys_RPC"/>
    /// </remarks>
    public class CheckPlugins_Response : ResponseTemplate<CheckPlugins_Response>
    {
        /// <summary>
        /// unknown due to lacking documentation
        /// </summary>
        public dynamic? plugin_status { get; set; }
    }
}
