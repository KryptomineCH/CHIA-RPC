using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DLWallet_NS
{
    /// <summary>
    /// Represents the response for the dl_get_mirrors command.
    /// This command retrieves all of the mirrors for a specific singleton.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#dl_get_mirrors"/><br/><br/>
    /// Uses:<br/><see cref="General_NS.LauncherID_RPC"/>
    /// </remarks>
    public class DlGetMirrors_Response : ResponseTemplate<DlGetMirrors_Response>
    {
        /// <summary>
        /// An array of mirrors returned in the response.
        /// </summary>
        public Mirror[] mirrors { get; set; }
    }
}
