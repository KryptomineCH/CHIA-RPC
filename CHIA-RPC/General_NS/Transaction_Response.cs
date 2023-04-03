using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    public class Transaction_Response : ResponseTemplate<Transaction_Response>
    {
        public Transaction transaction { get; set; }
        public string transaction_id { get; set; }
    }
}
