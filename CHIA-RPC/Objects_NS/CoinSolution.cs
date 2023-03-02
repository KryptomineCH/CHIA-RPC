
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class CoinSolution : ObjectTemplate<CoinSolution>
    {
        public Coin coin { get; set; }
        public string puzzle_reveal { get; set; }
        public string solution { get; set; }
    }
}
