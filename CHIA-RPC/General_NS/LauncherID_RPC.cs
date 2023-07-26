using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// The LauncherID_Response class represents a response from the RPC call that contains the launcher id.
    /// Launcher ID is a unique identifier similar to a coin id for NFTs etc.
    /// </summary>
    public class LauncherID_Response : ResponseTemplate<LauncherID_Response>
    {
        /// <summary>
        /// The unique launcher id returned by the RPC call.
        /// </summary>
        /// <example>
        /// Example: did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </example>
        public string? launcher_id { get; set; }
    }

    /// <summary>
    /// The LauncherID_RPC class is used to perform RPC requests related to the launcher id.
    /// </summary>
    /// <remarks>
    /// The launcher id is a unique identifier similar to a coin id for NFTs etc.
    /// </remarks>
    public class LauncherID_RPC : RPCTemplate<LauncherID_RPC>
    {
        /// <summary>
        /// Parameterless constructor required for serialization.
        /// </summary>
        public LauncherID_RPC() { /* for serialization*/ }

        /// <summary>
        /// Initializes a new instance of the LauncherID_RPC class.
        /// </summary>
        /// <param name="launcher_id">The unique launcher id.</param>
        public LauncherID_RPC(string launcher_id)
        {
            this.launcher_id = launcher_id;
        }

        /// <summary>
        /// Initializes a new instance of the LauncherID_RPC class using a LauncherID_Response object.
        /// </summary>
        /// <param name="launcher_id">The LauncherID_Response object containing the launcher id.</param>
        public LauncherID_RPC(LauncherID_Response launcher_id)
        {
            this.launcher_id = launcher_id.launcher_id;
        }

        /// <summary>
        /// The unique launcher id for the wallet from which to obtain the balance.
        /// </summary>
        /// <example>
        /// Example: did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </example>
        public string? launcher_id { get; set; }

        /// <summary>
        /// Provides an implicit conversion from a LauncherID_Response object to a LauncherID_RPC object.
        /// This allows a LauncherID_Response object to be treated as a LauncherID_RPC object.
        /// </summary>
        /// <param name="response">The LauncherID_Response object to be converted.</param>
        public static implicit operator LauncherID_RPC(LauncherID_Response response)
        {
            return new LauncherID_RPC(response);
        }
    }

}
