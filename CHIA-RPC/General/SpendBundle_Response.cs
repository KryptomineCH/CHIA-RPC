using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General
{
    public class SpendBundle_Response : ResponseTemplate<SpendBundle_Response>
    {
        /// <summary>
        /// the validation data for the recovery
        /// </summary>
        public SpendBundle spend_bundle { get; set; }
    }
}
