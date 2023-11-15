using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class AssetInfo : ObjectTemplate<AssetInfo>
    {
        /// <summary>
        /// Unique identifier of the item.
        /// </summary>
        public string tail { get; set; }

        /// <summary>
        /// Type of the item.
        /// </summary>
        public string type { get; set; }
    }

}