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
    /// <summary>
    /// the launcher id is a unique identifier like a coin id for nfts and so on
    /// </summary>
    public class LauncherID_RPC : RPCTemplate<LauncherID_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serialisation
        /// </summary>
        public LauncherID_RPC() { /* for serialisation*/ }
        /// <summary>
        /// the launcher id is a unique identifier like a coin id for nfts and so on
        /// </summary>
        /// <param name="launcher_id"></param>
        public LauncherID_RPC(string launcher_id)
        {
            this.launcher_id = launcher_id;
        }
        /// <summary>
        /// the launcher id is a unique identifier like a coin id for nfts and so on
        /// </summary>
        /// <param name="launcher_id">the launcher id response containing a launcher id</param>
        public LauncherID_RPC(LauncherID_Response launcher_id)
        {
            this.launcher_id = launcher_id.launcher_id;
        }

        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </remarks>
        public string launcher_id { get; set; }
        /// <summary>
        /// Implicit conversion from LauncherID_Response to LauncherID_RPC.
        /// </summary>
        /// <param name="response">LauncherID_RPC object</param>
        public static implicit operator LauncherID_RPC(LauncherID_Response response)
        {
            return new LauncherID_RPC(response);
        }
    }
}
