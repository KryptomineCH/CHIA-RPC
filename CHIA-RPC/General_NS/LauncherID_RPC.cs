using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class LauncherID_Response : ResponseTemplate<LauncherID_Response>
    {
        /// <summary>
        /// eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </summary>
        public string launcher_id { get; set; }
    }
    public class LauncherID_RPC : RPCTemplate<LauncherID_RPC>
    {
        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </remarks>
        public string launcher_id { get; set; }
    }
}
