using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.General_NS
{
    internal class TradeRecord_Response : ResponseTemplate<TradeRecord_Response>
    {
        TradeRecord trade_record { get; set; }
    }
}
