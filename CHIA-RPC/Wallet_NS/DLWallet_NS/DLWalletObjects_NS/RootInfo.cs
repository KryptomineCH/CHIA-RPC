
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS.DLWalletObjects_NS
{
    /// <summary>
    /// Represents the detailed information of the root.
    /// Derived from the base class ObjectTemplate<RootInfo>.
    /// </summary>
    public class RootInfo : ObjectTemplate<RootInfo>
    {
        /// <summary>
        /// Represents the generation number of the root.
        /// </summary>
        public ulong generation { get; set; }

        /// <summary>
        /// Represents the node hash of the root.
        /// </summary>
        public string node_hash { get; set; }

        /// <summary>
        /// Represents the status of the root.
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// Represents the tree ID of the root, which is a hexadecimal store ID.
        /// </summary>
        public string tree_id { get; set; }
    }

}
