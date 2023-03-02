using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json;
namespace CHIA_RPC.Objects_NS
{
    public class SpendBundle : ObjectTemplate<SpendBundle>
    {
        public string aggregated_signature { get; set; }
        public Spend[] coin_spends { get; set; }
        public Spend[] coin_solutions { get; set; }
        public override string ToString()
        {
            string json = JsonSerializer.Serialize<SpendBundle>(this);
            return json;
        }
    }
    public class Spend : ObjectTemplate<Spend>
    {
        public Coin coin { get; set; }
        public string puzzle_reveal { get; set; }
        public string solution { get; set; }
    }
}
