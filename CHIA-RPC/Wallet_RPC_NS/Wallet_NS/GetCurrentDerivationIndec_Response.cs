using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class GetCurrentDerivationIndec_Response : ResponseTemplate<GetCurrentDerivationIndec_Response>
    {
        public ulong index { get; set; }
    }
}
