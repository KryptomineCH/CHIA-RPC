using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    public class TradeRecord_Response : ResponseTemplate<TradeRecord_Response>
    {
        public TradeRecord trade_record { get; set; }
    }
}
