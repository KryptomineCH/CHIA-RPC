using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    public class SpendBundle_Response : ResponseTemplate<SpendBundle_Response>
    {
        /// <summary>
        /// the validation data for the recovery
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
        /// <summary>
        /// optionally, the answer might contain the wallet ID which this Spend Bundle was associated to
        /// </summary>
        public ulong? wallet_id { get; set; }
    }
    public class SpendBundle_MultiWallet_Response : ResponseTemplate<SpendBundle_MultiWallet_Response>
    {
        /// <summary>
        /// the validation data for the recovery
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
        /// <summary>
        /// optionally, the answer might contain the wallet ID which this Spend Bundle was associated to
        /// </summary>
        public ulong[]? wallet_id { get; set; }
    }
}
